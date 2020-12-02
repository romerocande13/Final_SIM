namespace Examen_Final_Ejercicio222.Presentación
{
    partial class Simulacion1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSimulacion1 = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempoEntreLlegadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProxLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTiempoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinProcesamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCola = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcumCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantCheques = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaxEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblMaquina1 = new System.Windows.Forms.Label();
            this.btnSimular = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSimulacion1
            // 
            this.dgvSimulacion1.AllowUserToAddRows = false;
            this.dgvSimulacion1.AllowUserToDeleteRows = false;
            this.dgvSimulacion1.AllowUserToResizeRows = false;
            this.dgvSimulacion1.BackgroundColor = System.Drawing.Color.White;
            this.dgvSimulacion1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSimulacion1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSimulacion1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSimulacion1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSimulacion1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacion1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.colEvento,
            this.colReloj,
            this.colRND,
            this.colTiempoEntreLlegadas,
            this.colProxLlegada,
            this.colTiempoAtencion,
            this.colFinProcesamiento,
            this.colEstadoMaquina,
            this.colCola,
            this.colAcumCosto,
            this.colCantCheques,
            this.colMaxEspera});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSimulacion1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSimulacion1.EnableHeadersVisualStyles = false;
            this.dgvSimulacion1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSimulacion1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSimulacion1.Location = new System.Drawing.Point(24, 96);
            this.dgvSimulacion1.Name = "dgvSimulacion1";
            this.dgvSimulacion1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSimulacion1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSimulacion1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSimulacion1.RowTemplate.Height = 24;
            this.dgvSimulacion1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSimulacion1.Size = new System.Drawing.Size(1800, 652);
            this.dgvSimulacion1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Nro Iteracion";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // colEvento
            // 
            this.colEvento.HeaderText = "Evento";
            this.colEvento.Name = "colEvento";
            // 
            // colReloj
            // 
            this.colReloj.HeaderText = "Reloj";
            this.colReloj.Name = "colReloj";
            // 
            // colRND
            // 
            this.colRND.HeaderText = "RND";
            this.colRND.Name = "colRND";
            // 
            // colTiempoEntreLlegadas
            // 
            this.colTiempoEntreLlegadas.HeaderText = "Tiempo Entre Llegadas";
            this.colTiempoEntreLlegadas.Name = "colTiempoEntreLlegadas";
            // 
            // colProxLlegada
            // 
            this.colProxLlegada.HeaderText = "Proxima Llegada";
            this.colProxLlegada.Name = "colProxLlegada";
            // 
            // colTiempoAtencion
            // 
            this.colTiempoAtencion.HeaderText = "Tiempo De Atencion";
            this.colTiempoAtencion.Name = "colTiempoAtencion";
            // 
            // colFinProcesamiento
            // 
            this.colFinProcesamiento.HeaderText = "Fin Procesamiento";
            this.colFinProcesamiento.Name = "colFinProcesamiento";
            // 
            // colEstadoMaquina
            // 
            this.colEstadoMaquina.HeaderText = "Estado maquina";
            this.colEstadoMaquina.Name = "colEstadoMaquina";
            // 
            // colCola
            // 
            this.colCola.HeaderText = "Cola";
            this.colCola.Name = "colCola";
            // 
            // colAcumCosto
            // 
            this.colAcumCosto.HeaderText = "Acum Costo";
            this.colAcumCosto.Name = "colAcumCosto";
            // 
            // colCantCheques
            // 
            this.colCantCheques.HeaderText = "Cant Cheques";
            this.colCantCheques.Name = "colCantCheques";
            // 
            // colMaxEspera
            // 
            this.colMaxEspera.HeaderText = "Max Espera";
            this.colMaxEspera.Name = "colMaxEspera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "SIMULACION CON MAQUINA 1";
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.label7);
            this.metroPanel1.Controls.Add(this.label6);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.lblMaquina1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 783);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1608, 151);
            this.metroPanel1.TabIndex = 51;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblMaquina1
            // 
            this.lblMaquina1.AutoSize = true;
            this.lblMaquina1.BackColor = System.Drawing.Color.Transparent;
            this.lblMaquina1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaquina1.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.lblMaquina1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.lblMaquina1.Location = new System.Drawing.Point(12, 13);
            this.lblMaquina1.Name = "lblMaquina1";
            this.lblMaquina1.Size = new System.Drawing.Size(277, 33);
            this.lblMaquina1.TabIndex = 27;
            this.lblMaquina1.Text = "DATOS DE RESUMEN";
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.btnSimular.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSimular.ForeColor = System.Drawing.Color.White;
            this.btnSimular.Location = new System.Drawing.Point(1685, 830);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(139, 51);
            this.btnSimular.TabIndex = 54;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSimular.UseCustomBackColor = true;
            this.btnSimular.UseCustomForeColor = true;
            this.btnSimular.UseSelectable = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(825, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(1036, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 23);
            this.label4.TabIndex = 37;
            this.label4.Text = "CANTIDAD DE CHEQUES PROCESADOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(521, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "TIEMPO MAXIMO DE ESPERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "COSTO ACUMULADO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1437, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "-";
            // 
            // Simulacion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 1003);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgvSimulacion1);
            this.Controls.Add(this.label1);
            this.Name = "Simulacion1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroGrid dgvSimulacion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempoEntreLlegadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProxLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTiempoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinProcesamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAcumCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantCheques;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaxEspera;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label lblMaquina1;
        private MetroFramework.Controls.MetroButton btnSimular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}