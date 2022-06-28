using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Theatre_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("******Welcome To Movieplex Theatre********");
                Console.WriteLine("******************************************");

                Console.WriteLine("Please Select From The Following Options:");
                Console.WriteLine("1:Administartor");
                Console.WriteLine("2:Guests");

                Console.WriteLine("Selection :");
                int Selection = int.Parse(Console.ReadLine());
                var Selection_count = Console.ReadLine();
                int out_sele;
                bool parseSuccess = int.TryParse(Selection_count, out out_sele);
                if (parseSuccess)
                    Console.WriteLine($"Your Selected Number is: {out_sele}");
                else
                    Console.WriteLine("This is not a number!");

                int[] selected_val = new int[Selection];
                if (Selection > 2 || Selection < 1)
                {
                    Console.WriteLine("Please Select From The Following Options:");
                }
                else
                {

                    const string pass = "Password";
                    string attempt;
                    int attemptnum = 0;
                    do
                    {
                        Console.Write("Please enter password: ");
                        attempt = Console.ReadLine();

                        if (attempt == pass)
                        {
                            Console.WriteLine("Access granted.");
                        }
                        else
                        {
                            Console.WriteLine("Access denied,You Entered The Invalid Password");
                            attemptnum++;

                            if (attemptnum >= 5)
                            {
                                Console.WriteLine("Access denied,You Entered The Invalid Password");
                            }
                        }
                    } while (attemptnum <= 5 && attempt != pass);
                }




                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("******APPLICATION ERRORS*******");
                Console.WriteLine("Method: {0}", e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("StackTrace: {0}", e.StackTrace);
                Console.WriteLine("Source: {0}", e.Source);
            }
        }


    }

    
}