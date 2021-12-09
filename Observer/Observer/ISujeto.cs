using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    //Se establece la interfaz sujeto y se estalecen los metodos.
    interface ISujeto
    {
        //Metodo añadir que permitirá agregar un observador.
        public void Añadir(IObservador observador);
        //Metodo eliminar que permitirá eliminar un observador.
        public void Eliminar(IObservador observador);
        //Metodo notificar que avisa de los cambios que se hacen.
        public void Notificar(); 
    }
}