using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final_Ejercicio222.Lógica
{
    class Cheque
    {
        private int id;
        private string estado;
        private string horaLlegada;

        public Cheque()
        {

        }
        public Cheque(string estado, string horaLlegada)
        {
            this.estado = estado;
            this.horaLlegada = horaLlegada;
        }
        public string Estado { get => estado; set => estado = value; }
        public string HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public int Id { get => id; set => id = value; }
    }
}
