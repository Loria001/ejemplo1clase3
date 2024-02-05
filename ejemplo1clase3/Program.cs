
int tamano = 2;
string[] nombre = new string[tamano];
int[] edad = new int[tamano];
string[] cita = new string[tamano];
int opcion = 0;


menu();


void inicializar()
{
    nombre = Enumerable.Repeat("", tamano).ToArray<string>();
    cita = Enumerable.Repeat("", tamano).ToArray<string>();
    edad = Enumerable.Repeat(0, tamano).ToArray<int>();
    Console.WriteLine("Los arreglos han sido inicializados");
    Console.ReadKey();
    Console.Clear();    
}



void consulta() 
{
    bool encontrado = false;
    Console.WriteLine("Digite el nombre a buscar");
    string nomb = Console.ReadLine();
    for (int i = 0; i < nombre.Length; i++)
    {
        if (nomb.Equals(nombre[i]))
        {
            Console.WriteLine($"La edad de {nomb} es {edad[i]}");
            encontrado = true;  
        }
    }

    if (encontrado == false)
    {
      Console.WriteLine($"El cliente {nomb}no existe");
    }

}


void asignarcita()
{
    Console.WriteLine("Ingrese el nombre del paciente para asignar cita (d/m/aaaa) hora formato 24hrs");
    string nomb = Console.ReadLine();
    bool encontrado = false;

    for (int i = 0; i < nombre.Length; i++)
    {
        if (nomb.Equals(nombre[i]))
        {
            Console.WriteLine($"Ingrese la cita para {nomb}");
            cita[i] = Console.ReadLine();
            encontrado = true;
            Console.WriteLine($"Cita asignada correctamente a {nomb}");
        }
    }

    if (!encontrado)
    {
        Console.WriteLine($"El paciente {nomb} no existe");
    }
}



void agregar()
{
    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine("Ingrese el nombre"); nombre[i] = Console.ReadLine();
        Console.WriteLine("Ingrese la edad"); edad[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Desea agregar un cliente más (si/no)");
        string continuar = Console.ReadLine();

        if(continuar.ToLower() != "si")
        {
            break;
        }
    }
}

void reporte()
{

    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine("   Nombre          Edad          cita");
        Console.WriteLine($"    {nombre[i]}       {edad[i]}       {cita[i]} ");

    }






}

void menu()
{
    do
    {
        Console.WriteLine("    Menu principal    ");
        Console.WriteLine("1- Inicializar arreglos");
        Console.WriteLine("2-Ingresar paciente");
        Console.WriteLine("3-Consultar paciente");
        Console.WriteLine("4-Reporte");
        Console.WriteLine("5-Asignar citas");
        Console.WriteLine("6-Salir");
        Console.WriteLine("Digite una opcion...");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1: inicializar(); break;
            case 2: agregar(); break;
            case 3: consulta();  break;
            case 4: reporte(); break;
            case 5: asignarcita(); break;
            default:
                break;
        }

    } while (opcion!=6);

 }


