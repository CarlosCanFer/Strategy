using EjemploStrategy.Convertidor;
using EjemploStrategy.Interfaces;
using System;

namespace EjemploStrategy
{
    public class ConvertirImagen : IConvertirImagen
    {
        void IConvertirImagen.ConvertirImagen(string _cnombre, string _cformato)
        {
            IConvertidorImagen objconvertir = new ConvertidorPNG();
            IConvertidorImagen objconvertirJPG = new ConvertidorJPG();
            IConvertidorImagen objconvertirGIF = new ConvertidorGIF();


            switch (_cformato) {
                case "1":
                    objconvertir.GuardarImagen(_cnombre);
                    break;
                case "2":
                    objconvertirJPG.GuardarImagen(_cnombre);
                    break;
                case "3":
                    objconvertirGIF.GuardarImagen(_cnombre);
                    break;
                default: Console.WriteLine("Dato insertado incorrecto!!!");
                    break;
            }
                
        }
    }
}
