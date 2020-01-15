using EjemploStrategy.Interfaces;
using System;

namespace EjemploStrategy
{
    public class ConvertidorPNG : IConvertidorImagen
    {
        public void GuardarImagen(string _cnombrearchivo)
        {
            string _cmensaje;
            _cmensaje = ("Se ha guardado la imagen "+ _cnombrearchivo + ".PNG Correctamente");
            Console.WriteLine(_cmensaje);
        }
    }
}
