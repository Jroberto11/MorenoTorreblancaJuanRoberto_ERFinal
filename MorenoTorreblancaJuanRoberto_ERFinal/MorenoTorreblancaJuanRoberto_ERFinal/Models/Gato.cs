﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorenoTorreblancaJuanRoberto_ERFinal.Models
{
    class Gato:Animal
    {
        string raza { get; }
        string microchip { get; }

        public Gato(string Nombre, string FechaNacimiento1, double Peso1, string Raza, string Microchip, string Comentarios):base(Nombre,FechaNacimiento1,Peso1,Comentarios)
       {

            Raza = raza;
            Microchip = microchip;
        }
        public override string ToString()
        {
            return "Ficha del Gato" + "Nombre: " + nombre + "Raza: " + raza + "Fecha Nacimiento: " + fechaNacimiento + " Peso: " + peso + "kg" + " Microchip: " + microchip + "Comentarios" + comentarios;
        }
    }
}
