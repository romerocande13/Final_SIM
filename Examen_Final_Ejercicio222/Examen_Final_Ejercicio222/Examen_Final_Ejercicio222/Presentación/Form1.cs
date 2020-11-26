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
            if(ValidarCampos())
            {

            }
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtCosto1.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtCosto1, "Debe ingresar un valor");
            }
            if (txtCosto2.Text.Equals(""))

            {
                ok = false;
                error.SetError(txtCosto2, "Debe ingresar un valor");
            }
            if (txtProcesamiento1.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtProcesamiento1, "Debe ingresar un valor");
            }

            if (txtProcesamiento2.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtProcesamiento2, "Debe ingresar un valor");
            }

            if(txtVidaUtil1.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtVidaUtil1, "Debe ingresar un valor");
            }
            if (txtVidaUtil2.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtVidaUtil2, "Debe ingresar un valor");
            }
            if (txtCostoEspera.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtCostoEspera, "Debe ingresar un valor");
            }
            if (txtChequeProcesar.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtChequeProcesar, "Debe ingresar un valor");
            }
            if (double.Parse(txtCosto1.Text) <= 0)
            {
                ok = false;
                error.SetError(txtCosto1, "Debe ingresar un valor mayor a 0");
            }
            if (double.Parse(txtCosto2.Text) <= 0)
            {
                ok = false;
                error.SetError(txtCosto2, "Debe ingresar un valor mayor a 0");
            }
            if (double.Parse(txtProcesamiento1.Text) <= 0 )
            {
                ok = false;
                error.SetError(txtProcesamiento1, "Debe ingresar un valor mayor a 0");
            }
            if (double.Parse(txtProcesamiento2.Text) <= 0)
            {
                ok = false;
                error.SetError(txtProcesamiento2, "Debe ingresar un valor mayor a 0");
            }
            if (double.Parse(txtVidaUtil1.Text) <= 0)
            {
                ok = false;
                error.SetError(txtVidaUtil1, "Debe ingresar un valor mayor a 0");
            }
            if (double.Parse(txtVidaUtil2.Text) <= 0)
            {
                ok = false;
                error.SetError(txtVidaUtil2, "Debe ingresar un valor mayor a 0");
            }
            if (double.Parse(txtCostoEspera.Text) < 0)
            {
                ok = false;
                error.SetError(txtCostoEspera, "Debe ingresar un valor mayor a 0");
            }
            if (double.Parse(txtChequeProcesar.Text) <= 0)
            {
                ok = false;
                error.SetError(txtChequeProcesar, "Debe ingresar un valor mayor a 0");
            }
            return ok;
            
        }
    }
}
