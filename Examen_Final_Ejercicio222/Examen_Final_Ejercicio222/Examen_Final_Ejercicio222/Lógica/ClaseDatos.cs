using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Final_Ejercicio222.Lógica
{
    public class ClaseDatos
    {
        double costo1;
        double costo2;
        double procesamiento1;
        double procesamiento2;
        double vidaUtil1;
        double vidaUtil2;
        int chequesAProcesar;
        double costoEspera;
        double desde;
        double hasta;
        double tiempo;
        double maxEspera;
        double chequesProcesados;
        double acumCosto;
        double cantIteraciones;

        public ClaseDatos()
        {
        }

        public double Costo1 { get => costo1; set => costo1 = value; }
        public double Costo2 { get => costo2; set => costo2 = value; }
        public double Procesamiento1 { get => procesamiento1; set => procesamiento1 = value; }
        public double Procesamiento2 { get => procesamiento2; set => procesamiento2 = value; }
        public double VidaUtil1 { get => vidaUtil1; set => vidaUtil1 = value; }
        public double VidaUtil2 { get => vidaUtil2; set => vidaUtil2 = value; }
        public int ChequesAProcesar { get => chequesAProcesar; set => chequesAProcesar = value; }
        public double CostoEspera { get => costoEspera; set => costoEspera = value; }
        public double Desde { get => desde; set => desde = value; }
        public double Hasta { get => hasta; set => hasta = value; }
        public double Tiempo { get => tiempo; set => tiempo = value; }
        public double MaxEspera { get => maxEspera; set => maxEspera = value; }
        public double ChequesProcesados { get => chequesProcesados; set => chequesProcesados = value; }
        public double AcumCosto { get => acumCosto; set => acumCosto = value; }
        public double CantIteraciones { get => cantIteraciones; set => cantIteraciones = value; }
    }
}
