using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_LB_4
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string zadanie = File.ReadAllText(@"..\..\..\chisla.txt");
            string[]  ts =zadanie.Split(',',' ');
            List<double> perebor = new List<double>();
            for (int i = 0; i < ts.Length; i++)
            {
                double rez;
                if (Double.TryParse(ts[i],out rez))
                {
                    perebor.Add(rez);
                }
            }
            int counter = 1;
            if (perebor.Count != 0)
            {
                double before = perebor.FirstOrDefault();

                for (int i = 1; i < perebor.Count; i++)
                {
                    if (before != perebor.ElementAt(i))
                    {
                        before = perebor.ElementAt(i);
                        counter++;
                    }
                }
            }
            else
                counter = 0;
            foreach (string ss in ts)
            {
                Console.Write("{0} ", ss);
            }
            Console.WriteLine();
            Console.WriteLine("result - {0}",counter);
            File.WriteAllText(@"..\..\..\chisla.out",counter.ToString());
            Console.ReadKey();
        }
    }
}
