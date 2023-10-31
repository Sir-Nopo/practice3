using System;

namespace practice3
{
    class Program
    {
        //MohammadReza Fatahi
        //tamrin3
        static void Main(string[] args)
        {
            
            {
                double pish2;
                double qur2;
                double riz2;
                double far2;
                double eng2;
                double kar2;

                first:
                Console.WriteLine("1.nomre barname sazi pishrafte ra vared konid");
                string pish = Console.ReadLine();
                double pish1 = double.Parse(pish);
                if (pish1 > 20 || pish1 < 0)
                {
                   
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("nomre bayad bein 0 ta 20 bashad");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto first;
                    
                }
                else
                {
                    pish2 = pish1 * 3;
                }

                first2:
                Console.WriteLine("2.nomre dars tafsir quran ra vared konid");
                string qur = Console.ReadLine();
                double qur1 = double.Parse(qur);
                if (qur1 > 20 || qur1 < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nomre bayad bein 0 ta 20 bashad");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto first2;

                }
                else
                {
                    qur2 = qur1 * 2;
                }

                first3:
                Console.WriteLine("3.nomre dars riazi ra vared konid");
                string riz = Console.ReadLine();
                double riz1 = double.Parse(riz);
                if (riz1 > 20 || riz1 < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nomre bayad bein 0 ta 20 bashad");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto first3;

                }
                else
                {
                    riz2 = riz1 * 3;
                }

                first4:
                Console.WriteLine("4.nomre dars farsi ra vared konid");
                string far = Console.ReadLine();
                double far1 = double.Parse(far);
                if (far1 > 20 || far1 < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nomre bayad bein 0 ta 20 bashad");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto first4;

                }
                else
                {
                    far2 = far1 * 3;
                }

                first5:
                Console.WriteLine("5.nomre dars englisi ra vared konid");
                string eng = Console.ReadLine();
                double eng1 = double.Parse(eng);
                if (eng1 > 20 || eng1 < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nomre bayad bein 0 ta 20 bashad");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto first5;

                }
                else
                {
                    eng2 = eng1 * 3;
                }

                first6:
                Console.WriteLine("6.nomre dars karrah shoqli ra vared konid");
                string kar = Console.ReadLine();
                double kar1 = double.Parse(kar);
                if (kar1 > 20 || kar1 < 0)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nomre bayad bein 0 ta 20 bashad");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto first6;

                }
                else
                {
                    kar2 = kar1 * 2;
                }
                double sum = pish2 + qur2 + riz2 + far2 + eng2 + kar2;
                double miangin = sum / 16;
                Console.WriteLine("moadel term shoma : "+miangin);
                Console.WriteLine("");
                Console.WriteLine("aya mikhay edame bedi?! (y/n)");
                string x = Console.ReadLine();
                if(x=="y")
                {
                    goto first;
                }
                else
                {
                    Console.WriteLine("khodafez");
                }

                Console.ReadKey();
            }
           
        }
    }
}
