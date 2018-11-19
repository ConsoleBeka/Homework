using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker firstWorker = new Worker("Courtney", "Lee"); 
            Worker secondWorker = new Worker("He", "She"); 
            Worker thirdWorker = new Worker("Petya", "Kolya"); 
            Worker fourthWorker = new Worker("Oleg", "Oleg"); 
            Worker fifthWorker = new Worker("Peter", "Paul");

            List<Worker> workers = new List<Worker>(){ firstWorker, secondWorker, thirdWorker, fourthWorker, fifthWorker }; 
            Team team = new Team(workers);
            House house = new House();

            
            
             
            List<Wall> walls = new List<Wall>();
            List<Window> windows = new List<Window>();
            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1 Build a house ");
                Console.WriteLine("2 View ");
                Console.WriteLine("3 Exit ");

                string chooseMenu = Console.ReadLine();
                if (int.Parse(chooseMenu) == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Built: ");

                    Console.WriteLine(house.Walls.Count + " walls");
                    Console.WriteLine(house.Windows.Count + " windows");
                    Console.WriteLine(Roof.count + " roofs");
                    Console.WriteLine(Basement.count + " basements");
                    Console.WriteLine(Door.count + " doors");


                    Console.WriteLine("Choose: ");
                    Console.WriteLine(1 + " wall ");
                    Console.WriteLine(2 + " window ");
                    Console.WriteLine(3 + " roof ");
                    Console.WriteLine(4 + " basement ");
                    Console.WriteLine(5 + " door");

                    string chooseMenuBuild = Console.ReadLine();

                    if (int.Parse(chooseMenuBuild) == 1 )
                    {
                        Wall wall = new Wall("Material", 100, 100, 25000);
                        house.AddWall(wall);
                        Console.WriteLine("Done!");
                    }
                    else if (int.Parse(chooseMenuBuild) == 2)
                    {
                        Window window = new Window("Material", 100, 100, 25000);
                        house.AddWindow(window);
                        Console.WriteLine("Done!");
                    }
                    else if (int.Parse(chooseMenuBuild) == 3)
                    {
                        Roof roof = new Roof("Material", 100, 100, 50000);
                        house.Roof = roof;
                        Console.WriteLine("Done!");
                    }
                    else if (int.Parse(chooseMenuBuild) == 4)
                    {
                        Basement basement = new Basement("Material", 100, 100, 50000);
                        house.Basement = basement;
                        Console.WriteLine("Done!");
                    }
                    else if (int.Parse(chooseMenuBuild) == 5)
                    {

                        Door door = new Door("Material", 100, 100, 50000);
                        house.Door = door;
                        Console.WriteLine("Done!");
                    }
                    else {
                        Console.WriteLine("Coose from 1 to 5");
                    }

                    Console.ReadLine();
                }

                else if (int.Parse(chooseMenu) == 2)
                {
                    if (house.Walls.Count >= 4 && house.Windows.Count >= 4 && Roof.count >= 1 && Basement.count >= 1 && Door.count >= 1)
                    {
                        string domik = @"
                   -----
                  -------
                 ---------
                 |  | |  |
                 |  ---  |
                 ---------
                   ";

                        Console.WriteLine(domik);
                    }
                    else
                    {
                        Console.WriteLine("Not enough materials! ");

                    }
                    Console.ReadLine();
                }
                else if (int.Parse(chooseMenu) == 3)
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Choose 1-3! ");
                    Console.ReadLine();
                }
                Console.Clear();

             


            }
        }
    }
}
