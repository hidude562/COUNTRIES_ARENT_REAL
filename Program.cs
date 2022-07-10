﻿using System;

namespace Brazil
{
    class Program
    {
        static void Main(string[] args)
        {
            //set loop stuff
            int _fake, _real;
            _fake = 1;
            _real = 0;

            Console.Title = "BRAZIL ISNT REAL";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;

            //ask for easy or hard mode
            Console.WriteLine("Welcome to 'BRAZIL ISNT REAL: The Game.' Would you like to play easy mode (RNG up to 100) or hard mode (RNG up to 1000)? Press 1 and hit enter for easy, press 2 and enter for hard. ");
            string mode = Console.ReadLine();
            
            // set easy mode
            if (mode == "1")
            {
                while (_fake != _real)
                {
                    //welcome to easy mode
                    Console.WriteLine("Welcome to easy mode. ");
                    
                    //classes
                    int fake, real, attempts;
                    fake = 1;
                    real = 0;
                    attempts = 0;

                    //classes for making real brazil rng
                    Random realRd = new Random();
                    int correctReal = realRd.Next(1, 100);

                    //classes for making real brazil rng 2
                    Random realRd1 = new Random();
                    int correctReal1 = realRd1.Next(1, 100);

                    while (fake != real)
                    {
                        //classes for rng on Y
                        Random rd = new Random();
                        int randomGuess = rd.Next(1, 100);

                        //classes for rng on X
                        Random rd1 = new Random();
                        int randomGuess1 = rd1.Next(1, 100);

                        //set build stuff (name, color)
                        Console.Title = "BRAZIL ISNT REAL";
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.CursorVisible = false;

                        //set int attempts to operable int
                        int _attempts = attempts + 1;
                        attempts = _attempts;

                        //number to get brazil real
                        if (randomGuess == correctReal)
                        {
                            if (randomGuess1 == correctReal1)
                            {
                                // tell is winner
                                Console.WriteLine("YOU WIN: BRAZIL IS REAL. ATTEMPTS: " + _attempts + " YOUR NUMBERS WERE: " + randomGuess + " and " + randomGuess1 + " PRESS ENTER TWICE TO START AGAIN.");
                                Console.ReadLine();
                                Console.ReadLine();
                                real = fake;
                                attempts = 0;
                            }
                        }
                        else
                        {
                            //write brazil ain't real and attempts
                            Console.WriteLine("ATTEMPTS: " + _attempts + " RESULT: BRAZIL IS NOT REAL! YOUR NUMBERS WERE: " + randomGuess + " and " + randomGuess1);
                        }

                    }
                }
            }

            //set hard mode
            if (mode == "2")
            {
                    while (_fake != _real)
                    {
                        //welcome to hard mode
                        Console.WriteLine("Welcome to hard mode. ");

                        //classes
                        int fake, real, attempts;
                        fake = 1;
                        real = 0;
                        attempts = 0;

                        //classes for making real brazil rng
                        Random realRd = new Random();
                        int correctReal = realRd.Next(1, 1000);

                        //classes for making real brazil rng 2
                        Random realRd1 = new Random();
                        int correctReal1 = realRd1.Next(1, 1000);

                        while (fake != real)
                        {
                            //classes for rng on Y
                            Random rd = new Random();
                            int randomGuess = rd.Next(1, 1000);

                            //classes for rng on X
                            Random rd1 = new Random();
                            int randomGuess1 = rd1.Next(1, 1000);

                            //set build stuff (name, color)
                            Console.Title = "BRAZIL ISNT REAL";
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorVisible = false;

                            //set int attempts to operable int
                            int _attempts = attempts + 1;
                            attempts = _attempts;

                            //number to get brazil real
                            if (randomGuess == correctReal)
                            {
                                if (randomGuess1 == correctReal1)
                                {
                                    // tell is winner
                                    Console.WriteLine("YOU WIN: BRAZIL IS REAL. ATTEMPTS: " + _attempts + " YOUR NUMBERS WERE: " + randomGuess + " and " + randomGuess1 + " PRESS ENTER TWICE TO START AGAIN.");
                                    Console.ReadLine();
                                    Console.ReadLine();
                                    real = fake;
                                    attempts = 0;
                                }
                            }
                            else
                            {
                                //write brazil ain't real and attempts
                                Console.WriteLine("ATTEMPTS: " + _attempts + " RESULT: BRAZIL IS NOT REAL! YOUR NUMBERS WERE: " + randomGuess + " and " + randomGuess1);
                            }

                        }
                    }
            }
        }
     }
}
