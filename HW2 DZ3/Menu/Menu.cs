using HW2_DZ3.Creatures;
using HW2_DZ3.Facrories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW2_DZ3.Menu
{
    public static class Menu
    {
        public static void MenuStart()
        {
            Console.WriteLine("Started console App for HW2 DZ3");


            string[] menuItems = { 
                "\n\n1. Создать нового юзера", 
                "\n\n2. Создать новое домашнее животное",
                "\n\n3. Показать всех существ",
                "\n\n4. Завершить работу программы (ВЫХОД)"};

            int selectedIndex = 0;

            List<Creature> listOfCreatures = new List<Creature>();


            while (true)
            {
                Console.Clear();

                //вывод в консоль всех строк меню записанных в string[] menuItems с подсветкой selectedIndex
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine(menuItems[i]);
                }
                Console.ResetColor();

                //управление курсором
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    //используем МАХ чтобы не дать выйте selectedIndex за границы массива menuItems, т.е. не меньше 0
                    selectedIndex = Math.Max(0, selectedIndex - 1);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    //используем МИН чтобы не дать выйте selectedIndex за границы массива menuItems, т.е. не больше 3
                    selectedIndex = Math.Min(menuItems.Length - 1, selectedIndex + 1);
                }
                
                if (keyInfo.Key == ConsoleKey.Enter)
                {

                    switch (selectedIndex)
                        {
                            case 0:
                                listOfCreatures.Add(new UserFactory().createCreature());
                                continue;

                            case 1:
                                listOfCreatures.Add(new PetFactory().createCreature());
                                continue;

                            case 2:
                                Creature.PrintAllCreatures();
                                Console.WriteLine("Для возврата в меню нажмите ENTER");
                                Console.ReadLine(); 
                                continue;

                            case 3:
                            Console.WriteLine("Выход из программы.");
                            Environment.Exit(0);
                            break;
                        }    
                    
                }
            }
        }
    }

    
}
