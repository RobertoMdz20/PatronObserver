using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObservador
    {
        public void Actualizar(ISujeto sujeto);
    }
}