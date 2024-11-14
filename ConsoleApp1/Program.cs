using estudiante;
using ConsoleApp1;
using ConsoleApp2;
byte opcion;
string[] nick1 = new string[0];
crear g=new crear();
string[] uni1 = new string[0];
crear h=new crear();
string[] enfermedad = new string[0];
crear i = new crear();
estudiantes d = new estudiantes();
string regresar;
do
{

    Console.WriteLine("Programa de Desayunos\n");

    Console.WriteLine("******* MENÚ *******");

    Console.WriteLine("* 1. Crear         *");


    Console.WriteLine("* 2. Lista         *");

    Console.WriteLine("* 3. Eliminar      *");

    Console.WriteLine("* 0. Salir         *");

    Console.WriteLine("********************\n");



    Console.Write("Ingrese opcion: ");



    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {

        Console.Write("Error: Ingrese opcion: ");

    }


    
    switch (opcion)
    {

        case 0: Environment.Exit(0); break;

        case 1: g.creard(); h.creard(); i.creard(); break;

        case 2: Console.WriteLine(d);  break;

        case 3: break;


    }

    Console.WriteLine("Desea regresar al menú? [si]: ");

    regresar = Console.ReadLine();

    Console.Clear();

} while (regresar == "si");