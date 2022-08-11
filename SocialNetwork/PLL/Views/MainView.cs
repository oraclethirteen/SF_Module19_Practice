using System;
using System.Text;
using System.Collections.Generic;
using SocialNetwork.BLL.Models;

namespace SocialNetwork.PLL.Views
{
    public class MainView
    {
        public void Show()
        {
            Console.WriteLine("\t*** СОЦИАЛЬНАЯ СЕТЬ ***");
            Console.WriteLine("\nДобро пожаловать!");
            Console.WriteLine("\nВойти в профиль (нажмите 1)");
            Console.WriteLine("Регистрация (нажмите 2)\n");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Program.authenticationView.Show();
                        break;
                    }

                case "2":
                    {
                        Program.registrationView.Show();
                        break;
                    }
            }
        }
    }
}
