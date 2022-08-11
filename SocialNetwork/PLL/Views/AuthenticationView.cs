using System;
using System.Text;
using System.Collections.Generic;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.PLL.Helpers;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.PLL.Views
{
    public class AuthenticationView
    {
        UserService userService;
        public AuthenticationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.Write("\nВведите почтовый адрес: ");
            authenticationData.Email = Console.ReadLine();

            Console.Write("\nВведите пароль: ");
            authenticationData.Password = Console.ReadLine();

            try
            {
                var user = this.userService.Authenticate(authenticationData);

                SuccessMessage.Show("\nВы успешно вошли в социальную сеть!");
                SuccessMessage.Show("\nДобро пожаловать " + user.FirstName + "\n");

                Program.userMenuView.Show(user);
            }
            catch (WrongPasswordException)
            {
                AlertMessage.Show("\nНекорректный пароль!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("\nПользователь не найден!");
            }
        }
    } 
}
