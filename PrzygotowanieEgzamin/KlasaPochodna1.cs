using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzygotowanieEgzamin {
    class KlasaPochodna1 : KlasaBazowa{
        public KlasaPochodna1() {
            this.name = "Pochodna1";
        }

        public override string Name {
            get { return this.name; }
        }

        override public void sayHello() {
            Console.WriteLine($"Pozdrowienia z {Name}");
        }
    }
}
