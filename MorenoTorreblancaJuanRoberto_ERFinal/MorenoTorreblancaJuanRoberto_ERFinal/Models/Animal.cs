using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorenoTorreblancaJuanRoberto_ERFinal.Interfaces;
namespace MorenoTorreblancaJuanRoberto_ERFinal.Models
{
   abstract class Animal : IPesable
    {
       protected string nombre;
       protected string fechaNacimiento;
       protected double peso;
       protected string comentarios;

        public Animal(string Nombre,string FechaNacimiento,double Peso, string Comentarios)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Peso = peso;
            Comentarios = comentarios;

        }
       public  Animal(string Nombre, string FechaNacimiento, double Peso)
        {
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
            Peso = peso;          
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            
        }

        public string FechaNacimiento1
        {
            get
            {
                return fechaNacimiento;
            }
            
        }

        public double Peso1
        {
            get
            {
                return peso;
            }
           
       
        }

        public string Comentarios1
        {
            get
            {
                return comentarios;
            }

            set
            {
                comentarios = value;
            }
        }

        double IPesable.peso()
        {
            throw new NotImplementedException();
        }

        public void pesar(double peso)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            return "Ficha del Animal"+"Nombre: "+nombre +"Fecha Nacimiento: "+fechaNacimiento+" Peso: "+ peso +"Comentarios"+comentarios;
        }
    }
}
