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
    public partial class Datos : MetroFramework.Forms.MetroForm
    {

        //INICIALIZACION DE VARIABLES
        ClaseDatos oDatos = new ClaseDatos();
        Simulacion1 frmSimulacion1;
        Simulacion2 frmSimulacion2;

        public Datos()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            datosHarcodeados();

        }


        private ClaseDatos grabar()
        {

            //INICIALIZACION

            //Datos de ingreso
            oDatos.Costo1 = Convert.ToDouble(txtCosto1.Text);
            oDatos.Costo2 = Convert.ToDouble(txtCosto2.Text);
            oDatos.Procesamiento1 = Convert.ToDouble(txtProcesamiento1.Text);
            oDatos.Procesamiento2 = Convert.ToDouble(txtProcesamiento2.Text);
            oDatos.VidaUtil1 = Convert.ToDouble(txtVidaUtil1.Text);
            oDatos.VidaUtil2 = Convert.ToDouble(txtVidaUtil2.Text);
            oDatos.ChequesAProcesar = Convert.ToInt32(txtChequeProcesar.Text);
            oDatos.CostoEspera = Convert.ToDouble(txtCostoEspera.Text);
            oDatos.Desde = Convert.ToDouble(txtDesde.Text);
            oDatos.Hasta = Convert.ToDouble(txtHasta.Text);
            oDatos.Tiempo = oDatos.VidaUtil1;
            return oDatos;

        }

        private void datosHarcodeados()
        {
            txtCosto1.Text = 40000.ToString();
            txtCosto2.Text = 30000.ToString();
            txtProcesamiento1.Text = 2.ToString();
            txtProcesamiento2.Text = 1000.ToString();
            txtVidaUtil1.Text = 400.ToString();
            txtVidaUtil2.Text = 400.ToString();
            txtChequeProcesar.Text = 3.ToString();
            txtCostoEspera.Text = 10.ToString();
            txtDesde.Text = 0.ToString();
            txtHasta.Text = 300.ToString();
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


            if (txtDesde.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtDesde, "Ingrese algún valor");
            }
            else if (double.Parse(txtDesde.Text) > double.Parse(txtVidaUtil1.Text) || double.Parse(txtDesde.Text) > double.Parse(txtVidaUtil2.Text))
            {
                ok = false;
                error.SetError(txtDesde, "El valor j debe ser menor o igual al tiempo X ingresado");
            }


            if (txtHasta.Text.Equals(""))
            {
                ok = false;
                error.SetError(txtHasta, "Ingrese algún valor");
            }
            else if (txtHasta.Text.Equals("0"))
            {
                ok = false;
                error.SetError(txtHasta, "Debe ingresar un valor mayor a 0");
            }
            return ok;
        }

        private void btnSimulacion1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                oDatos = grabar();
                frmSimulacion1 = new Simulacion1(oDatos, "sim1");                
                frmSimulacion1.Show();
            }
        }

        private void btnSimulacion2_Click(object sender, EventArgs e)
        {
            //if (ValidarCampos())
            //{
            //    oDatos = grabar();
            //    frmSimulacion2 = new Simulacion2(oDatos);
            //    frmSimulacion2.Show();
            //}
            if (ValidarCampos())
            {
                oDatos = grabar();
                frmSimulacion1 = new Simulacion1(oDatos, "sim2");                
                frmSimulacion1.Show();
            }
        }

        //private void BorrarMensajesError()
        //{
        //    errorNuloProvider.SetError(txtTiempo, "");
        //    errorNuloProvider.SetError(txtHasta, "");
        //    errorNuloProvider.SetError(txtMedia, "");
        //    errorNuloProvider.SetError(txtTiempoAtA, "");
        //    errorNuloProvider.SetError(txtTiempoAtB, "");
        //    errorNuloProvider.SetError(txtTiempoCocA, "");
        //    errorNuloProvider.SetError(txtTiempoCocB, "");
        //    errorNuloProvider.SetError(txtDesde, "");

        //    errorDatoIncorrectoProvider.SetError(txtTiempo, "");
        //    errorDatoIncorrectoProvider.SetError(txtHasta, "");
        //    errorDatoIncorrectoProvider.SetError(txtMedia, "");
        //    errorDatoIncorrectoProvider.SetError(txtTiempoAtA, "");
        //    errorDatoIncorrectoProvider.SetError(txtTiempoAtB, "");
        //    errorDatoIncorrectoProvider.SetError(txtTiempoCocA, "");
        //    errorDatoIncorrectoProvider.SetError(txtTiempoCocB, "");
        //    errorDatoIncorrectoProvider.SetError(txtDesde, "");
        //    errorDatoIncorrectoProvider.SetError(dgvProbDestino, "");
        //}

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab.Name == "resultados")
            {
                double acumCosto1 = frmSimulacion1.oResultados1.AcumCosto;
                label14.Text = acumCosto1.ToString();
                label15.Text = frmSimulacion1.oResultados1.MaxEspera.ToString();
                label16.Text= frmSimulacion1.oResultados1.ChequesProcesados.ToString();
                double acumCosto2 = frmSimulacion1.oResultados2.AcumCosto;
                label25.Text= acumCosto2.ToString();
                label23.Text= frmSimulacion1.oResultados2.MaxEspera.ToString();
                label20.Text= frmSimulacion1.oResultados2.ChequesProcesados.ToString();


                if (acumCosto1 < acumCosto2)
                {
                    label27.Text = "Al banco le conviene adquirir la maquina 1";
                }
                else if (acumCosto1 > acumCosto2)
                {
                    label27.Text = "Al banco le conviene adquirir la maquina 2";

                }
                else
                {
                    label27.Text = "El Banco podrá adquirir cualquiera de las dos maquinas";

                }
            }
        }
    }
}
