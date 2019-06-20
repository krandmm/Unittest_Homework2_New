using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unittest_Homework2_New
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("********* Triangle type check *********");
                Console.WriteLine();
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. exit");
                Console.WriteLine();
                String line = Console.ReadLine();
                
                /// <summary>
                /// When click button "1" 
                /// </summary>
                
                if (line == "1")
                {
                    int number;
                    string userinputa;
                    string userinputb;
                    string userinputc;
                    int choicea;
                    int choiceb;
                    int choicec;
                    bool flag = false;

                    /// <summary>
                    /// The length of first side input
                    /// Check if an integer is entered (Only integers are allowed)
                    /// </summary>
                     
                    do
                    {
                        flag = false;
                        Console.WriteLine("1. Please enter the length of first side");
                        string sidea = Console.ReadLine();
                        userinputa = sidea;

                        bool check = int.TryParse(sidea, out choicea);

                        if (check == false)
                        {
                            flag = true;

                        }
                    } while (!int.TryParse(userinputa, out number) || number <= 0);

                    /// <summary>
                    /// The length of second side
                    /// Check if an integer is entered (Only integers are allowed)
                    /// </summary>
                    do
                    {

                        flag = false;
                        Console.WriteLine("2. Please enter the length of second side");
                        String sideb = Console.ReadLine();
                        userinputb = sideb;

                        bool check = int.TryParse(sideb, out choiceb);


                        if (check == false)
                        {
                            flag = true;

                        }
                    } while (!int.TryParse(userinputb, out number) || number <= 0);

                    /// <summary>
                    /// The length of third side
                    /// Check if an integer is entered (Only integers are allowed)
                    /// </summary>
                    do
                    {
                        flag = false;
                        Console.WriteLine("3. Please enter the length of third side");
                        String sidec = Console.ReadLine();
                        userinputc = sidec;

                        bool check = int.TryParse(sidec, out choicec);

                        if (check == false)
                        {
                            flag = true;

                        }
                    } while (!int.TryParse(userinputc, out number) || number <= 0);

                    /// <summary>
                    /// Output the result of the execution.
                    /// </summary>
                    Console.WriteLine("{0}", TriangleSolver.Analyze(choicea, choiceb, choicec));

                    Console.ReadKey();


                }
                /// <summary>
                /// When click button "1" or "exit" 
                /// </summary>
                if (line == "2")
                {
                    break;
                }

                if (line == "exit")
                {
                    break;
                }

            }
        }
    }
}
