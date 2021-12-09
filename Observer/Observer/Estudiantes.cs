using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    //Se establece la herencia con la interfaz observador.
    class Estudiantes : IObservador
    {
        //Se declaran las variables.
        public string MateriaCursada { get; set; }
        public string NombreEstudiante { get; set; }

        //Se hace uso del metodo Actualizar de la interfaz observador.
        public void Actualizar(ISujeto sujeto)
        {
            if (sujeto is Plataforma novedades)
            {
                //Se establecen los mensajes de notificación que recibiran los observadores con cada actualización.
                Console.WriteLine("\nSaludos " + NombreEstudiante + " en la materia de " + MateriaCursada + " existen novedades.");
                Console.WriteLine("Se publicó 1 nueva actividad: " + novedades.Actividad);
            }
        }
    }
}
