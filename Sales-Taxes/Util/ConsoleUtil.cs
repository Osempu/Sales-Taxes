using Sales_Taxes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    public static class ConsoleUtil
    {
        public static void ClearConsole()
        {
            Console.Clear();
        }

        /// <summary>
        /// This function accepts a message param to display and an alert enum to print the alert
        /// in the specified format(info, warning, notification).
        /// </summary>
        /// <param name="message"></param>
        /// <param name="alertEnum"></param>
        public static void PrintAlert(string message, AlertEnum alertEnum)
        {
            switch (alertEnum)
            {
                case AlertEnum.Info:
                    PrintColoredMessge(message, ConsoleColor.Green);
                    break;
                case AlertEnum.Warning:
                    PrintColoredMessge(message, ConsoleColor.Red);
                    break;
                case AlertEnum.Notification:
                    PrintColoredMessge(message, ConsoleColor.Cyan);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Prints a message with a color defined by the console color in param.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        private static void PrintColoredMessge(string message,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
