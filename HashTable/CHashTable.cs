using System;
using System.Collections;

namespace HashTable
{
    public class CHashTable
    {

        private Hashtable myHashTable = new Hashtable();

        public void mostrarMenu()
        {
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("| Menu Tablas Hash                               |");
            Console.WriteLine("|------------------------------------------------|");
            Console.WriteLine("| 1) Agregar elemento    | 2) Remover elemento   |");
            Console.WriteLine("| 3) Modificar elemento  | 4) Encontrar elemento |");
            Console.WriteLine("| 5) Mostrar tabla hash  | 6) Salir              |");
            Console.WriteLine("|------------------------------------------------|");
        }

        public int ObtenerOpcion(string msg)
        {

            while (true)
            {

                Console.WriteLine(msg);

                try
                {
                    int opcion = int.Parse(Console.ReadLine()!);

                    return opcion;

                }
                catch
                {

                    Console.Clear();

                    this.successAction("Ingresa una opcion valida...");

                    this.mostrarMenu();

                    continue;

                }
            }
        }

        public int accionMenu()
        {

            int opcion = this.ObtenerOpcion("Ingresa una opcion");

            switch (opcion)
            {
                case 1:
                    this.AddItem();
                    return 1;
                case 2:
                    this.RemoveItem();
                    return 1;
                case 3:
                    this.ModifyItem();
                    return 1;
                case 4:
                    this.FindItem();
                    return 1;
                case 5:
                    this.ShowTable();
                    return 1;
                case 6:
                    this.ShowTable();
                    return -1;
                default:
                    Console.Clear();
                 return 0;
            }

        }

        public void successAction(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void AddItem()
        {

            try
            {

                Console.Clear();

                Console.WriteLine("Ingresa el nombre de la llave");

                string key = Console.ReadLine()!;

                Console.WriteLine($"Ingresa el valor de {key}");

                string value = Console.ReadLine()!;

                this.myHashTable.Add(key, value);

                Console.Clear();

                this.successAction("Se agrego a la tabla");

            }
            catch(Exception err)
            {
                this.successAction("Error no se pudo agregar a la tabla");
            }

        }

        public void RemoveItem()
        {
            try
            {

                Console.Clear();

                Console.WriteLine("Ingresa la llave que quieres eliminar");

                string key = Console.ReadLine()!;

                myHashTable.Remove(key);

                Console.Clear();

                this.successAction("Se elimino correctamente");

            }
            catch
            {
                this.successAction("Error al eliminar la llave");
            }
        }

        public void ModifyItem()
        {

            Console.Clear();

            Console.WriteLine("Ingresa la llave que quieres eliminar");

            string key = Console.ReadLine()!;

            Console.WriteLine("Ingresa el valor a actualizar");

            string newValue = Console.ReadLine()!;

            Console.Clear();

            if (myHashTable.ContainsKey(key))
            {

                myHashTable[key] = newValue;

                this.successAction("Se actualizo la llave");

            }
            else
            {
                this.successAction("No se pudo actualizar");
            }

        }

        public void FindItem()
        {

            Console.Clear();

            Console.WriteLine("Ingresa la llave que quieres buscar");

            string key = Console.ReadLine()!;

            Console.Clear();

            if (myHashTable.ContainsKey(key))
            {
                this.successAction($"Se encontro el elemento {this.myHashTable[key]}");
            }
            else
            {
                this.successAction("No se encontro el elemento");
            }

        }

        public void ShowTable()
        {

            Console.Clear();

            if ( myHashTable.Count == 0 )
            {

                this.successAction("Tabla vacia");

                return;

            }

            foreach (DictionaryEntry item in myHashTable)
            {
                Console.WriteLine("Llave: {0}, Valor: {1}", item.Key, item.Value);
            }

        }
    }
}

