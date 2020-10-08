using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DHCPSzimulacio
{
    class Program
    {
        static List<string> excluded = new List<string>();
        static void Main(string[] args)
        {
            BeolvasExcluded();
            Console.ReadKey();
        }
        static void BeolvasExcluded()
        {
            
            try
            {
                StreamReader file = new StreamReader("excluded.csv");
                try
                {
                    while (!file.EndOfStream)
                    {
                        excluded.Add(file.ReadLine());
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    file.Close();
                }
                file.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static string CimEgyelNo(string cim)
        {
            string[] adat = cim.Split('.');
            int utolso = int.Parse(adat[3]);
            if (utolso<255)
            {
                utolso++;
            }
            return adat[0] + "." + adat[1] + "." + adat[3] + "." + utolso.ToString();
        }
    }
}
