using Assignment_1.Q1;
using Assignment_1.Q2;
using Assignment_1.Q3;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region C#_Session_7(OOP_4) -> Assignment_7

            #region Question 1)
            /*
                Question 1:
                    What is the primary purpose of an interface in C#?
                        a) To provide a way to implement multiple inheritance
                        b) To define a blueprint for a class
                        c) To declare abstract methods and properties
                        d) To create instances of objects
            */

            // Answer: b) To define a blueprint for a class
            #endregion

            #region Question 2)
            /*
                Question 2:
                    Which of the following is NOT a valid access modifier for interface members in C#?
                        a) private
                        b) protected
                        c) internal
                        d) public
            */

            // Answer: a) private -> default implemented method can be private starting from C#8 and .NET core3
            #endregion

            #region Question 3)
            /*
                Question 3:
                    Can an interface contain fields in C#?
                        a) Yes
                        b) No
                        c) Only if they are static
                        d) Only if they are read only
            */

            // Answer: c) Only if they are static
            #endregion

            #region Question 4)
            /*
                Question 4:
                    In C#, can an interface inherit from another interface?
                        a) No, interfaces cannot inherit from each other
                        b) Yes, interfaces can inherit from multiple interfaces
                        c) Yes, but only if they have the same methods
                        d) Only if the interfaces are in the same namespace
            */

            // Answer: b) Yes, interfaces can inherit from multiple interfaces

            // An interface can inherit from one or more other interfaces.
            // This allows you to combine the functionality of multiple interfaces into a single interface.
            // The inheriting interface inherits all the members(methods, properties, events, indexers) of the interfaces it inherits from.
            #endregion

            #region Question 5)
            /*
                Question 5:
                    Which keyword is used to implement an interface in a class in C#?
                        a) inherit
                        b) use
                        c) extends
                        d) implements
            */

            // Answer: d) implements
            #endregion

            #region Question 6)
            /*
                Question 6:
                    Can an interface contain static methods in C#?
                        a) Yes
                        b) No
                        c) Only if the interface is sealed
                        d) Only if the methods are private
            */

            // Answer: a) Yes
            #endregion

            #region Question 7)
            /*
                Question 7:
                    In C#, can an interface have explicit access modifiers for its members?
                        a) Yes, for all members
                        b) No, all members are implicitly public
                        c) Yes, but only for abstract members
                        d) Only if the interface is sealed
            */

            // Answer: b) No, all members are implicitly public
            #endregion

            #region Question 8)
            /*
                Question 8:
                    What is the purpose of an explicit interface implementation in C#?
                        a) To hide the interface members from outside access
                        b) To provide a clear separation between interface and class members
                        c) To allow multiple classes to implement the same interface
                        d) To speed up method resolution
            */

            // Answer: b) To provide a clear separation between interface and class members
            #endregion

            #region Question 9)
            /*
                Question 9:
                    In C#, can an interface have a constructor?
                        a) Yes, but it must be private
                        b) No, interfaces cannot have constructors
                        c) Yes, but only if the interface is sealed
                        d) Only if the constructor is static
            */

            // Answer: d) Only if the constructor is static
            #endregion

            #region Question 10)
            /*
                Question 10:
                    How can a C# class implement multiple interfaces?
                        a) By using the "implements" keyword
                        b) By using the "extends" keyword
                        c) By separating interface names with commas
                        d) A class cannot implement multiple interfaces
            */

            // Answer: c) By separating interface names with commas
            #endregion

            #region part02 - Question 01)
            /*
                Question 01:
                    Define an interface named IShape with a property Area and a method
                    DisplayShapeInfo. Create two interfaces, ICircle and IRectangle, that inherit from
                    IShape. Implement these interfaces in classes Circle and Rectangle. Test your
                    implementation by creating instances of both classes and displaying their shape
                    information.
            */

            //Circle circle = new Circle() { Radius = 5 };
            //circle.SetShapeArea();
            //circle.DisplayShapeInfo();


            //Rectangle rectangle = new Rectangle() { Width = 5, Height = 5 };
            //rectangle.SetShapeArea();
            //rectangle.DisplayShapeInfo();


            #endregion

            #region part02 - Question 02)
            /*
                Question 02:
                    In this example, we start by defining the IAuthenticationService interface with two
                    methods: AuthenticateUser and AuthorizeUser. The BasicAuthenticationService
                    class implements this interface and provides the specific implementation for these
                    methods.

                    In the BasicAuthenticationService class, the AuthenticateUser method compares
                    the provided username and password with the stored credentials. It returns true if
                    the user is authenticated and false otherwise. The AuthorizeUser method checks if
                    the user with the given username has the specified role. It returns true if the user
                    is authorized and false otherwise.

                    In the Main method, we create an instance of the BasicAuthenticationService class
                    and assign it to the authService variable of type IAuthenticationService. We then
                    call the AuthenticateUser and AuthorizeUser methods using this interface
                    reference..

                    This implementation allows you to switch the authentication service
                    implementation easily by creating a new class that implements the
                    IAuthenticationService interface and providing the desired logic for authentication
                    and authorization.
            */

            //string username, password, role;

            //Console.WriteLine($"Enter Your username for registration: ");
            //username = Console.ReadLine();

            //Console.WriteLine($"Enter Your password for registration: ");
            //password = Console.ReadLine();

            //Console.WriteLine($"Enter Your role for registration: ");
            //role = Console.ReadLine();

            //IAuthenticationService authService = new BasicAuthenticationService() { Username = username, Password = password, Role = role };

            //Console.WriteLine("You've registered with no problems.");

            //Console.WriteLine($"Enter Your username for login: ");
            //username = Console.ReadLine();

            //Console.WriteLine($"Enter Your password for login: ");
            //password = Console.ReadLine();

            //Console.WriteLine($"is this user username: {username}, role: {role} Authenticated: {authService.AuthenticateUser(username, password)}");

            //Console.WriteLine($"Enter Your role for check Authoriztion: ");
            //role = Console.ReadLine();

            //Console.WriteLine($"is this user username: {username}, role: {role} Authorized: {authService.AuthorizeUser(username, role)}");



            #endregion

            #region part02 - Question 03)
            /*
                Question 03:
                    We define the INotificationService interface with a method SendNotification that
                    takes a recipient and a message as parameters.

                    We then create three classes: EmailNotificationService, SmsNotificationService,
                    and PushNotificationService, which implement the INotificationService interface.

                    In each implementation, we provide the logic to send notifications through the
                    respective communication channel:

                    The EmailNotificationService class simulates sending an email by outputting a
                    message to the console.

                    The SmsNotificationService class simulates sending an SMS by outputting a
                    message to the console.

                    The PushNotificationService class simulates sending a push notification by
                    outputting a message to the console.

                    In the Main method, we create instances of each notification service class and call
                    the SendNotification method with sample recipient and message values.

                    This implementation allows you to easily switch between different notification
                    channels by creating new classes that implement the INotificationService interface
                    and provide the specific logic for each channel.
            */

            //PushNotificationService pushNotificationService = new PushNotificationService();
            //pushNotificationService.SendNotification("Ahmed Sanad", "Hello, How are you doing ?");
            //Console.WriteLine();

            //EmailNotificationService emailNotificationService = new EmailNotificationService();
            //emailNotificationService.SendNotification("Mohamed Mohsen", "Hello, How are you doing ?");
            //Console.WriteLine();


            //SmsNotificationService smsNotificationService = new SmsNotificationService();
            //smsNotificationService.SendNotification("Osama Ahmed", "Hello, How are you doing ?");
            //Console.WriteLine();



            #endregion

            #endregion
        }
    }
}
