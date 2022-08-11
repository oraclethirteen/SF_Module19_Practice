using System;
using System.Text;
using System.Collections.Generic;

namespace SocialNetwork.PLL.Helpers
{
    public class AlertMessage
    {
        public static void Show(string message)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
        }
    }
}
