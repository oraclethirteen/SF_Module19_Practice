using System;
using System.Text;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class RegistrationView
    {
        UserService userService;
        public RegistrationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var userRegistrationData = new UserRegistrationData();

            Console.Write("\nДля создания нового профиля введите ваше имя: ");
            userRegistrationData.FirstName = Console.ReadLine();

            Console.Write("Ваша фамилия: ");
            userRegistrationData.LastName = Console.ReadLine();

            Console.Write("Пароль: ");
            userRegistrationData.Password = Console.ReadLine();

            Console.Write("Почтовый адрес: ");
            userRegistrationData.Email = Console.ReadLine();

            try
            {
                this.userService.Register(userRegistrationData);

                SuccessMessage.Show("\nВаш профиль успешно создан. Теперь Вы можете войти в систему под своими учетными данными.\n");
            }
            catch (ArgumentNullException)
            {
                AlertMessage.Show("\nВведите корректное значение.");
            }
            catch (Exception)
            {
                AlertMessage.Show("\nПроизошла ошибка при регистрации.");
            }
        }
    }
}
