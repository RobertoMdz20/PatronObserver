using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se procede a instanciar los objetos.
            Plataforma novedades = new Plataforma();

            //Se agregan observadores haciendo uso del metodo Añadir, y se establecen sus datos correspondientes.
            Estudiantes estudiante1 = new Estudiantes();
            estudiante1.MateriaCursada = "POO";
            estudiante1.NombreEstudiante = "Alex Robert Vélez Mendoza";
            novedades.Añadir(estudiante1);

            Estudiantes estudiante2 = new Estudiantes();
            estudiante2.MateriaCursada = "POO";
            estudiante2.NombreEstudiante = "Roberto Alejandro Mendoza Vélez";
            novedades.Añadir(estudiante2);

            //Se establecen los cambios de estado en el sujeto, en este caso las actividades.
            novedades.Actividad = "Trabajo autonomo 1";
            novedades.Actividad = "Actividad en clases 1";                  
        }
    }
}

