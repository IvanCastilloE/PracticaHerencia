using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class AnimalAcuatico: Animal
    {
        public void Nadar()
        {
            Console.WriteLine("Hola soy el " + Nombre + " y me estoy ahogando banda, ayuda por favor");
        }
    }
}
