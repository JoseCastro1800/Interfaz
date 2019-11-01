using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Operaciones: Datos, DyM, SyR
    {
        // Aqui con ayuda de las interfaces y la herencia creamos lo metodos 

        public void Suma()
        {
            double res;
            Console.WriteLine("Sumar:");
            Console.WriteLine("Ingrese el primer numero:");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            N2 = Convert.ToDouble(Console.ReadLine());

            res = N1 + N2;


            Console.WriteLine("El resultado es: " + res);

        }

        public void Resta()
        {
            double res;
            Console.WriteLine("Resta:");
            Console.WriteLine("Ingrese el primer numero:");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            N2 = Convert.ToDouble(Console.ReadLine());

            res = N1 - N2;


            Console.WriteLine("El resultado es: " + res);

        }

        public void Divicion()
        {
            double res;
            Console.WriteLine("Dividir:");
            Console.WriteLine("Ingrese el numero que quiere dividir:");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el divisor");
            N2 = Convert.ToDouble(Console.ReadLine());

            res = N1 / N2;


            Console.WriteLine("El resultado es: " + res);



        }

        public void Mutiplicacion()
        {

            double res;
            Console.WriteLine("Multiplicar:");
            Console.WriteLine("Ingrese el primer numero:");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el otro numero");
            N2 = Convert.ToDouble(Console.ReadLine());

            res = N1 * N2;


            Console.WriteLine("El resultado es: " + res);

        }

       

        
    }
}
