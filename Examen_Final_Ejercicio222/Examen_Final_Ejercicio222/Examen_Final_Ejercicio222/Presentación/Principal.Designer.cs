namespace Examen_Final_Ejercicio222.Presentación
{
    partial class Principal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.datos = new System.Windows.Forms.TabPage();
            this.txtCostoEspera = new MetroFramework.Controls.MetroTextBox();
            this.lblMaquina1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMaquina2 = new System.Windows.Forms.Label();
            this.txtChequeProcesar = new MetroFramework.Controls.MetroTextBox();
            this.txtCosto1 = new MetroFramework.Controls.MetroTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVidaUtil2 = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProcesamiento2 = new MetroFramework.Controls.MetroTextBox();
            this.txtProcesamiento1 = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVidaUtil1 = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCosto2 = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.simulacion1 = new System.Windows.Forms.TabPage();
            this.simulacion2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnGrabar = new MetroFramework.Controls.MetroButton();
            this.btnBorrar = new MetroFramework.Controls.MetroButton();
            this.tabControl1.SuspendLayout();
            this.datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.datos);
            this.tabControl1.Controls.Add(this.simulacion1);
            this.tabControl1.Controls.Add(this.simulacion2);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(20, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 382);
            this.tabControl1.TabIndex = 0;
            // 
            // datos
            // 
            this.datos.Controls.Add(this.btnBorrar);
            this.datos.Controls.Add(this.btnGrabar);
            this.datos.Controls.Add(this.txtCostoEspera);
            this.datos.Controls.Add(this.lblMaquina1);
            this.datos.Controls.Add(this.label9);
            this.datos.Controls.Add(this.lblMaquina2);
            this.datos.Controls.Add(this.txtChequeProcesar);
            this.datos.Controls.Add(this.txtCosto1);
            this.datos.Controls.Add(this.label10);
            this.datos.Controls.Add(this.label2);
            this.datos.Controls.Add(this.label11);
            this.datos.Controls.Add(this.label4);
            this.datos.Controls.Add(this.txtVidaUtil2);
            this.datos.Controls.Add(this.label6);
            this.datos.Controls.Add(this.txtProcesamiento2);
            this.datos.Controls.Add(this.txtProcesamiento1);
            this.datos.Controls.Add(this.label3);
            this.datos.Controls.Add(this.txtVidaUtil1);
            this.datos.Controls.Add(this.label5);
            this.datos.Controls.Add(this.txtCosto2);
            this.datos.Controls.Add(this.label7);
            this.datos.Location = new System.Drawing.Point(4, 32);
            this.datos.Name = "datos";
            this.datos.Padding = new System.Windows.Forms.Padding(3);
            this.datos.Size = new System.Drawing.Size(1087, 346);
            this.datos.TabIndex = 0;
            this.datos.Text = "DATOS";
            this.datos.UseVisualStyleBackColor = true;
            // 
            // txtCostoEspera
            // 
            // 
            // 
            // 
            this.txtCostoEspera.CustomButton.Image = null;
            this.txtCostoEspera.CustomButton.Location = new System.Drawing.Point(79, 2);
            this.txtCostoEspera.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtCostoEspera.CustomButton.Name = "";
            this.txtCostoEspera.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCostoEspera.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCostoEspera.CustomButton.TabIndex = 1;
            this.txtCostoEspera.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCostoEspera.CustomButton.UseSelectable = true;
            this.txtCostoEspera.CustomButton.Visible = false;
            this.txtCostoEspera.Lines = new string[0];
            this.txtCostoEspera.Location = new System.Drawing.Point(889, 148);
            this.txtCostoEspera.MaxLength = 32767;
            this.txtCostoEspera.Name = "txtCostoEspera";
            this.txtCostoEspera.PasswordChar = '\0';
            this.txtCostoEspera.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCostoEspera.SelectedText = "";
            this.txtCostoEspera.SelectionLength = 0;
            this.txtCostoEspera.SelectionStart = 0;
            this.txtCostoEspera.ShortcutsEnabled = true;
            this.txtCostoEspera.Size = new System.Drawing.Size(107, 30);
            this.txtCostoEspera.TabIndex = 44;
            this.txtCostoEspera.UseSelectable = true;
            this.txtCostoEspera.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCostoEspera.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMaquina1
            // 
            this.lblMaquina1.AutoSize = true;
            this.lblMaquina1.BackColor = System.Drawing.Color.Transparent;
            this.lblMaquina1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaquina1.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.lblMaquina1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.lblMaquina1.Location = new System.Drawing.Point(28, 33);
            this.lblMaquina1.Name = "lblMaquina1";
            this.lblMaquina1.Size = new System.Drawing.Size(156, 33);
            this.lblMaquina1.TabIndex = 26;
            this.lblMaquina1.Text = "MAQUINA 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(742, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "Costo espera";
            // 
            // lblMaquina2
            // 
            this.lblMaquina2.AutoSize = true;
            this.lblMaquina2.BackColor = System.Drawing.Color.Transparent;
            this.lblMaquina2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaquina2.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.lblMaquina2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.lblMaquina2.Location = new System.Drawing.Point(385, 33);
            this.lblMaquina2.Name = "lblMaquina2";
            this.lblMaquina2.Size = new System.Drawing.Size(161, 33);
            this.lblMaquina2.TabIndex = 27;
            this.lblMaquina2.Text = "MAQUINA 2";
            // 
            // txtChequeProcesar
            // 
            // 
            // 
            // 
            this.txtChequeProcesar.CustomButton.Image = null;
            this.txtChequeProcesar.CustomButton.Location = new System.Drawing.Point(102, 2);
            this.txtChequeProcesar.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtChequeProcesar.CustomButton.Name = "";
            this.txtChequeProcesar.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtChequeProcesar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtChequeProcesar.CustomButton.TabIndex = 1;
            this.txtChequeProcesar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtChequeProcesar.CustomButton.UseSelectable = true;
            this.txtChequeProcesar.CustomButton.Visible = false;
            this.txtChequeProcesar.Lines = new string[0];
            this.txtChequeProcesar.Location = new System.Drawing.Point(866, 89);
            this.txtChequeProcesar.MaxLength = 32767;
            this.txtChequeProcesar.Name = "txtChequeProcesar";
            this.txtChequeProcesar.PasswordChar = '\0';
            this.txtChequeProcesar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChequeProcesar.SelectedText = "";
            this.txtChequeProcesar.SelectionLength = 0;
            this.txtChequeProcesar.SelectionStart = 0;
            this.txtChequeProcesar.ShortcutsEnabled = true;
            this.txtChequeProcesar.Size = new System.Drawing.Size(130, 30);
            this.txtChequeProcesar.TabIndex = 41;
            this.txtChequeProcesar.UseSelectable = true;
            this.txtChequeProcesar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtChequeProcesar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCosto1
            // 
            // 
            // 
            // 
            this.txtCosto1.CustomButton.Image = null;
            this.txtCosto1.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.txtCosto1.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtCosto1.CustomButton.Name = "";
            this.txtCosto1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCosto1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCosto1.CustomButton.TabIndex = 1;
            this.txtCosto1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCosto1.CustomButton.UseSelectable = true;
            this.txtCosto1.CustomButton.Visible = false;
            this.txtCosto1.Lines = new string[0];
            this.txtCosto1.Location = new System.Drawing.Point(104, 89);
            this.txtCosto1.MaxLength = 32767;
            this.txtCosto1.Name = "txtCosto1";
            this.txtCosto1.PasswordChar = '\0';
            this.txtCosto1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCosto1.SelectedText = "";
            this.txtCosto1.SelectionLength = 0;
            this.txtCosto1.SelectionStart = 0;
            this.txtCosto1.ShortcutsEnabled = true;
            this.txtCosto1.Size = new System.Drawing.Size(180, 30);
            this.txtCosto1.TabIndex = 28;
            this.txtCosto1.UseSelectable = true;
            this.txtCosto1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCosto1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(742, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 46);
            this.label10.TabIndex = 42;
            this.label10.Text = "Cheques \r\na procesar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Costo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Montserrat SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.label11.Location = new System.Drawing.Point(738, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 33);
            this.label11.TabIndex = 40;
            this.label11.Text = "BANCO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(30, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Procesamiento";
            // 
            // txtVidaUtil2
            // 
            // 
            // 
            // 
            this.txtVidaUtil2.CustomButton.Image = null;
            this.txtVidaUtil2.CustomButton.Location = new System.Drawing.Point(129, 2);
            this.txtVidaUtil2.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtVidaUtil2.CustomButton.Name = "";
            this.txtVidaUtil2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtVidaUtil2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVidaUtil2.CustomButton.TabIndex = 1;
            this.txtVidaUtil2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVidaUtil2.CustomButton.UseSelectable = true;
            this.txtVidaUtil2.CustomButton.Visible = false;
            this.txtVidaUtil2.Lines = new string[0];
            this.txtVidaUtil2.Location = new System.Drawing.Point(486, 207);
            this.txtVidaUtil2.MaxLength = 32767;
            this.txtVidaUtil2.Name = "txtVidaUtil2";
            this.txtVidaUtil2.PasswordChar = '\0';
            this.txtVidaUtil2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVidaUtil2.SelectedText = "";
            this.txtVidaUtil2.SelectionLength = 0;
            this.txtVidaUtil2.SelectionStart = 0;
            this.txtVidaUtil2.ShortcutsEnabled = true;
            this.txtVidaUtil2.Size = new System.Drawing.Size(157, 30);
            this.txtVidaUtil2.TabIndex = 39;
            this.txtVidaUtil2.UseSelectable = true;
            this.txtVidaUtil2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVidaUtil2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Location = new System.Drawing.Point(30, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Vida util";
            // 
            // txtProcesamiento2
            // 
            // 
            // 
            // 
            this.txtProcesamiento2.CustomButton.Image = null;
            this.txtProcesamiento2.CustomButton.Location = new System.Drawing.Point(79, 2);
            this.txtProcesamiento2.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtProcesamiento2.CustomButton.Name = "";
            this.txtProcesamiento2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProcesamiento2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProcesamiento2.CustomButton.TabIndex = 1;
            this.txtProcesamiento2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProcesamiento2.CustomButton.UseSelectable = true;
            this.txtProcesamiento2.CustomButton.Visible = false;
            this.txtProcesamiento2.Lines = new string[0];
            this.txtProcesamiento2.Location = new System.Drawing.Point(536, 148);
            this.txtProcesamiento2.MaxLength = 32767;
            this.txtProcesamiento2.Name = "txtProcesamiento2";
            this.txtProcesamiento2.PasswordChar = '\0';
            this.txtProcesamiento2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProcesamiento2.SelectedText = "";
            this.txtProcesamiento2.SelectionLength = 0;
            this.txtProcesamiento2.SelectionStart = 0;
            this.txtProcesamiento2.ShortcutsEnabled = true;
            this.txtProcesamiento2.Size = new System.Drawing.Size(107, 30);
            this.txtProcesamiento2.TabIndex = 38;
            this.txtProcesamiento2.UseSelectable = true;
            this.txtProcesamiento2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProcesamiento2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtProcesamiento1
            // 
            // 
            // 
            // 
            this.txtProcesamiento1.CustomButton.Image = null;
            this.txtProcesamiento1.CustomButton.Location = new System.Drawing.Point(79, 2);
            this.txtProcesamiento1.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtProcesamiento1.CustomButton.Name = "";
            this.txtProcesamiento1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProcesamiento1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProcesamiento1.CustomButton.TabIndex = 1;
            this.txtProcesamiento1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProcesamiento1.CustomButton.UseSelectable = true;
            this.txtProcesamiento1.CustomButton.Visible = false;
            this.txtProcesamiento1.Lines = new string[0];
            this.txtProcesamiento1.Location = new System.Drawing.Point(177, 148);
            this.txtProcesamiento1.MaxLength = 32767;
            this.txtProcesamiento1.Name = "txtProcesamiento1";
            this.txtProcesamiento1.PasswordChar = '\0';
            this.txtProcesamiento1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProcesamiento1.SelectedText = "";
            this.txtProcesamiento1.SelectionLength = 0;
            this.txtProcesamiento1.SelectionStart = 0;
            this.txtProcesamiento1.ShortcutsEnabled = true;
            this.txtProcesamiento1.Size = new System.Drawing.Size(107, 30);
            this.txtProcesamiento1.TabIndex = 32;
            this.txtProcesamiento1.UseSelectable = true;
            this.txtProcesamiento1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProcesamiento1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(389, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Vida util";
            // 
            // txtVidaUtil1
            // 
            // 
            // 
            // 
            this.txtVidaUtil1.CustomButton.Image = null;
            this.txtVidaUtil1.CustomButton.Location = new System.Drawing.Point(129, 2);
            this.txtVidaUtil1.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtVidaUtil1.CustomButton.Name = "";
            this.txtVidaUtil1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtVidaUtil1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVidaUtil1.CustomButton.TabIndex = 1;
            this.txtVidaUtil1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVidaUtil1.CustomButton.UseSelectable = true;
            this.txtVidaUtil1.CustomButton.Visible = false;
            this.txtVidaUtil1.Lines = new string[0];
            this.txtVidaUtil1.Location = new System.Drawing.Point(127, 207);
            this.txtVidaUtil1.MaxLength = 32767;
            this.txtVidaUtil1.Name = "txtVidaUtil1";
            this.txtVidaUtil1.PasswordChar = '\0';
            this.txtVidaUtil1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVidaUtil1.SelectedText = "";
            this.txtVidaUtil1.SelectionLength = 0;
            this.txtVidaUtil1.SelectionStart = 0;
            this.txtVidaUtil1.ShortcutsEnabled = true;
            this.txtVidaUtil1.Size = new System.Drawing.Size(157, 30);
            this.txtVidaUtil1.TabIndex = 33;
            this.txtVidaUtil1.UseSelectable = true;
            this.txtVidaUtil1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVidaUtil1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(389, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Procesamiento";
            // 
            // txtCosto2
            // 
            // 
            // 
            // 
            this.txtCosto2.CustomButton.Image = null;
            this.txtCosto2.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.txtCosto2.CustomButton.Margin = new System.Windows.Forms.Padding(1);
            this.txtCosto2.CustomButton.Name = "";
            this.txtCosto2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtCosto2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCosto2.CustomButton.TabIndex = 1;
            this.txtCosto2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCosto2.CustomButton.UseSelectable = true;
            this.txtCosto2.CustomButton.Visible = false;
            this.txtCosto2.Lines = new string[0];
            this.txtCosto2.Location = new System.Drawing.Point(463, 89);
            this.txtCosto2.MaxLength = 32767;
            this.txtCosto2.Name = "txtCosto2";
            this.txtCosto2.PasswordChar = '\0';
            this.txtCosto2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCosto2.SelectedText = "";
            this.txtCosto2.SelectionLength = 0;
            this.txtCosto2.SelectionStart = 0;
            this.txtCosto2.ShortcutsEnabled = true;
            this.txtCosto2.Size = new System.Drawing.Size(180, 30);
            this.txtCosto2.TabIndex = 34;
            this.txtCosto2.UseSelectable = true;
            this.txtCosto2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCosto2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(389, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Costo";
            // 
            // simulacion1
            // 
            this.simulacion1.Location = new System.Drawing.Point(4, 32);
            this.simulacion1.Name = "simulacion1";
            this.simulacion1.Padding = new System.Windows.Forms.Padding(3);
            this.simulacion1.Size = new System.Drawing.Size(1087, 346);
            this.simulacion1.TabIndex = 1;
            this.simulacion1.Text = "SIMULACION 1";
            this.simulacion1.UseVisualStyleBackColor = true;
            // 
            // simulacion2
            // 
            this.simulacion2.Location = new System.Drawing.Point(4, 32);
            this.simulacion2.Name = "simulacion2";
            this.simulacion2.Padding = new System.Windows.Forms.Padding(3);
            this.simulacion2.Size = new System.Drawing.Size(1087, 346);
            this.simulacion2.TabIndex = 2;
            this.simulacion2.Text = "SIMULACION 2";
            this.simulacion2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "BANCO";
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
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.btnGrabar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGrabar.ForeColor = System.Drawing.Color.White;
            this.btnGrabar.Location = new System.Drawing.Point(765, 279);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(139, 51);
            this.btnGrabar.TabIndex = 47;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGrabar.UseCustomBackColor = true;
            this.btnGrabar.UseCustomForeColor = true;
            this.btnGrabar.UseSelectable = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(177)))), ((int)(((byte)(202)))));
            this.btnBorrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(925, 279);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(139, 51);
            this.btnBorrar.TabIndex = 48;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBorrar.UseCustomBackColor = true;
            this.btnBorrar.UseCustomForeColor = true;
            this.btnBorrar.UseSelectable = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.tabControl1.ResumeLayout(false);
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage datos;
        private System.Windows.Forms.TabPage simulacion1;
        private MetroFramework.Controls.MetroTextBox txtCostoEspera;
        private System.Windows.Forms.Label lblMaquina1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMaquina2;
        private MetroFramework.Controls.MetroTextBox txtChequeProcesar;
        private MetroFramework.Controls.MetroTextBox txtCosto1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox txtVidaUtil2;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox txtProcesamiento2;
        private MetroFramework.Controls.MetroTextBox txtProcesamiento1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtVidaUtil1;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtCosto2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage simulacion2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton btnGrabar;
        private MetroFramework.Controls.MetroButton btnBorrar;
    }
}