
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

namespace Everyday
{
    internal class Program
    {
        static void Main()
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            do
            {

                DateTime data = DateTime.Now;



                ConsoleKeyInfo key;

                int pos = 2;

                do
                {

                    if (data.Date == new DateTime(2023, 10, 17))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                        Console.WriteLine("Планы на день:");
                        Console.WriteLine("  Потрапезнечеть");
                        Console.WriteLine("  Попить пиво");
                        Console.WriteLine("  Colledge");
                        Console.WriteLine("  Ужин");
                        
                    }
                    else if (data.Date == new DateTime(2023, 10, 19))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                        Console.WriteLine("Планы на день:");
                        Console.WriteLine("  Обнять Петра");
                        Console.WriteLine("  Попить пиво с Петром");
                        Console.WriteLine("  Покушать");
                        Console.WriteLine("  Помыться в ванне теплой");
                    }
                    else if (data.Date != new DateTime(2023, 10, 19))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                    }
                    else if (data.Date != new DateTime(2023, 10, 17))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                    }

                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("  ");
                    if (key.Key == ConsoleKey.DownArrow && pos != 5)
                    {
                        pos++;
                    }
                    else if (key.Key == ConsoleKey.UpArrow && pos != 2)
                    {
                        pos--;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        data = data.AddDays(1);

                        Console.SetCursorPosition(0, 0);

                        Console.WriteLine(data);
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        data = data.AddDays(-1);

                        Console.SetCursorPosition(0, 0);

                        Console.WriteLine(data);
                    }











                } while (key.Key != ConsoleKey.Enter);



                if (pos == 2 && data.Date == new DateTime(2023, 10, 17))
                {

                    Console.Clear();
                    Dan day = new Dan();
                    day.name = ("Потрапезничить");
                    day.opisanie = ("Покушать пельмени");
                    day.data = DateTime.Now;
                    Console.WriteLine(day.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Описание:" + day.opisanie);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine(data);

                    
}
                else if (pos == 2 && data.Date == new DateTime(2023, 10, 19))
                {
                    Console.Clear();
                    Dan day2 = new Dan();
                    day2.name = ("Обнять Петра");
                    day2.data = DateTime.Now;
                    day2.opisanie = ("Обнять Петра и сказать ему большое спасибо");
                    Console.WriteLine(day2.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.opisanie);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine(data);


                }


                else if (pos == 3 && data.Date == new DateTime(2023, 10, 17))
                {

                    Console.Clear();
                    Dan day2 = new Dan();
                    day2.name = ("Попить пиво");
                    day2.opisanie = ("Попить безалкогольное балтику с грейфрутом");
                    day2.data = DateTime.Now;
                    Console.WriteLine(day2.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.opisanie);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine(data);


                }
                else if (pos == 3 && data.Date == new DateTime(2023, 10, 19))
                {
                    Console.Clear();
                    Dan day2 = new Dan();
                    day2.name = ("Попить пиво с Петром");
                    day2.opisanie = ("Попить охоту с Петром");
                    day2.data = DateTime.Now;
                    Console.WriteLine(day2.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.opisanie);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine(data);
                }
                else if (pos == 4 && data.Date == new DateTime(2023, 10, 17))
                {

                    Console.Clear();
                    Dan day2 = new Dan();
                    day2.name = ("College");
                    day2.opisanie = ("Пойти в колледж");
                    day2.data = DateTime.Now;
                    Console.WriteLine(day2.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.opisanie);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine(data);


                }
                else if (pos == 4 && data.Date == new DateTime(2023, 10, 17))
                {
                    Console.Clear();
                    Dan day2 = new Dan();
                    day2.name = ("Покушать");
                    day2.opisanie = ("Покушать вкусно");
                    day2.data = DateTime.Now;
                    Console.WriteLine(day2.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.opisanie);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine(data);
                }
                else if (pos == 5 && data.Date == new DateTime(2023, 10, 17))
                {

                    Console.Clear();
                    Dan day2 = new Dan();
                    day2.name = ("Ужин");
                    day2.opisanie = ("Покушать еду");
                    day2.data = DateTime.Now;
                    Console.WriteLine(day2.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.opisanie);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine(data);


                }
                else if (pos == 5 && data.Date == new DateTime(2023, 10, 19))
                {
                    Console.Clear();
                    Dan day2 = new Dan();
                    day2.name = ("Помыться");
                    day2.opisanie = ("Помыться в ванне теплой");
                    day2.data = DateTime.Now;
                    Console.WriteLine(day2.name);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Описание:" + day2.opisanie);
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine(data);
                }

                key = Console.ReadKey();

                Console.Clear();
         

            } while (true);




        }



    }
}