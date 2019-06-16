using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzygotowanieEgzamin {
    abstract class KlasaBazowa {
        protected string name = "Bazowa";
        abstract public string Name {
            get;
        }
        abstract public void sayHello();
    }
}
