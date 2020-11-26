using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen_Final_Ejercicio222.Lógica;


namespace Examen_Final_Ejercicio222
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        //INICIALIZACION DE VARIABLES

        // String
        string evento;
        string rnd;
        string tiempoEntreLlegada;
        string proximaLlegada;
        string tiempoAtencion;
        string finProcesamiento;

        // Int, double
        double reloj;
        double acumCosto;
        int chequesProcesados;
        double maxEspera;

        // List, HashTable
        Hashtable chequesHashTable = new Hashtable();

        // Objetos de clases propias
        Maquina maquina1 = new Maquina("Libre", 0);
        Maquina maquina2 = new Maquina("Libre", 0);
        GeneradorAleatorios generador = new GeneradorAleatorios();


        public frmPrincipal()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
