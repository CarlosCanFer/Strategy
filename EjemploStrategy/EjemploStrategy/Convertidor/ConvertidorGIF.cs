using EjemploStrategy.Interfaces;
using System;

namespace EjemploStrategy.Convertidor
{
    public class ConvertidorGIF : IConvertidorImagen
    {
        void IConvertidorImagen.GuardarImagen(string _cnombrearchivo)
        {
            string _cmensaje;
            _cmensaje = ("Se ha guardado la imagen " + _cnombrearchivo + ".GIF Correctamente");
            Console.WriteLine(_cmensaje);
        }
    }
}
