using System;
namespace Auth
{
    class IO
    {
        static void Main(string[] args)
        {
            Password password = new Password();
            Console.WriteLine("Welcome back %username%\nPlease, enter the password:");
            password.verifyProcess();
            Console.ReadKey();
        }
    }
    class Password
    {
        public string correctPassword = "HelloWorld";
        public string userPassword;
        protected int failures = 0;

        public void verifyProcess()
        {
            getPassword();
            comparePassword();
        }
        void getPassword()
        {
            userPassword = Console.ReadLine();
        }
        void comparePassword()
        {
            if (correctPassword == userPassword)
            {
                passwordIsCorrect();
            }
            else
            {
                passwordNotCorrect();
            }    
        }
        void passwordIsCorrect()
        {
            Console.WriteLine("Password is correct. The Vault code is 0451. Have a good day, goodbye");
        }
        void passwordNotCorrect()
        {
            failures++;
            if (failures == 3)
            {
                Console.WriteLine("The password was entered 3 times incorrectly. Starting the self-destruction process");
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
                verifyProcess();
            }    
        }
    }
}