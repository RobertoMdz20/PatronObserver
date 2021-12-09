using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Estudiantes : IObservador
    {
        public string MateriaCursada { get; set; }
        public string NombreEstudiante { get; set; }

        public void Actualizar(ISujeto sujeto)
        {
            if (sujeto is Plataforma novedades)
            {
                Console.WriteLine("\nSaludos " + NombreEstudiante + " en la materia de " + MateriaCursada + " existen novedades.");
                Console.WriteLine("Se publicó 1 nueva actividad: " + novedades.Actividad);

            }
        }
    }
}
