using Shared.IdentityDtos;

namespace Services.Abstraction
{
    public interface IAuthenticationService
    {
        public Task<UserResultDto> LoginAsync(LoginDto loginDto);
        public Task<UserResultDto> RegisterAsync(RegisterDto registerDto);
        public Task<UserResultDto> GetUserByEmailAsync(string email);
        public Task<bool> isEmailExistAsync(string email);
        public Task<AddressDto> GetUserAddressAsync(string email);
        public Task<AddressDto> UpdateUserAddressAsync(string email, AddressDto addressDto);
    }
}
