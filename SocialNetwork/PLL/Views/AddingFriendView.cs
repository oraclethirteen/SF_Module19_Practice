using System;
using System.Text;
using System.Collections.Generic;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AddingFriendView
    {
        UserService userService;
        public AddingFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddingFriendData = new UserAddingFriendData();

                Console.Write("\nВведите почтовый адрес пользователя которого хотите добавить в друзья: ");

                userAddingFriendData.FriendEmail = Console.ReadLine();
                userAddingFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddingFriendData);

                SuccessMessage.Show("\nВы успешно добавили пользователя в друзья!\n");
            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("\nПользователя с указанным почтовым адресом не существует!");
            }

            catch (Exception)
            {
                AlertMessage.Show("\nПроизоша ошибка при добавлении пользотваеля в друзья!");
            }
        }
    }
}
