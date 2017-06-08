using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoTorreblancaJuanRoberto_ERFinal.Models
{
    class Pajaro:Animal
    {
        string especie { get; }
        bool cantor { get; }

        public Pajaro(string Nombre, string FechaNacimiento1, double Peso1, string Especie, bool Escantor, string Comentarios):base(Nombre,FechaNacimiento1,Peso1,Comentarios)
       {
            Especie = especie;
            Escantor = cantor;
            
        }
        public override string ToString()
        {
            return "Ficha del Pajaro" + "Nombre: " + nombre + "Especie: " + especie + "Fecha Nacimiento: " + fechaNacimiento + " Peso: " + peso + "kg" + "Cantor: " + cantor + "Comentarios" + comentarios;
        }
    }
}
