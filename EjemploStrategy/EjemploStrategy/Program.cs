using EjemploStrategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploStrategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConvertirImagen convertirImagen = new ConvertirImagen();

            Console.WriteLine("Introduce el nombre de la imagen");
            String _cnombre = Console.ReadLine();

            Console.WriteLine("Inserta el formato del imagen");
            Console.WriteLine("1.-PNG");
            Console.WriteLine("2.-JPG");
            Console.WriteLine("3.-GIF");
            string _cextencion = Console.ReadLine();

            convertirImagen.ConvertirImagen(_cnombre,_cextencion);

            Console.ReadKey();


        }
    }
}
