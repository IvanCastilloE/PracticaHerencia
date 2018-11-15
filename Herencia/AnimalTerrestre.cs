using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class AnimalTerrestre:Animal
    {
        public void caminar()
        {
            Console.WriteLine("Hola soy el " + Nombre + " y estoy caminando");
        }
    }
}
