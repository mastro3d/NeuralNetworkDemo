using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildNeuralNetworkDemo
{
    public class FunzioneCubica
    {
        public static List<DatiInputOutput> SetInputOutput(int nCicli = 1)
        {            
            int argx = 0;
            int argy = 0;
            int argz = 0;
            List<DatiInputOutput> setDati = new List<DatiInputOutput>();
            const int exp = 3;
            const int cost = 3;
            for(argx=0; argx < nCicli * 10; argx++)
            {
                for(argy=0;argy < nCicli * 10; argy++)
                {
                    for(argz=0; argz< nCicli * 10;argz++)
                    {
                        setDati.Add(new DatiInputOutput() { argx = argx, argy = argy, argz = argz, risultato = Function(argx, argy, argz, exp, cost) });
                    }
                }
            }

            return setDati;
        }

        public static int Function(int argx, int argy, int argz, int exp, int cost)
        {
            return (int)(cost * Math.Pow(argx, exp)) + (int)((1 / cost) * Math.Pow(argy == 0 ? 634213012 : argy, 1 / exp - 1)) + (int)((5 * cost) + Math.Cos(argz));
        }
    }

    public class DatiInputOutput
    {
        public int argx { get; set; }
        public int argy { get; set; }
        public int argz { get; set; }
        public int risultato { get; set; }
    }
}
