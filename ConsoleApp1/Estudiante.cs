﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace estudiante
{
    public class estudiantes
    {
        public string Nombre { get; set; }
        public double cod { get; set; }
        public string uni { get; set; }
        public int Numero { get; set; }
        public estudiantes Estudiante { get; set; }
        public string Enfermedad { get; set; }
        public double Precio { get; set; }

        public override string? ToString()
    {
        return $"El estudiante con codigo de estudiantes {cod}  y nombre {Nombre}, de la universidad {uni}, con el número{Numero}, con la enfermedad{enfermedad} ";
    }
    }
}
