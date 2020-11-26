using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final_Ejercicio222.Lógica
{
    class Cheque
    {
        private string estado;
        private double horaLlegada;

        public Cheque(string estado, double horaLlegada)
        {
            this.estado = estado;
            this.horaLlegada = horaLlegada;
        }
        public string Estado { get => estado; set => estado = value; }
        public double HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
    }
}
