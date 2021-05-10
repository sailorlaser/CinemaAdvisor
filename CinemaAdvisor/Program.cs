using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAdvisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа поможет Вам подобрать фильм на вечер!");
            Console.WriteLine("Как Вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);

            Console.WriteLine("Фильм какого жанра Вы предпочитаете: комедия, триллер, драма или фантастика?");
            String genre = Console.ReadLine();
            if (genre == "комедия")
            {
                Console.WriteLine("Вы хотите посмотреть отечественный или зарубежный фильм?");
                String country = Console.ReadLine();
                if (country == "отечественный")
                {
                    Console.WriteLine("В таком случае, рекомендуем Вам посмотреть следующие фильмы:");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Операция Ы");
                    Console.WriteLine("Десантник Стёпочкин");
                    Console.WriteLine("Иван Васильевич меняет профессию");
                }
                else
                    {
                    Console.WriteLine("В таком случае, рекомендуем Вам посмотреть следующие фильмы:");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Шутник Эндрю");
                    Console.WriteLine("Эйс Вентура");
                    Console.WriteLine("Маска");
                    }
            }
            else if (genre == "фантастика")
            {
                Console.WriteLine("В таком случае, рекомендуем Вам посмотреть следующие фильмы:");
                Console.WriteLine("Звёздные войны");
                Console.WriteLine("Гарри Поттер");
                Console.WriteLine("Властелин колец");
            }
            else if (genre == "триллер")
            {
                Console.WriteLine("В таком случае, рекомендуем Вам посмотреть следующие фильмы:");
                Console.WriteLine("Супер воин");
                Console.WriteLine("Красный убийца");
                Console.WriteLine("Ветхая крепость");
            }
            else
            {
                Console.WriteLine("В таком случае, рекомендуем Вам посмотреть следующие фильмы:");
                Console.WriteLine("Зелёная миля");
                Console.WriteLine("Побег из Шоушенка");
                Console.WriteLine("Великий");
            }

            Console.ReadLine();
        }
    }
}
