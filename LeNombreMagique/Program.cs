using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN = 0;
            const int MAX = 10;
            Random random = new Random();
            int x = random.Next(MIN, MAX);
            
            
            int life = 0;
            for (life = 5; life > 0; life--)
            {
                Console.Write($"Deviner un nombre entre {MIN} et {MAX} (vous avex {life} chance ) >_ ");
                String nb_user = Console.ReadLine();
                

                int nb_choice = 0;
                if (int.TryParse(nb_user, out nb_choice))
                {
                    if ((nb_choice > MAX) || (nb_choice < MIN))
                    {
                        Console.WriteLine($"me un truc entre {MIN} et {MAX} bro!!!!");
                        life += 1;
                    }
                    else
                    {
                        if (nb_choice > x)
                        {
                            Console.WriteLine("Le nombre maque est plus petit que ca mec !");
                        } else if (nb_choice < x)
                        {
                            Console.WriteLine("Le nombre magique est plus grans que cela");
                        }
                        else
                        {
                            Console.WriteLine("Bien jouer ! petit con ");
                            break;
                      
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Attention! man tu doit metre un nombre!");
                    life += 1;
                }
                
                Console.WriteLine("");
                
            }
            // sortie de la boucle
            if (life == 0)
            {
                Console.WriteLine($"Oups! Game over big man! Fallait dire plutot {x}");
            }

        }
    }
}