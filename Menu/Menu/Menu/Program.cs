using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
     int opcion = 0;
      string tarea;
        List<string> tareas = new List<string>();
        
        while (opcion != 5)
        {
            Console.WriteLine("-----MENU-----");
            Console.WriteLine("Crea una lista de tareas por realzar");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1)-----------Agregar tarea");
            Console.WriteLine("2)-----------Mostrar la lista de tareas por hacer");
            Console.WriteLine("3)-----------Eliminar tarea");
            Console.WriteLine("4)-----------Salir del programa");
            Console.WriteLine();

            string seleccion = Console.ReadLine();

            if (int.TryParse(seleccion, out opcion))
            {
                opcion = int.Parse(seleccion);
                switch (opcion)
                {
                   case 1:
                        Console.WriteLine("Ingrese la tarea nueva: ");
                        tarea = Console.ReadLine();
                        tareas.Add(tarea);
                       break;
                   case 2:
                        Console.WriteLine("La lista de tareas que debes hacer: ");
                        foreach (var t in tareas)
                        {
                            Console.WriteLine(t);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingresa la tarea que desee eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int indice))
                        {
                            if (indice >= 0 && indice < tareas.Count)
                            {
                                tareas.RemoveAt(indice);
                            }
                            else
                            {
                                Console.WriteLine("No exite la tarea");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Erro!");
                        }
                        break;
                    case 5:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("ERROR!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}

