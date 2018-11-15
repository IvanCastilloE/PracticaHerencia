using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Kanguro: AnimalTerrestre
    {
        public Kanguro()
        {
            Nombre = "Jackie";
        }
        public void SaltarBienAlto()
        {
            Console.WriteLine("Hola soy el " + Nombre + " y ando bien arriba banda");
        }
    }
}
