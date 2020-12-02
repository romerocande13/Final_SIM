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
    public partial class Simulacion1 : MetroFramework.Forms.MetroForm
    {
        //ENUM 
        public enum FormMode
        {
            sim1,
            sim2
        }
        private FormMode formMode;
        public FormMode FormMode1 { get => formMode; set => formMode = value; }
        


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
        int nroIteracion;
        int cantIteraciones;
        double desde;
        double hasta;
        double tiempo;
        int cantCheques;
        double media;


        // List, HashTable
        Hashtable chequesHashTable = new Hashtable();
        Cheque chequeActual= new Cheque();
        

        // Objetos de clases propias
        Maquina maquina1 = new Maquina("Libre", 0);
        Maquina maquina2 = new Maquina("Libre", 0);
        GeneradorAleatorios generador = new GeneradorAleatorios();
        public ClaseDatos oResultados1 = new ClaseDatos();
        MetroFramework.Controls.MetroGrid dgvSIM;
        public ClaseDatos oResultados2 = new ClaseDatos();



        // Constructor
        public Simulacion1(ClaseDatos oDatos, string modo)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StyleManager = metroStyleManager1;
            this.costo1 = oDatos.Costo1;
            this.costo2 = oDatos.Costo2;
            this.procesamiento1 = oDatos.Procesamiento1;
            this.procesamiento2 = oDatos.Procesamiento2;
            this.vidaUtil1 = oDatos.VidaUtil1;
            this.vidaUtil2 = oDatos.VidaUtil2;
            this.chequesAProcesar = oDatos.ChequesAProcesar;
            this.costoEspera = oDatos.CostoEspera;
            this.desde = oDatos.Desde;
            this.hasta = oDatos.Hasta;
            this.tiempo = oDatos.Tiempo;
            if (modo.Equals("sim1"))
            {
                this.FormMode1 = FormMode.sim1;
            }
            else if (modo.Equals("sim2"))
            {
                this.FormMode1 = FormMode.sim2;
            }

        }

       

        // SIMULACION MAQUINA 1 ...

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (formMode == FormMode.sim1)
            {
                dgvSIM = dgvSimulacion1;
                this.tiempo = vidaUtil1;
            }
            else if (formMode == FormMode.sim2)
            {
                dgvSIM = dgvSimulacion2;
                this.tiempo = vidaUtil2;

            }

            // PRIMERA ITERACION

            nroIteracion = 0;
            cantIteraciones = 0;
            evento = "Inicialización";
            reloj = 0;

            media = Convert.ToDouble(1)/Convert.ToDouble(chequesAProcesar); // Aca se define la media
            //media = Convert.ToDouble(chequesAProcesar); // Aca se define la media
            rnd = generador.generadorUniforme().ToString();
            tiempoEntreLlegada = generador.generadorExpNeg(media, double.Parse(rnd)).ToString();
            proximaLlegada = (double.Parse(tiempoEntreLlegada) + reloj).ToString();

            tiempoAtencion = "";
            finProcesamiento = "";

            maquina1.Estado = "Libre";
            maquina1.Cola = 0;

            acumCosto = costo1;
            chequesProcesados = 0;
            maxEspera = 0;
            cantCheques = 0;

            dgvSIM.Rows.Add(
                nroIteracion,
                evento,
                reloj,
                rnd,
                tiempoEntreLlegada,
                proximaLlegada,
                tiempoAtencion,
                finProcesamiento,
                maquina1.Estado,
                maquina1.Cola,
                acumCosto,
                chequesProcesados,
                maxEspera
                );


            
            while(reloj <= tiempo)
            {
                // Se incrementa el nro de iteracion 
                nroIteracion++;

                // Se utiliza un contador secundario para los casos de "desde" y "hasta"
                if (reloj >= desde)
                {
                    cantIteraciones++;
                }

                // Limpieza de las variables 
                rnd = "";
                tiempoEntreLlegada = "";
                tiempoAtencion = "";


                // Variables para calcular proximo evento
                Dictionary<string, Double> aComparar = new Dictionary<string, Double>();

                List<string> eventosList = new List<string>();
                eventosList.Add("Llegada_Cheque");
                eventosList.Add("Fin_Procesamiento");

                List<string> columnasAComparar = new List<string>();
                columnasAComparar.Add(proximaLlegada);
                columnasAComparar.Add(finProcesamiento);

                // Se recorre el array con los valores de las columnas que se corresponden con los proximos eventos
                for (int indCol = 0; indCol < columnasAComparar.Count(); indCol++)
                {
                    if (columnasAComparar.ElementAt(indCol) != "")
                    {
                        string key = indCol.ToString();

                        double value = double.Parse(columnasAComparar.ElementAt(indCol));

                        aComparar.Add(key, value);
                    }
                }

                // Se obtiene el minimo valor del diccionario
                var min = aComparar.Min(kvp => kvp.Value);

                int indice = columnasAComparar.IndexOf(min.ToString());


                // Asignacion de evento....
                evento = eventosList[indice];




                // OPERACION CON LOS EVENTOS...

                // Si el evento es llegada cheque
                if (evento.Equals(eventosList[0]))
                {
                    llegadaCheque(media);
                }

                // Si el evento es fin procesamiento

                else if (evento.Equals(eventosList[1]))
                {
                    finalizacionProcesamiento();
                }




                

                if ((reloj >= desde && cantIteraciones <= hasta) || reloj >= tiempo)
                {
                    string[] fila = cargarFila();

                    dgvSIM.Rows.Add(fila);

                    //Para cargar los estados de los cheques correspondientes...
                    foreach (DictionaryEntry item in chequesHashTable)
                    {
                        Cheque aux = (Cheque)item.Value;

                        if (dgvSIM.Columns["colCheque" + aux.Id.ToString()] != null)
                        {
                            if (!(aux.Estado.Equals("")))
                            {
                                dgvSIM.Rows[dgvSIM.Rows.Count - 1].Cells["colCheque" + aux.Id.ToString()].Value = aux.Estado;
                                dgvSIM.Rows[dgvSIM.Rows.Count - 1].Cells["colHoraLlegada" + aux.Id.ToString().ToString()].Value = aux.HoraLlegada;
                            }
                        }
                    }
                }


            }

            if (formMode == FormMode.sim1)
            {
                //DATOS DE RESUMEN 1

                label5.Text = acumCosto.ToString();
                label6.Text = maxEspera.ToString();
                label7.Text = chequesProcesados.ToString();
                oResultados1.AcumCosto = acumCosto;
                oResultados1.MaxEspera = maxEspera;
                oResultados1.ChequesProcesados = chequesProcesados;
            }
            else if (formMode == FormMode.sim2)
            {
                //DATOS DE RESUMEN 2

                label10.Text = acumCosto.ToString();
                label9.Text = maxEspera.ToString();
                label8.Text = chequesProcesados.ToString();
                oResultados2.AcumCosto = acumCosto;
                oResultados2.MaxEspera = maxEspera;
                oResultados2.ChequesProcesados = chequesProcesados;

            }
            limpiarVariables();
        }



        // METODOS DE EVENTOS

        private void llegadaCheque(double media)
        {
            // Se crea un nuevo cheque, incrementando el contador
            cantCheques++;

            Cheque oCheque = new Cheque();

            oCheque.Id = cantCheques;

            //Con respecto a la tabla...
            reloj = double.Parse(proximaLlegada);

            generarProximaLlegada(media);

            //Si el estado de al maquina1 era LIBRE
            if (maquina1.Estado.Equals("Libre"))
            {
                generarFinProcesamiento(procesamiento1);

                maquina1.Estado = "Ocupada";
                oCheque.Estado = "Siendo Procesado";
                oCheque.HoraLlegada = "";
                chequeActual = oCheque;                
            }

            //Si el estado de al maquina1 era OCUPADA
            else if (maquina1.Estado.Equals("Ocupada"))
            {   
                maquina1.Cola++;
                oCheque.Estado = "En Espera";
                oCheque.HoraLlegada = reloj.ToString();
                maquina1.listaDeCola.Add(oCheque);
            }

           

            if (reloj >= desde && cantIteraciones <= hasta)
            {
                //Se agrega el cliente en la hashtable
                chequesHashTable.Add(oCheque.Id, oCheque);

                //Se agrega la columna de cheque..
                agregarColumnaCheque(oCheque);
            }
        }

        private void finalizacionProcesamiento()
        {
            //Operacion del resto de las columnas...
            reloj = double.Parse(finProcesamiento);

            if (chequeActual == null)
            {
                MessageBox.Show("'Cheque Actual' tiene valor null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (chequeActual.Estado.Equals("Siendo Procesado"))
            {
                actualizarEstadoCheque();                
            }


            //Se limpia el respectivo Fin Procesamiento            
            tiempoAtencion = "";
            finProcesamiento= "";
            chequesProcesados ++;

            if (maquina1.Cola > 0)
            {
                maquina1.Estado = "Ocupada";

                Cheque oCheque = maquina1.listaDeCola.ElementAt(0);

                maquina1.Cola--;                
                
                //El cheque pasa de estar esperando a ser procesado
                if (oCheque.Estado.Equals("En Espera"))
                {
                    oCheque.Estado = "Siendo Procesado";
                    calcularTiempoEspera(oCheque);
                    generarFinProcesamiento(procesamiento1);
                    oCheque.HoraLlegada = "";

                    if (reloj >= desde && cantIteraciones <= hasta)
                    {
                        //Buscamos el respectivo cheque en la hash y cambiamos su estado..
                        chequesHashTable[oCheque.Id] = oCheque;
                    }

                    //Seteamos el cheque actual
                    chequeActual = oCheque;

                    //Lo eliminamos de la cola la maquina
                    maquina1.listaDeCola.RemoveAt(0);
                }

            }
            else if (maquina1.Cola == 0)
            {
                maquina1.Estado = "Libre";
                chequeActual = null;

            }

        }





        // GENERADORES PARA EVENTOS

        private void generarProximaLlegada(double media)
        {
            rnd = generador.generadorUniforme().ToString();

            tiempoEntreLlegada = generador.generadorExpNeg(media, double.Parse(rnd)).ToString();

            proximaLlegada = (double.Parse(tiempoEntreLlegada) + reloj).ToString();
        }

        private void generarFinProcesamiento(double procesamiento)
        {  
            tiempoAtencion = (1/procesamiento1).ToString();
            finProcesamiento = (double.Parse(tiempoAtencion) + reloj).ToString();
        }



        // METODOS PARA ESTADISTICAS

        private void calcularTiempoEspera(Cheque oCheque)
        {
            //double espera = Math.Round(oCheque.HoraLlegada - reloj,2);
            if (!oCheque.HoraLlegada.Equals(""))
            {
                double espera = reloj - Convert.ToDouble(oCheque.HoraLlegada);
                double costoPorEspera = espera * 10;
                acumCosto = acumCosto + costoPorEspera;
                if(espera > maxEspera)
                {
                    maxEspera = espera;
                }
            }
           
        }








        // METODOS DE OPERACIONES CON COLUMNAS
        private void agregarColumnaCheque(Cheque oCheque)
        {
            DataGridViewColumn columna1 = new DataGridViewColumn();

            columna1.Name = "colCheque" + oCheque.Id.ToString();
            columna1.HeaderText = "Estado cheque " + oCheque.Id.ToString();
            columna1.CellTemplate = new DataGridViewTextBoxCell();
            columna1.FillWeight = 10;
            columna1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvSIM.Columns.Add(columna1);

            DataGridViewColumn columna2 = new DataGridViewColumn();

            columna2.Name = "colHoraLlegada" + oCheque.Id.ToString();
            columna2.HeaderText = "Hora Llegada " + oCheque.Id.ToString();
            columna2.CellTemplate = new DataGridViewTextBoxCell();
            columna2.FillWeight = 10;
            columna2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            dgvSIM.Columns.Add(columna2);
        }

        private void actualizarEstadoCheque()
        {
            if (reloj >= desde && cantIteraciones <= hasta)
            {
                int idAux = chequeActual.Id;

                Cheque chequeAux = (Cheque)chequesHashTable[idAux];

                if (chequeAux != null)
                {
                    chequeAux.Estado = "";
                    chequeAux.HoraLlegada = "";
                    chequeActual = null;
                    chequesHashTable[idAux] = chequeAux;
                }
            }
        }


        private string[] cargarFila()
        {
            string eventorow = "";

            if (evento.Equals("Llegada_Cheque"))
            {
                eventorow = evento + "_" + cantCheques.ToString();
            }
            else
            {
                eventorow = evento;
            }

            string[] arrayAux = { nroIteracion.ToString(),
                eventorow,
                reloj.ToString(),
                rnd,
                tiempoEntreLlegada,
                proximaLlegada,
                tiempoAtencion,
                finProcesamiento,
                maquina1.Estado,
                maquina1.Cola.ToString(),
                acumCosto.ToString(),
                chequesProcesados.ToString(),
                maxEspera.ToString()

            };       
            return arrayAux;
        }

        private void btnVerSim2_Click(object sender, EventArgs e)
        {
            this.FormMode1 = FormMode.sim2;
            btnVerSim2.Visible = false;
            btnVerSim1.Visible = true;
            label1.Text = "SIMULACION CON MAQUINA 2";
            dgvSimulacion2.Visible = true;
            dgvSimulacion1.Visible = false;
            metroPanel1.Visible = false;
            metroPanel2.Visible = true;


        }
        private void btnVerSim1_Click(object sender, EventArgs e)
        {
            this.FormMode1 = FormMode.sim1;
            btnVerSim1.Visible = false;            
            btnVerSim2.Visible = true;
            label1.Text = "SIMULACION CON MAQUINA 1";
            dgvSimulacion1.Visible = true;
            dgvSimulacion2.Visible = false;
            metroPanel2.Visible = false;
            metroPanel1.Visible = true;

        }
        private void limpiarVariables()
        {
            evento = "";
            rnd = "";
            tiempoEntreLlegada = "";
            proximaLlegada = "";
            tiempoAtencion = "";
            finProcesamiento = "";
            reloj=0.0;
            acumCosto = 0.0;
            chequesProcesados = 0;
            maxEspera = 0.0;
            nroIteracion = 0;
            cantIteraciones = 0;
            cantCheques = 0;
            media = 0.0;
            chequesHashTable = new Hashtable();
            chequeActual = new Cheque();
            maquina1 = new Maquina("Libre", 0);
            maquina2 = new Maquina("Libre", 0);          
              
        
        }

    }
}

