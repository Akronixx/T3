using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudiante;
namespace ConsoleApp1
{
    public class cita
    {
            public int Numero { get; set; }
            public estudiantes Estudiante { get; set; }
            public string Enfermedad { get; set; }
            public double Precio { get; set; }


            public cita(double cod, estudiantes estudiante, string enfermedad, double precio)
            {
                cod = cod;
                Estudiante = estudiante;
                Enfermedad = enfermedad;
                Precio = precio;
            }
        public override string ToString()
        {
            return $"Codigo: {Numero}, Enfermedad: {Enfermedad}, Estudiante: {Estudiante.Nombre}, Universidad: {Estudiante.uni}, Precio: {Precio}";
        }

    }
}
