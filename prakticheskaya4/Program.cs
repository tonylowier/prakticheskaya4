using System.ComponentModel.Design;
using System.Text.Json.Serialization.Metadata;

namespace Практическая__4
{
    internal class Program
    {
        static int position = 2;
        static ConsoleKeyInfo key;
        static void Main()
        {
            Console.Clear();
            Menu1();
            while (true)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (position == 1 || position == 4)
                {
                    position = 2;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Main2();
                    break;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Main5();
                    break;
                }


                Console.Clear();
                Menu1();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 2)
                    {
                        menu1opc1();
                    }
                    else if (position == 3)
                    {
                        menu1opc2();
                    }
                }


            }


        }

        static void Main2()
        {
            Console.Clear();
            Menu2();
            while (true)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;


                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (position == 1 || position == 4)
                {
                    position = 2;
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    Main3();
                    break;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Main();
                    break;
                }
                Console.Clear();
                Menu2();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 2)
                    {
                        menu2opc1();
                    }
                    else if (position == 3)
                    {
                        menu2opc2();
                    }
                }
            }



        }
        static void Main3()
        {
            Console.Clear();
            Menu3();
            while (true)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (position == 1 || position == 4)
                {
                    position = 2;
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Main4();
                    break;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Main2();
                    break;
                }


                Console.Clear();
                Menu3();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 2)
                    {
                        menu3opc1();
                    }
                    else if (position == 3)
                    {
                        menu3opc2();
                    }
                }


            }

        }
        static void Main4()
        {
            Console.Clear();
            Menu4();
            while (true)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;


                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                if (position == 1 || position == 4)
                {
                    position = 2;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Main3();
                    break;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Main5();
                    break;
                }
                Console.Clear();
                Menu4();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 2)
                    {
                        menu4opc1();
                    }
                    else if (position == 3)
                    {
                        menu4opc2();
                    }
                }

            }







        }

        static void Main5()
        {
            Console.Clear();
            Menu5();
            while (true)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }


                if (position == 1 || position == 4)
                {
                    position = 2;
                }
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Main4();
                    break;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Main();
                    break;
                }
                Console.Clear();
                Menu5();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (key.Key == ConsoleKey.Enter)
                {
                    if (position == 2)
                    {
                        menu5opc1();
                    }
                    else if (position == 3)
                    {
                        menu5opc2();
                    }
                }









            }




        }







        static void Menu1()
        {
            Console.WriteLine("Выбрана дата 07.10.22");
            Console.WriteLine("_________________________");
            List<string> job = new List<string>() { "  1. Проверить работы", "  2. Сходить в магазин" };
            foreach (string item in job)
            {
                Console.WriteLine(item);
            }


        }
        static void Menu2()
        {
            Console.WriteLine("Выбрана дата 08.10.22");
            Console.WriteLine("_________________________");
            List<string> job = new List<string>() { "  1. Навестить друга", "  2. Заняться спортом" };
            foreach (string item in job)
            {
                Console.WriteLine(item);
            }

        }



        static void Menu3()
        {
            Console.WriteLine("Выбрана дата 09.10.22");
            Console.WriteLine("_________________________");
            List<string> job = new List<string>() { "  1. Проверить работы", "  2. Сходить в магазин" };
            foreach (string item in job)
            {
                Console.WriteLine(item);
            }

        }
        static void Menu4()
        {
            Console.WriteLine("Выбрана дата 10.10.22");
            Console.WriteLine("_________________________");
            List<string> job = new List<string>() { "  1. Погулять с собакой ", "  2. Почитать книгу" };
            foreach (string item in job)
            {
                Console.WriteLine(item);
            }

        }

        static void Menu5()
        {
            Console.WriteLine("Выбрана дата 11.10.22");
            Console.WriteLine("_________________________");
            List<string> job = new List<string>() { "  1. Проверить работы", "  2. Купить тетради" };
            foreach (string item in job)
            {
                Console.WriteLine(item);
            }





        }


        static void menu1opc1()
        {
            Console.Clear();
            Console.WriteLine("  1. Проверить Работы");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Проверить работы по ААС");
            Console.WriteLine("  Дата: 7.10.22 17:20:00");



        }
        static void menu1opc2()
        {

            Console.Clear();
            Console.WriteLine("  2. Сходить в магазин");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Сходить в продуктовый магазин за молоком");
            Console.WriteLine("  Дата: 7.10.22 19:00:00");

        }







        static void menu2opc1()
        {

            Console.Clear();
            Console.WriteLine("  1. Навестить друга");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Навестить друга по соседству");
            Console.WriteLine("  Дата: 8.10.22 14:23:00");


        }
        static void menu2opc2()
        {


            Console.Clear();
            Console.WriteLine("  2. Заняться спортом");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Выйти на улицу и пробежать 1км");
            Console.WriteLine("  Дата: 8.10.22 21:20:00");


        }










        static void menu3opc1()
        {

            Console.Clear();
            Console.WriteLine("  1. Проверить работы");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Проверить работы по компьютерным сетям");
            Console.WriteLine("  Дата: 9.10.22 14:40:00");

        }
        static void menu3opc2()
        {

            Console.Clear();
            Console.WriteLine("  2. Сходить в магазин");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Выйти на улицу и сходить за хлебом");
            Console.WriteLine("  Дата: 9.10.22 18:30:00");

        }





        static void menu4opc1()
        {

            Console.Clear();
            Console.WriteLine("  1. Погулять с собакой");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Выйти на улицу и выгулить собаку");
            Console.WriteLine("  Дата: 10.10.22 22:00:00");

        }
        static void menu4opc2()
        {

            Console.Clear();
            Console.WriteLine("  2. Почитать книгу");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Прочитать первый том \"война и мир\" ");
            Console.WriteLine("  Дата: 10.10.22 15:45:00");

        }








        static void menu5opc1()
        {

            Console.Clear();
            Console.WriteLine("  1. Проверить Работы");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Проверить работы по ОАИП");
            Console.WriteLine("  Дата: 11.10.22 20:20:00");



        }
        static void menu5opc2()
        {

            Console.Clear();
            Console.WriteLine("  1. Купить тетради");
            Console.WriteLine("  ____________________________");
            Console.WriteLine("  Описание: Купить тетради в клетку");
            Console.WriteLine("  Дата: 11.10.22 22:23:00");



        }




    }
}