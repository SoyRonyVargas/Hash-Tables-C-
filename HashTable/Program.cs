using System.Collections;
using HashTable;

CHashTable tabla_hash = new CHashTable();

while ( true )
{

    tabla_hash.mostrarMenu();

    int opcion = tabla_hash.accionMenu();

    if (opcion == 1)
    {
        Console.WriteLine("Presiona enter para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
    if (opcion == -1)
    {
        Console.Clear();
        Console.WriteLine("Que tenga buen dia :)");
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
        break;
    }

}

