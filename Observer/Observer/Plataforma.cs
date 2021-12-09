using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    //Se establece la herencia con la interfaz sujeto.
    class Plataforma : ISujeto
    {
        //Se crea la lista de los observadores.
        private List<IObservador> observadores;
        //Se declara la variable actvidad que será la que cambiará de estado.
        public string Actividad
        {
            get { return actividad_; }
            set { actividad_ = value; Notificar(); }
        }
        private string actividad_;
        public Plataforma()
        {
            observadores = new List<IObservador>();
        }
        public string actividad()
        {
            return this.Actividad;
        }
        //Se hace uso del metodo Añadir de la interfaz sujeto.
        public void Añadir(IObservador obs)
        {
            observadores.Add(obs);
        }
        //Se hace uso del metodo Notificar de la interfaz sujeto.
        public void Notificar()
        {
            observadores.ForEach(o => { o.Actualizar(this); });
        }
        //Se hace uso del metodo Eliminar de la interfaz sujeto.
        public void Eliminar(IObservador user)
        {
            observadores.Remove((IObservador)observadores);
        }
    }
}
