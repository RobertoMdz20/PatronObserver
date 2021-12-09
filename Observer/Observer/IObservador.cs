using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    //Se establece la interfaz observador y se estale el metodo.
    interface IObservador
    {
        //Metodo actualizar que realizará la actualización según los cambios del sujeto.
        public void Actualizar(ISujeto sujeto);
    }
}