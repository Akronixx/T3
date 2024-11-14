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
        string[] nick1 = new string[0];
        string[] uni1 = new string[0];
        string[] enfermedad = new string[0];
            int posicion = 0;

            public void creard()
            {
                string nom;
                Console.Write("Ingresa el nombre del estudiante : ");
                nom = Console.ReadLine();
                Array.Resize(ref nick1, nick1.Length + 1);
                nick1[posicion] =nom;
                posicion = posicion + 1;
                Console.WriteLine("A agregado un nombre ");
                string uni;
                Console.Write("Ingresa el nombre de la universidad : ");
                uni = Console.ReadLine();
                Array.Resize(ref uni1, uni1.Length + 1);
                uni1[posicion] = uni;
                posicion = posicion + 1;
                Console.WriteLine("A agregado su cita ");
                string enfermedad1;
                 Console.Write("Ingresa el nombre de la enfermedad : ");
                 enfermedad1 = Console.ReadLine();
                 Array.Resize(ref enfermedad, enfermedad.Length + 1);
                 enfermedad[posicion] = enfermedad1;
                 posicion = posicion + 1;
                 Console.WriteLine("A agregado una enfermedad ");
             }

    }
}
