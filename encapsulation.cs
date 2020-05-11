using System;

namespace Encapsulation
{
    class User 
    {
        private string username;
        private string password;
        public string MyUsername {
            get 
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string MyPassword {
            get 
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            User myUser = new User();

            myUser.MyUsername = "jsmith";
            myUser.MyPassword = "password";

            Console.WriteLine("Username: " + myUser.MyUsername);
            Console.WriteLine("Password: " + myUser.MyPassword);
        }
    }
}