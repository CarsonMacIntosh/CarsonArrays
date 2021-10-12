using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsonArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shooting Range");
            Console.WriteLine("");
            Console.WriteLine("by Carson MacIntosh");
            Console.WriteLine("");
            Console.WriteLine("Press Backspace for Shotgun");
            Console.WriteLine("Press Space to fire current weapon");
            Console.WriteLine("");

            int weapon = 0;

            int[] ammo;
            ammo = new int[3];
            ammo[0] = 6;
            ammo[1] = 2;

            string[] weaponName = new string[3];
            weaponName[0] = "Pistol";
            weaponName[1] = "Shotgun";

            Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                if (weapon == 0)
                {
                    ammo[0] = ammo[0] - 1;
                }
                Console.Clear();
                Console.WriteLine("Shooting Range");
                Console.WriteLine("");
                Console.WriteLine("by Carson MacIntosh");
                Console.WriteLine("");
                Console.WriteLine("Press Space to fire current weapon");
                Console.WriteLine("");

                Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    if (weapon == 0)
                    {
                        ammo[0] = ammo[0] - 1;
                    }
                    Console.Clear();
                    Console.WriteLine("Shooting Range");
                    Console.WriteLine("");
                    Console.WriteLine("by Carson MacIntosh");
                    Console.WriteLine("");
                    Console.WriteLine("Press Space to fire current weapon");
                    Console.WriteLine("");

                    Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        if (weapon == 0)
                        {
                            ammo[0] = ammo[0] - 1;
                        }
                        Console.Clear();
                        Console.WriteLine("Shooting Range");
                        Console.WriteLine("");
                        Console.WriteLine("by Carson MacIntosh");
                        Console.WriteLine("");
                        Console.WriteLine("Press Space to fire current weapon");
                        Console.WriteLine("");

                        Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                        if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                        {
                            if (weapon == 0)
                            {
                                ammo[0] = ammo[0] - 1;
                            }
                            Console.Clear();
                            Console.WriteLine("Shooting Range");
                            Console.WriteLine("");
                            Console.WriteLine("by Carson MacIntosh");
                            Console.WriteLine("");
                            Console.WriteLine("Press Space to fire current weapon");
                            Console.WriteLine("");

                            Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                            {
                                if (weapon == 0)
                                {
                                    ammo[0] = ammo[0] - 1;
                                }
                                Console.Clear();
                                Console.WriteLine("Shooting Range");
                                Console.WriteLine("");
                                Console.WriteLine("by Carson MacIntosh");
                                Console.WriteLine("");
                                Console.WriteLine("Press Space to fire current weapon");
                                Console.WriteLine("");

                                Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                                {
                                    if (weapon == 0)
                                    {
                                        ammo[0] = ammo[0] - 1;
                                    }
                                    Console.Clear();
                                    Console.WriteLine("Shooting Range");
                                    Console.WriteLine("");
                                    Console.WriteLine("by Carson MacIntosh");
                                    Console.WriteLine("");
                                    Console.WriteLine("Press Space to fire current weapon");
                                    Console.WriteLine("");

                                    Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                                    {
                                        if (weapon == 0)
                                        {
                                            ammo[0] = 0;
                                        }
                                        Console.Clear();
                                        Console.WriteLine("Shooting Range");
                                        Console.WriteLine("");
                                        Console.WriteLine("by Carson MacIntosh");
                                        Console.WriteLine("");
                                        Console.WriteLine("Press Space to fire current weapon");
                                        Console.WriteLine("");

                                        Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                                        Console.WriteLine("");
                                        Console.WriteLine("Outta Ammo");
                                        Console.WriteLine("Thanks for playing!");

                                        Console.ReadKey(true);
                                        Environment.Exit(0);

                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (Console.ReadKey(true).Key == ConsoleKey.Backspace);

            weapon = 1;

            Console.Clear();
            Console.WriteLine("Shooting Range");
            Console.WriteLine("");
            Console.WriteLine("by Carson MacIntosh");
            Console.WriteLine("");
            Console.WriteLine("You've equipped the shotgun!");
            Console.WriteLine("Press Space to fire current weapon");
            Console.WriteLine("");

            Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar);
            {
                ammo[1] = ammo[1] - 1;

                Console.Clear();
                Console.WriteLine("Shooting Range");
                Console.WriteLine("");
                Console.WriteLine("by Carson MacIntosh");
                Console.WriteLine("");
                Console.WriteLine("Press Space to fire current weapon");
                Console.WriteLine("");

                Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                Console.ReadKey(true);
            }

            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar);
            {
                ammo[1] = ammo[1] - 1;

                Console.Clear();
                Console.WriteLine("Shooting Range");
                Console.WriteLine("");
                Console.WriteLine("by Carson MacIntosh");
                Console.WriteLine("");
                Console.WriteLine("Press Space to fire current weapon");
                Console.WriteLine("");

                Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[weapon]);

                Console.WriteLine("Outta Ammo");
                Console.WriteLine("Thanks for playing!");

                Console.ReadKey(true);
                Environment.Exit(0);
            }
        }
    }
}
