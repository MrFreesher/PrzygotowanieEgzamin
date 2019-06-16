using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzygotowanieEgzamin {
    class Program {
        static void Main(string[] args) {
            List<KlasaBazowa> lista = new List<KlasaBazowa>();
            lista.Add(new KlasaPochodna1());
            lista.Add(new KlasaPochodna2());
            lista.Add(new KlasaPochodna1());
            foreach(var item in lista) {
                item.sayHello();
            }

            //Różnica między new a override

            Console.Write("\n Różnica między new a override\n");
            OverBase o1 = new Over1();
            OverBase o2 = new Over2();
            Over2 o3 = (Over2)o2;
            o1.saySomething();
            o2.saySomething();
            o3.saySomething();
            Console.ReadKey();
        }
    }
}
