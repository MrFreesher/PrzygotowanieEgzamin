using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzygotowanieEgzamin {
    class KlasaPochodna2 : KlasaBazowa {
        public KlasaPochodna2() {
            this.name = "Pochodna2";
        }

        public override string Name {
            get {
                return $"{this.name} +1 ";
            }
        }

        override public   void sayHello() {
            Console.WriteLine($"Pozdrowienia z {Name}. Witam was {Name}");
        }
    }
}
