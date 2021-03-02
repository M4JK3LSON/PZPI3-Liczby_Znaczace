using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyZnaczace
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string dane = Console.ReadLine();
                string[] dates = dane.Split(' ');
                int dg = int.Parse(dates[0]);
                int gg = int.Parse(dates[1]);
                //int llwdodg = 0;
                int sumaddg = 0;
                int ldzielnikow = 0;
                int llz = 0;
                int llz2 = 0;

                int sumadogg = 0;
                //int llwdogg = 0;

                for(int j = 2; j < gg; j++)
                {
                    if (j < dg)
                    {
                        for (int k = 2; k < j; k++)
                        {
                            if (j % k == 0)
                            {
                                ldzielnikow++;
                                sumaddg += k;
                            }
                        }
                        if (ldzielnikow != 0)
                        {
                            double pierwiastek = Math.Sqrt(j);
                            double srednia = sumaddg / ldzielnikow;
                            sumaddg = 0;
                            ldzielnikow = 0;
                            if (srednia <= pierwiastek)
                            {
                               // Console.WriteLine("Liczba znacząca: " + j);
                                llz++;
                            }
                        }
                        
                    }
                    else
                    {
                        for(int m = 2; m < j; m++)
                        {
                            if (j % m == 0)
                            {
                                ldzielnikow++;
                                sumadogg += m;
                            }
                        }
                        if (ldzielnikow != 0)
                        {
                            double pierwiastek = Math.Sqrt(j);
                            double srednia = sumadogg / ldzielnikow;
                            sumadogg = 0;
                            ldzielnikow = 0;
                            if (srednia <= pierwiastek)
                            {
                              //Console.WriteLine("Liczba znacząca: " + j);
                                llz2++;
                            }
                        }
                        
                    }
                }
                
                
                int roznica = llz2 - llz;
                Console.WriteLine(roznica);

            }
            Console.ReadKey();
        }
    }
}
