using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Plataforma novedades = new Plataforma();

            Estudiantes estudiante1 = new Estudiantes();
            estudiante1.MateriaCursada = "POO";
            estudiante1.NombreEstudiante = "Alex Robert Vélez Mendoza";
            novedades.Añadir(estudiante1);

            Estudiantes estudiante2 = new Estudiantes();
            estudiante2.MateriaCursada = "POO";
            estudiante2.NombreEstudiante = "Roberto Alejandro Mendoza Vélez";
            novedades.Añadir(estudiante2);

            novedades.Actividad = "Trabajo autonomo 1";
            novedades.Actividad = "Actividad en clases 1";                  
        }
    }
}

