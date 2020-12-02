using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final_Ejercicio222.Lógica
{
    class Maquina
    {
        private string estado;
        private int countCola;
        private List<Cheque> cola = new List<Cheque>();

        public Maquina(string estado, int countCola)
        {
            this.estado = estado;
            this.countCola = countCola;
        }

        public string Estado { get => estado; set => estado = value; }
        public int Cola { get => countCola; set => countCola = value; }
        internal List<Cheque> listaDeCola { get => cola; set => cola = value; }
    }
}
