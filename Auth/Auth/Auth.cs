using System;
namespace Auth
{
    class Auth
    {
        static void Main(string[] args)
        {
            // Создание объекта
            Password password = new Password();
            Console.WriteLine("Welcome back %username%\nPlease, enter the password:");
            // Запуск объекта
            password.verifyProcess();
            Console.ReadKey();
        }
    }
    class Password
    {
        private string correctPassword = "HelloWorld";
        private string userPassword;
        private int failures = 0;
        // Метод для запуска методов
        public void verifyProcess()
        {
            getPassword();
            comparePassword();
        }
        // Ввод пароля пользователем
        void getPassword()
        {
            userPassword = Console.ReadLine();
        }
        // Сравнение пароля пользователя с паролем в базе
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
        // Результат если пароли совпадают
        void passwordIsCorrect()
        {
            Console.WriteLine("Password is correct. The Vault code is 0451. Have a good day, goodbye");
        }
        // Результат если пароли не совпадают
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