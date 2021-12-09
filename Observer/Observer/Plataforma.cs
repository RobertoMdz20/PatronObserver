using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Plataforma : ISujeto
    {
        private List<IObservador> observadores;
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
        public void Añadir(IObservador obs)
        {
            observadores.Add(obs);
        }
        public void Notificar()
        {
            observadores.ForEach(o => { o.Actualizar(this); });
        }
        public void Eliminar(IObservador estudiante)
        {
            observadores.Remove((IObservador)observadores);
        }
    }
}
