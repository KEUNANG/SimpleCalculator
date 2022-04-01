using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez 1 pour commencer le programme");
            float Start = float.Parse(Console.ReadLine());
           
            do
            {
                Console.WriteLine("Tapez 1 pour commencer ou recommencer le programme ou tapez -1 pour quitter le programme");
                float firstNum;
                float secNum;
                float thirdNum;
                float Discriminant;
                double x1;
                double x2;
                float sum;
                char sign;
                Console.WriteLine("Choix du signe (+,-,*,/) ou tapez S pour la fonction du discrimant");
                sign = char.Parse(Console.ReadLine());
                //Code for a + b
                if (sign == '+')
                {
                    Console.WriteLine("Veuillez le premier nombre");
                    firstNum = float.Parse(Console.ReadLine());
                    Console.WriteLine("Veuillez le deuxieme nombre");
                    secNum = float.Parse(Console.ReadLine());
                    sum = firstNum + secNum;
                    Console.WriteLine("La somme de {0} + {1} = {2}", firstNum, secNum, sum);

                }
                //Code for a - b
                if (sign == '-')
                {
                    Console.WriteLine("Veuillez le premier nombre");
                    firstNum = float.Parse(Console.ReadLine());
                    Console.WriteLine("Veuillez le deuxieme nombre");
                    secNum = float.Parse(Console.ReadLine());
                    sum = firstNum - secNum;
                    Console.WriteLine("La soustration de {0} - {1} = {2}", firstNum, secNum, sum);

                }
                //Code for a * b
                if (sign == '*')
                {
                    Console.WriteLine("Veuillez le premier nombre");
                    firstNum = float.Parse(Console.ReadLine());
                    Console.WriteLine("Veuillez le deuxieme nombre");
                    secNum = float.Parse(Console.ReadLine());
                    sum = firstNum * secNum;
                    Console.WriteLine("La multiplication de {0} * {1} = {2}", firstNum, secNum, sum);

                }
                //Code for a / b
                if (sign == '/')
                {
                    Console.WriteLine("Veuillez le premier nombre");
                    firstNum = float.Parse(Console.ReadLine());
                    Console.WriteLine("Veuillez le deuxieme nombre");
                    secNum = float.Parse(Console.ReadLine());

                    if (secNum != 0) {
                            sum = firstNum / secNum;
                    Console.WriteLine("La division de {0} / {1} = {2}", firstNum, secNum, sum);
                    } else {
                    Console.WriteLine("Impossible d effectuer la division par O");
                    }
                

                }
                if (sign == 'S')                      //Code for square equations
                {
                    Console.WriteLine("Veuillez le premier nombre");
                    firstNum = float.Parse(Console.ReadLine());
                    Console.WriteLine("Veuillez le deuxieme nombre");
                    secNum = float.Parse(Console.ReadLine());
                    Console.WriteLine("Veuillez le troisieme nombre");
                    thirdNum = float.Parse(Console.ReadLine());
                    Discriminant = secNum * secNum - (4 * firstNum * thirdNum);
                    Console.WriteLine("Le discrimiant est {0}", Discriminant);

                    if (Discriminant > 0)
                    {
                        double squareRoot = Math.Sqrt(Discriminant);
                        double a = firstNum;
                        double b = secNum;
                        double c = thirdNum;
                        x1 = (-secNum - squareRoot) / (2 * firstNum);
                        x2 = (-secNum + squareRoot) / (2 * firstNum);
                        Console.WriteLine("Le premier X is {0} et le second X est {1}", x1, x2);
                    }
                    if (Discriminant == 0)
                    {
                        double squareRoot = Math.Sqrt(Discriminant);
                        double a = firstNum;
                        double b = secNum;
                        double c = thirdNum;
                        x1 = (-secNum) / (2 * firstNum);
                        Console.WriteLine("Le premier X and le second X est {0}", x1);
                    }
                    if (Discriminant < 0)
                    {
                        Console.WriteLine("Impossible de resoudre");

                    }


                }
            } while (Start == 1);


        }
    }
}

