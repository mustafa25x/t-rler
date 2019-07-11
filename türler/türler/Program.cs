using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace türler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir kelime giriniz");
            string kelime = Console.ReadLine();
            char[] kkelime = new char[kelime.Length];

            for(int i = 0; i < kelime.Length; i++)
            {
                kkelime[i] = kelime[i];
                Console.WriteLine("girdiğiniz kelimenin {0} karakteri {1} ",i+1,kelime[i] );
                Console.WriteLine("bu kelimenin {0} karakterinin int değeri {1} ", i+1,(int)kelime[i]);
            }
            Console.ReadKey();

        }
    }
}
