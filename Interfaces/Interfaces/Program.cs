using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //llamamos a la clase principal y la intanciamos
            Principal principal = new Principal();
            principal.Bienvenido();
            Console.ReadKey();
        }
    }
}
