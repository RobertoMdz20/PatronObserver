using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ISujeto
    {
        public void Añadir(IObservador observador);
        public void Eliminar(IObservador observador);
        public void Notificar();
    }
}