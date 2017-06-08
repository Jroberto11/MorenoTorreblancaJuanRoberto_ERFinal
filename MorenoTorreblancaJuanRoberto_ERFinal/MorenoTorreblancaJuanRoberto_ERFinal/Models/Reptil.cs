using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoTorreblancaJuanRoberto_ERFinal.Models
{
    class Reptil:Animal
    {
        string especie{ get; }
        bool venenoso{ get; }

        public Reptil(string Nombre, string FechaNacimiento1, double Peso1, string Especie, bool ESvenenoso, string Comentarios):base(Nombre,FechaNacimiento1,Peso1,Comentarios)
        {

            Especie = especie;
            ESvenenoso = venenoso;
        }
        public override string ToString()
        {
            return "Ficha del Reptil" + "Nombre: " + nombre + "Especie: " + especie + "Fecha Nacimiento: " + fechaNacimiento + " Peso: " + peso + "kg" + " Venenoso: " + venenoso + "Comentarios" + comentarios;
        }
    }
}
