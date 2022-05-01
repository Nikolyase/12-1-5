using System;
using System.Collections.Generic;
using System.Threading;


namespace M12_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> user = new List<User>(5){
            new User() { Login = "1", Name = "Годрик", IsPremium = true},
            new User() { Login = "2", Name = "Годвин", IsPremium = false},
            new User() { Login = "3", Name = "Микелла", IsPremium = true},
            new User() { Login = "4", Name = "Маргрит", IsPremium = true},
            new User() { Login = "5", Name = "Миления", IsPremium = false}
            };

            foreach (User polz in user)
            {
                Console.WriteLine("Здравствуйте {0}! ", polz.Name);
                if (!polz.IsPremium)
                {
                    ShowAds();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Все пользователи поприветствованы!");

            Console.ReadKey();
        }
        /// <summary>
        /// Реклама
        /// </summary>
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с по игре Elden Ring");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите нашу бесполезную подписку!");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Купите нашу подписку +, чтобы мы не надоедали вам с всплывающими окнами!");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

    }
}
