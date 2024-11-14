using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using estudiante;
namespace ConsoleApp1
{
    public class crear
    {

            string[] estudiantes1 = new string[0];
            int posicion = 0;

            public void creard()
            {
                string des;
                Console.Write("Ingresa el nombre del estudiante : ");
                des = Console.ReadLine();
                Array.Resize(ref estudiantes1, estudiantes1.Length + 1);
                estudiantes1[posicion] = des;
                posicion = posicion + 1;
                Console.WriteLine("A agregado una cita ");
            }

    }
}
