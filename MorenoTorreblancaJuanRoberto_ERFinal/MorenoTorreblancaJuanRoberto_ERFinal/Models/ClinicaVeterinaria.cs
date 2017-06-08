using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoTorreblancaJuanRoberto_ERFinal.Models
{
    class ClinicaVeterinaria
    {
        List<Animal> listaAnimales;

        public ClinicaVeterinaria()
        {
            this.listaAnimales = new List<Animal>();
        }
             
        private int MenuInsertar()
        {
           
            Console.WriteLine("/Insertar Animal/");

            Console.WriteLine("1. Perro");

            Console.WriteLine("2. Gato");

            Console.WriteLine("3. Pajaro");

            Console.WriteLine("4. Reptil");


            Console.WriteLine("¿Qué animal desea introducir?: ");
            int opcion = 0;
            bool esCorrecto=false;
            String aux = Console.ReadLine();            
            esCorrecto=Int32.TryParse(aux, out opcion);
            if (esCorrecto)
            {
                if(opcion>4 || opcion <= 0)
                {
                   
                }
            }
           
            
            return opcion;
        }

        public void insertar()
        {
            int opcion = MenuInsertar();
            String nombre, fechaNacimiento, comentarios;
            double peso;
            bool esCorrecto = false;
            Console.WriteLine("nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Feccha de nacimiento: ");
            fechaNacimiento = Console.ReadLine();
            Console.WriteLine("Comentarios: ");
            comentarios = Console.ReadLine();
            Console.WriteLine("Peso: ");         
            String aux = Console.ReadLine();
            esCorrecto= Double.TryParse(aux, out peso);
            if (esCorrecto)
            {



            }
            else
            {

            }

            switch (opcion)
            {
                case 1:

                    Console.WriteLine("Raza del Perro: ");
                    String raza = Console.ReadLine();
                    Console.WriteLine("Microchip del Perro: ");
                    String microchip = Console.ReadLine();
                    Animal perro = new Perro(nombre, fechaNacimiento, peso, microchip, raza, comentarios);
                    aniadiranimal(perro);
                    break;
                case 2:

                    Console.WriteLine("Raza del Gato: ");
                    String razag = Console.ReadLine();
                    Console.WriteLine("Microchip del Gato: ");
                    String microchipg = Console.ReadLine();
                    Animal Gato = new Gato(nombre, fechaNacimiento, peso, comentarios, microchipg, razag);
                    aniadiranimal(Gato);
                    break;
                case 3:
                    Console.WriteLine("Especie del Pajaro: ");
                    String especie = Console.ReadLine();
                    Console.WriteLine("El pajaro es cantor?: ");
                    bool escantor;
                    aux=Console.ReadLine();
                    esCorrecto=bool.TryParse(aux, out escantor);
                    if (esCorrecto)
                    {

                    }else
                    {

                    }
                   

                    Animal pajaro = new Pajaro(nombre, fechaNacimiento, peso, comentarios,escantor, especie);
                    aniadiranimal(pajaro);
                    break;
                case 4:
                    Console.WriteLine("Especie del Reptil: ");
                    String especier = Console.ReadLine();
                    Console.WriteLine("El reptil es venenoso?: ");
                    bool esvenenoso;
                    aux = Console.ReadLine();
                    esCorrecto = bool.TryParse(aux, out esvenenoso);
                    if (esCorrecto)
                    {

                    }
                    else
                    {

                    }
                    Animal reptil = new Reptil(nombre, fechaNacimiento, peso, comentarios, esvenenoso,especier);
                    aniadiranimal(reptil);
                    break;
                default:
                    break;
            }
        

    }
        public void buscaAnimal(String nom)
        {

        }
        public  void modificarComentarioAnimal(String nombre)
        {

        }          
        private void aniadiranimal(Animal a)
        {

            if (!this.listaAnimales.Contains(a))
            {
                this.listaAnimales.Add(a);
            }
            else
            {
               Console.WriteLine("[ERROR] El Animal ya está en la clinica!!!");
            }
        }
        //metodo para pedir nombre
        private String pedirnombre()
        {
           
          Console.WriteLine("Nombre del Animal: ");
            return Console.ReadLine();

        }
        //Metodo para busar animal
        public void buscaranimal()
        {
            String nombreA = pedirnombre();
            Animal algo = null;

          for(int i = 0; i < 5; i++)
            {
                Animal animal = listaAnimales[1];


                if (animal.Nombre.Equals(nombreA))
                {
                    algo = animal;
                }

                if (algo != null)
                {

                    Console.WriteLine("Esta es la ficha de su querida mascota: ");
                    Console.WriteLine(algo);
                }
                else
                {
                    Console.WriteLine("Lo sentimos no podemos encontrar el animal al cual te refieres.");
                }

            }
           
        }
 
      
   

    }
}
