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

namespace Examen_Final_Ejercicio222.Presentación
{
    public partial class Principal : MetroFramework.Forms.MetroForm
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
        double costo1;
        double costo2;
        double procesamiento1;
        double procesamiento2;
        double vidaUtil1;
        double vidaUtil2;
        int chequesAProcesar;
        double costoEspera;


        // List, HashTable
        Hashtable chequesHashTable = new Hashtable();

        // Objetos de clases propias
        Maquina maquina1 = new Maquina("Libre", 0);
        Maquina maquina2 = new Maquina("Libre", 0);
        GeneradorAleatorios generador = new GeneradorAleatorios();


        public Principal()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
           
        }

       
       

        private bool ValidarCampos()
        {
            bool ok = true;

            if (txtCosto1.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtCosto1, "Debe ingresar un valor");
            }
            else if (double.Parse(txtCosto1.Text) <= 0)
            {
                ok = false;
                error.SetError(txtCosto1, "Debe ingresar un valor mayor a 0");
            }

            if (txtCosto2.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtCosto2, "Debe ingresar un valor");
            }
            else if (double.Parse(txtCosto2.Text) <= 0)
            {
                ok = false;
                error.SetError(txtCosto2, "Debe ingresar un valor mayor a 0");
            }

            if (txtProcesamiento1.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtProcesamiento1, "Debe ingresar un valor");
            }
            else if (double.Parse(txtProcesamiento1.Text) <= 0)
            {
                ok = false;
                error.SetError(txtProcesamiento1, "Debe ingresar un valor mayor a 0");
            }

            if (txtProcesamiento2.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtProcesamiento2, "Debe ingresar un valor");
            }
            else if (double.Parse(txtProcesamiento2.Text) <= 0)
            {
                ok = false;
                error.SetError(txtProcesamiento2, "Debe ingresar un valor mayor a 0");
            }

            if (txtVidaUtil1.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtVidaUtil1, "Debe ingresar un valor");
            }
            else if (double.Parse(txtVidaUtil1.Text) <= 0)
            {
                ok = false;
                error.SetError(txtVidaUtil1, "Debe ingresar un valor mayor a 0");
            }

            if (txtVidaUtil2.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtVidaUtil2, "Debe ingresar un valor");
            }
            else if (double.Parse(txtVidaUtil2.Text) <= 0)
            {
                ok = false;
                error.SetError(txtVidaUtil2, "Debe ingresar un valor mayor a 0");
            }

            if (txtCostoEspera.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtCostoEspera, "Debe ingresar un valor");
            }
            else if (double.Parse(txtCostoEspera.Text) < 0)
            {
                ok = false;
                error.SetError(txtCostoEspera, "Debe ingresar un valor mayor a 0");
            }

            if (txtChequeProcesar.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtChequeProcesar, "Debe ingresar un valor");
            }
            else if (double.Parse(txtChequeProcesar.Text) <= 0)
            {
                ok = false;
                error.SetError(txtChequeProcesar, "Debe ingresar un valor mayor a 0");
            }
            return ok;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                costo1 = Convert.ToDouble(txtCosto1.Text);
                costo2 = Convert.ToDouble(txtCosto2.Text);
                procesamiento1 = Convert.ToDouble(txtProcesamiento1.Text);
                procesamiento2 = Convert.ToDouble(txtProcesamiento2.Text);
                vidaUtil1 = Convert.ToDouble(txtVidaUtil1.Text);
                vidaUtil2 = Convert.ToDouble(txtVidaUtil2.Text);
                chequesAProcesar = Convert.ToInt32(txtChequeProcesar.Text);
                costoEspera = Convert.ToDouble(txtCostoEspera.Text);


            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}

