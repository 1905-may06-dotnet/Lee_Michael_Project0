using System;
using Project00Data;
using Project00Data.Data;
using Project00.Domain;
using System.Collections.Generic;

namespace Project00.Client
{
    class Program
    {
        static Crud c;
       


        static void Main(string[] args)
        {
            c = new Crud();
            MainMenu();

        }

        static Customer CustomerOnline;
        static Orders CurrentOrder;
        static void MainMenu()
        {
            Console.WriteLine("Welcome to the PizzaApp.");
            Console.WriteLine("Select: " +
                "1) Creating an account" +
                "2) Logging into an exsisting account" +
                "3) Creating/Buying a Pizza" +
                "4) Exit/Log Out" +
                "");

           int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1) 
            {
                Console.WriteLine("Redirecting to sign up.");
                SignUp();         
            }
            else if (choice == 2)
            {
                Console.WriteLine("Redirecting to log in.");
                LogIn();
            }
            else if(choice == 3)
            {
                Console.WriteLine("Redirecting to Ordering Pizza.");
                PizzaOrder();
            }
            else if(choice == 4)
            {
                Console.WriteLine("Redirecting to log out.");
                LogOut();
            }
            else
            {
                Console.WriteLine("Exiting.");
                Exit();
            }

            static void SignUp()
            {
                bool UserSigningUp = true;
                if(CustomerOnline == null)
                {
                    while(UserSigningUp == true)
                    {
                        Console.WriteLine("Let's get you an account. Please type out a unique username.");
                        string Username = Console.ReadLine();
                        if (c.UniqueUsername(Username))
                        {
                            Console.WriteLine("Sorry this username is taken, please try a different name.");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Please type out a password for your username.");
                            string Password = Console.ReadLine();
                            UserSigningUp = false;
                            return;
                        }
                    }
                    
                }

            }
            static void LogIn()
            {

            }
            static void PizzaOrder()
            {
                Console.WriteLine("Let's create a pizza.");

               


            }
            static void LogOut()
            {

            }
            static void Exit()
            {

            }


        }
    }
}
