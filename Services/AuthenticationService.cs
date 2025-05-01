using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Domain.Entities.Identity;
using Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Services.Abstraction;
using Shared.IdentityDtos;

namespace Services
{
    public class AuthenticationService(UserManager<User> userManager,
        IMapper mapper,
        IOptions<JwtOptions> options) : IAuthenticationService
    {
        public async Task<AddressDto> GetUserAddressAsync(string email)
        {
            var user = await userManager.Users.Include(x => x.Address)
                                              .FirstOrDefaultAsync(user => user.Email == email);

            if(user is null) 
                throw new UserNotFoundException(email);

            return mapper.Map<AddressDto>(user.Address);
        }

        public async Task<UserResultDto> GetUserByEmailAsync(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            if (user is null)
                throw new UserNotFoundException(email);

            return new UserResultDto
            (
                DisplayName: user.DisplayName,
                Email: user.Email,
                Token: null
            );
        }

        public async Task<bool> isEmailExistAsync(string email)
        {
            var user = await userManager.FindByEmailAsync(email);

            return user != null;
        }

        public async Task<UserResultDto> LoginAsync(LoginDto loginDto)
        {
            var user = await userManager.FindByEmailAsync(loginDto.Email);

            if (user is null)
                throw new UnAuthorizedException($"Email {loginDto.Email} does not existed!!");

            var result = await userManager.CheckPasswordAsync(user, loginDto.Password);

            if(!result)
                throw new UnAuthorizedException("Password is incorrect!!");

            return new UserResultDto
            (
                DisplayName: user.DisplayName,
                Email: loginDto.Email,
                Token: await CreateTokenAsync(user)
            );
        }

        public async Task<UserResultDto> RegisterAsync(RegisterDto registerDto)
        {
            var user = new User
            {
                Email = registerDto.Email,
                DisplayName = registerDto.DisplayName,
                UserName = registerDto.UserName,
                PhoneNumber = registerDto.PhoneNumber
            };

            var result = await userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(x => x.Description).ToList();

                throw new ValidationException(errors);
            }

            return new UserResultDto
            (
                DisplayName: user.DisplayName,
                Email: registerDto.Email,
                Token: await CreateTokenAsync(user)
            );
        }

        public async Task<AddressDto> UpdateUserAddressAsync(string email, AddressDto addressDto)
        {
            var user = await userManager.Users.Include(x => x.Address)
                                              .FirstOrDefaultAsync(user => user.Email == email);

            if (user is null)
                throw new UserNotFoundException(email);

            var mappedAddress = mapper.Map<Address>(addressDto);
            user.Address = mappedAddress;

            await userManager.UpdateAsync(user);

            return addressDto;
        }

        private async Task<string> CreateTokenAsync(User user)
        {
            var jwtOptions = options.Value;
            // Prepare the Token Payload:
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var roles = await userManager.GetRolesAsync(user);

            foreach (var role in roles)
                claims.Add(new Claim(ClaimTypes.Role, role));

            // Prepare the Token Signature:
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecurityKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // assemble the Token:
            var token = new JwtSecurityToken
            (
                claims: claims,
                signingCredentials: creds,
                expires: DateTime.UtcNow.AddDays(jwtOptions.DurationInDays),
                audience: jwtOptions.Audience,
                issuer: jwtOptions.Issuer
            );

            // return the Token:
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
