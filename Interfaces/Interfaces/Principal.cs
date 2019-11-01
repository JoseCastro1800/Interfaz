using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Principal
    {
       
        
            // a la clase operacion la invocamos para que esta se agregue con los demas metodos 
            Operaciones operacion = new Operaciones();

            // Aqui hacemos en metodo bienvenido y llamamos junto con el al menu
            public void Bienvenido()
            {
                Console.WriteLine("Bienvenido a su programa");

                Menu();
                Console.ReadKey();

            }

            public void Menu()
            {
                // Aqui s ele da la opcion de elegir que opcion quiere el usuario
                Console.WriteLine("Elige la opcion deseada");
                Console.WriteLine("1.- Suma");
                Console.WriteLine("2.- Resta");
                Console.WriteLine("3.- Multiplicacion");
                Console.WriteLine("4.- Divicion");
                Console.WriteLine("5.- Salir del programa");

                switch (Console.ReadLine())
                {
                    case "1":
                        operacion.Suma();

                        break;
                    case "2":
                        operacion.Resta();

                        break;
                    case "3":
                        operacion.Mutiplicacion();

                        break;
                    case "4":

                        operacion.Divicion();
                        break;
                    case "5":

                        Environment.Exit(0);
                        break;

                }

                //Aqui se le llama para regresar al menu
                Menu();

            

        }
    }
}
