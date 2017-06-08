using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorenoTorreblancaJuanRoberto_ERFinal.Models;
namespace MorenoTorreblancaJuanRoberto_ERFinal
{
    class Program
    {
        static void Main(string[] args)
        {
         ClinicaVeterinaria t=new ClinicaVeterinaria();
            
            int opcion;
            do
            {
                opcion = mostrarMenu();
                if (opcion != 4)
                {
                    Console.WriteLine("Vamos alla!");
                }
                else
                {
                    Console.WriteLine("Adiós");
                }

                switch (opcion)
                {
                    
                    case 1:
                        t.insertar();
                        break;
                    case 2:
           
                        break;

                    case 3:
                        break;
                    case 4:
                        break;

                    default:
                        Console.WriteLine("[ERROR] Opción no válida.");
                        break;
                }
            } while (opcion != 4);
        }

        //con este metodo creamos el menu y lo mostramos

        public static int mostrarMenu()
        {
            
            Console.WriteLine("Bienvenido a la clinica " );
            Console.WriteLine("/** MENU **/");
            Console.WriteLine("1. Añadir animal");
            Console.WriteLine("2. Modificar Comentario");
            Console.WriteLine("3. Pesar Animal");
            Console.WriteLine("4. Mostrar ficha");
           Console.WriteLine("");
            Console.WriteLine("¿Qué desea hacer?: ");

            int opcion = 0;//esta variable la usamos para capturar la opcion que corresponda
            string aux=Console.ReadLine();
           Int32.TryParse(aux, out opcion);
            return opcion;

        }


 
}
}
