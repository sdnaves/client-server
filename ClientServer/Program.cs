using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClientServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args.Contains("teste"))
                {
                    Teste();
                }
                else if (args.Contains("help"))
                {
                    Help();
                }
                else
                {
                    Console.WriteLine(args[i]);
                }
            }
        }

        public static void Teste()
        {
            Console.WriteLine("Deu Certo!");
        }

        public static void Help()
        {
            Console.WriteLine("Não Implementado Ainda!");
        }
    }
}
