﻿using System;
using System.Threading;


namespace RandomNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hello Player");
            Console.WriteLine("-------------------------------");

            Thread.Sleep(1000);
            while(true)
            {
            Console.Clear();
        
            Console.Write("BR or ENGLISH? ");

            string Response = Console.ReadLine()?.ToUpper() ?? "";

            if(Response == "BR" || Response == "Portugues")
            {
                Game.GameRandomPortuguese();
                break;
            }
            else if (Response == "EN" || Response == "English" || Response == "ingles")
            {
                Game.GameRandomEnglish();
                break;
            }

            
                else
                {
                    Console.WriteLine("Enter BR / Portuguese or EN / English ");
                    Console.ReadKey();
                }
                
                
            
            }
            
        }
        
    }

    public class Game
    {
        public static void GameRandomPortuguese()
        {
            Random random = new Random();
            int response,number,chances;
            number = 0;

             while (true) // Loop externo para continuar até que o usuário insira um número válido
            {
             chances = random.Next(3,10);

           


             Thread.Sleep(250);
                try
                {
                    number = random.Next(1, 31); // Gera o número aleatório
                    do
                    {
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Chances Restantes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}",chances);
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Adivinhe um número de 1 a 30: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        response = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (response < number)
                        {
                           Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Sua resposta está ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("abaixo ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("do numero Desejado");
                            Console.WriteLine("");
                            chances--;
                            
                        }
                        else if (response > number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Sua resposta está ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("acima ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("do numero Desejado");
                            Console.WriteLine("");
                            chances--;
                        }
                        else
                        {
                             Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("PARABENS");
                            Console.WriteLine("O número foi {0} ", number);
                            Thread.Sleep(2000);
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            Thread.Sleep(250);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (response != number && chances != 0); // Fim do loop Interno

                    
                    Console.Clear();
                    Console.Write("Tentar Denovo? ");

                    string resposta = Console.ReadLine()  ?? "";

                    if(resposta == "nao" || resposta.ToUpper() == "nao" || resposta == "sair")
                    {
                        Thread.Sleep(200);
                        break; // Sai do loop externo quando o usuário inserir um número válido
                    }

                    

                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Apenas números válidos são permitidos. Tente novamente.");
                    Thread.Sleep(250);
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }





            /*------------------------------------------------------------------------*/







         public static void GameRandomEnglish()
         {

            Random random = new Random();
            int response,number,chances;
            number = 0;

             while (true) // External loop to continue until user enters a valid number
            {
             chances = random.Next(1,10);

           
             Thread.Sleep(250);
                try
                {
                    number = random.Next(1, 31); // Generates the random number
                    do
                    {
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Chances Remaining: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}",chances);
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Guess a number from 1 to 30: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        response = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (response < number)
                        {
                           Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Your answer is ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("down ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("of the Desired number");
                            Console.WriteLine("");
                            chances--;
                            
                        }
                        else if (response > number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Your answer is ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("above ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("the Desired number");
                            Console.WriteLine("");
                            chances--;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Congratulations");
                            Console.WriteLine("The number was {0} ", number);
                            Thread.Sleep(2000);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            Thread.Sleep(250);
                             Console.ForegroundColor = ConsoleColor.White;
                        }
                    } while (response != number && chances != 0); // End of the Internal loop

                    Console.Clear();
                    Console.Write("Try Again? ");

                    string Response = Console.ReadLine()  ?? "";

                    if(Response == "not" || Response.ToUpper() == "NO" || Response == "exit" || Response == "leave")
                    {
                        Thread.Sleep(200);
                        break; // Exits the outer loop when the user enters a valid number
                    }

                    

                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Only valid numbers are allowed. Please try again.");
                    Thread.Sleep(250);
                    Console.WriteLine("");
                    Console.ReadKey();
                    Console.Clear();
                    
                }
            }

         }
    }
}