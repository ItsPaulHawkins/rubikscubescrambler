using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rubikscubescrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("How long do you want your scramble to be?");
                int length = Int32.Parse(Console.ReadLine());
                int[] rannumbers; //creates random number string
                string[] scramble;
                scramble = new string[length];
                rannumbers = new int[length];
                int count = 0; //initialized to count how many generates there have been
                Random rnd = new Random();
                while (count != length)
                {
                    int randomnumber = rnd.Next(1, 12);
                    rannumbers[count] = randomnumber;
                    if (rannumbers[count] == 1)
                    {
                        scramble[count] = "R";
                        count++;
                    }
                    else if (rannumbers[count] == 2)
                    {
                        scramble[count] = "Ri";
                        count++;
                    }
                    else if (rannumbers[count] == 3)
                    {
                        scramble[count] = "L";
                        count++;
                    }
                    else if (rannumbers[count] == 4)
                    {
                        scramble[count] = "Li";
                        count++;
                    }
                    else if (rannumbers[count] == 5)
                    {
                        scramble[count] = "B";
                        count++;
                    }
                    else if (rannumbers[count] == 6)
                    {
                        scramble[count] = "Bi";
                        count++;
                    }
                    else if (rannumbers[count] == 7)
                    {
                        scramble[count] = "D";
                        count++;
                    }
                    else if (rannumbers[count] == 8)
                    {
                        scramble[count] = "Di";
                        count++;
                    }
                    else if (rannumbers[count] == 9)
                    {
                        scramble[count] = "F";
                        count++;
                    }
                    else if (rannumbers[count] == 10)
                    {
                        scramble[count] = "Fi";
                        count++;
                    }
                    else if (rannumbers[count] == 11)
                    {
                        scramble[count] = "U";
                        count++;
                    }
                    else if (rannumbers[count] == 12)
                    {
                        scramble[count] = "Ui";
                        count++;
                    }


                }
                Console.Write(string.Join(" " , scramble));
                Console.WriteLine(", Would you like to generate a new one?");
                string question = Console.ReadLine();
                if (question == "yes")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }


            }
        }
    }
}
