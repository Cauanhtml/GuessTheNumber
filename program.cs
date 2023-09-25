using System;
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


            
            Thread.Sleep(4000);
            while(true)
            {
            Console.Clear();
        
            Console.Write("BR or ENGLISH? ");

            string Response = Console.ReadLine() ?? "";

            if(Response == "br" || Response == "portugues" || Response == "BR" || Response == "Portugues" || Response == "PORTUGUES" || Response == "Portuguese" || Response == "portuguese")
            {
                Game.GameRandomPortuguese();
                break;
            }
            else if (Response == "en" || Response == "english" || Response == "ingles" || Response == "English" || Response == "ENGLISH")
            {
                Game.GameRandomEnglish();
                break;
            }

            
                else
                {
                    Console.WriteLine("Enter br / portugues / Portuguese // en / english / ingles / English ");
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
                    number = random.Next(10, 30); // Gera o número aleatório
                    do
                    {
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Chances Restantes: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}",chances);
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Adivinhe um número de 10 a 30: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        response = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (response < number)
                        {
                           Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("O Numero Digitado é ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Menor ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("que o numero Correto");

                            if (number % 2 == 0)
                            {
                                Console.Write(" e o número correto é par.");
                            }
                            else
                            {
                                Console.Write(" e o número correto é ímpar.");
                            }


                            Console.WriteLine("");
                            chances--;
                            
                        }
                        else if (response > number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("O Numero digitado é ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("maior ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("que o numero Correto");

                            if (number % 2 == 0)
                            {
                                Console.Write(" e o número correto é par.");
                            }
                            else
                            {
                                Console.Write(" e o número correto é ímpar.");
                            }

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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Apenas números válidos são permitidos. Tente novamente.");
                    Thread.Sleep(250);
                    Console.WriteLine("");
                    Console.ResetColor();
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
                      number = random.Next(10, 30); // Generates the random number
                    do
                    {
                        
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Chances Remaining: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0}",chances);
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Guess a number from 10 to 30: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        response = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (response < number)
                        {
                           Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("The number entered is ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("smaller ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("than the correct number");

                             if (number % 2 == 0)
                            {
                                Console.Write(" and the correct number is even.");
                            }
                            else
                            {
                                Console.Write(" and the correct number is odd.");
                            }


                            Console.WriteLine("");
                            chances--;
                            
                        }
                        else if (response > number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("The number entered is ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("greater ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("than the correct number");

                               if (number % 2 == 0)
                            {
                                Console.Write(" and the correct number is even.");
                            }
                            else
                            {
                                Console.Write(" and the correct number is odd.");
                            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Only valid numbers are allowed. Please try again.");
                    Thread.Sleep(250);
                    Console.WriteLine("");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    
                }
            }

         }
    }
}
