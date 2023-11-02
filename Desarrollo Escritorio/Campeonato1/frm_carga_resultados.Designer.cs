namespace Campeonato1
{
    partial class frm_carga_resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_carga_resultados));
            this.label4 = new System.Windows.Forms.Label();
            this.PicSalir = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.PicMin = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DniJugador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ApellJugador = new System.Windows.Forms.Label();
            this.NameJugador = new System.Windows.Forms.Label();
            this.textBoxGol = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAmarilla = new System.Windows.Forms.Button();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_jugador = new System.Windows.Forms.DataGridView();
            this.gbCarga_Resultado = new System.Windows.Forms.GroupBox();
            this.lbEquipo1 = new System.Windows.Forms.Label();
            this.lbEquipo2 = new System.Windows.Forms.Label();
            this.btnBuenaFe2 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtEquipo1 = new System.Windows.Forms.TextBox();
            this.btnBuenaFe1 = new System.Windows.Forms.Button();
            this.txtEquipo2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugador)).BeginInit();
            this.gbCarga_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Carga de Partidos";
            // 
            // PicSalir
            // 
            this.PicSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSalir.Image = ((System.Drawing.Image)(resources.GetObject("PicSalir.Image")));
            this.PicSalir.Location = new System.Drawing.Point(763, 7);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(25, 25);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSalir.TabIndex = 0;
            this.PicSalir.TabStop = false;
            this.PicSalir.Click += new System.EventHandler(this.PicSalir_Click_1);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.BarraTitulo.Controls.Add(this.label4);
            this.BarraTitulo.Controls.Add(this.PicMin);
            this.BarraTitulo.Controls.Add(this.PicSalir);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(800, 35);
            this.BarraTitulo.TabIndex = 14;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // PicMin
            // 
            this.PicMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMin.Image = ((System.Drawing.Image)(resources.GetObject("PicMin.Image")));
            this.PicMin.Location = new System.Drawing.Point(732, 7);
            this.PicMin.Name = "PicMin";
            this.PicMin.Size = new System.Drawing.Size(25, 25);
            this.PicMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMin.TabIndex = 0;
            this.PicMin.TabStop = false;
            this.PicMin.Click += new System.EventHandler(this.PicMin_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 119);
            this.button1.TabIndex = 10;
            this.button1.Text = "Goool";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DniJugador
            // 
            this.DniJugador.AutoSize = true;
            this.DniJugador.Location = new System.Drawing.Point(55, 70);
            this.DniJugador.Name = "DniJugador";
            this.DniJugador.Size = new System.Drawing.Size(43, 13);
            this.DniJugador.TabIndex = 7;
            this.DniJugador.Text = "............";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "D.N.I: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre: ";
            // 
            // ApellJugador
            // 
            this.ApellJugador.AutoSize = true;
            this.ApellJugador.Location = new System.Drawing.Point(177, 24);
            this.ApellJugador.Name = "ApellJugador";
            this.ApellJugador.Size = new System.Drawing.Size(43, 13);
            this.ApellJugador.TabIndex = 3;
            this.ApellJugador.Text = "............";
            // 
            // NameJugador
            // 
            this.NameJugador.AutoSize = true;
            this.NameJugador.Location = new System.Drawing.Point(55, 24);
            this.NameJugador.Name = "NameJugador";
            this.NameJugador.Size = new System.Drawing.Size(43, 13);
            this.NameJugador.TabIndex = 0;
            this.NameJugador.Text = "............";
            // 
            // textBoxGol
            // 
            this.textBoxGol.Location = new System.Drawing.Point(163, 63);
            this.textBoxGol.Name = "textBoxGol";
            this.textBoxGol.Size = new System.Drawing.Size(48, 20);
            this.textBoxGol.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnAmarilla);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.DniJugador);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ApellJugador);
            this.groupBox1.Controls.Add(this.NameJugador);
            this.groupBox1.Controls.Add(this.textBoxGol);
            this.groupBox1.Location = new System.Drawing.Point(449, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 161);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goleadores";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(78, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 31);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAmarilla
            // 
            this.btnAmarilla.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarilla.Location = new System.Drawing.Point(9, 112);
            this.btnAmarilla.Name = "btnAmarilla";
            this.btnAmarilla.Size = new System.Drawing.Size(63, 31);
            this.btnAmarilla.TabIndex = 11;
            this.btnAmarilla.UseVisualStyleBackColor = false;
            this.btnAmarilla.Click += new System.EventHandler(this.btnAmarilla_Click);
            // 
            // col3
            // 
            this.col3.HeaderText = "EDAD";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Width = 60;
            // 
            // col2
            // 
            this.col2.HeaderText = "DNI";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col1
            // 
            this.col1.HeaderText = "APELLIDO Y NOMBRE";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 250;
            // 
            // dgv_jugador
            // 
            this.dgv_jugador.AllowUserToAddRows = false;
            this.dgv_jugador.AllowUserToDeleteRows = false;
            this.dgv_jugador.AllowUserToResizeRows = false;
            this.dgv_jugador.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_jugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.dgv_jugador.Location = new System.Drawing.Point(11, 87);
            this.dgv_jugador.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_jugador.Name = "dgv_jugador";
            this.dgv_jugador.ReadOnly = true;
            this.dgv_jugador.RowHeadersVisible = false;
            this.dgv_jugador.RowTemplate.Height = 24;
            this.dgv_jugador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_jugador.Size = new System.Drawing.Size(413, 348);
            this.dgv_jugador.TabIndex = 13;
            this.dgv_jugador.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_jugador_MouseDoubleClick);
            // 
            // gbCarga_Resultado
            // 
            this.gbCarga_Resultado.Controls.Add(this.lbEquipo1);
            this.gbCarga_Resultado.Controls.Add(this.lbEquipo2);
            this.gbCarga_Resultado.Controls.Add(this.btnBuenaFe2);
            this.gbCarga_Resultado.Controls.Add(this.btnAceptar);
            this.gbCarga_Resultado.Controls.Add(this.txtEquipo1);
            this.gbCarga_Resultado.Controls.Add(this.btnBuenaFe1);
            this.gbCarga_Resultado.Controls.Add(this.txtEquipo2);
            this.gbCarga_Resultado.Location = new System.Drawing.Point(449, 87);
            this.gbCarga_Resultado.Name = "gbCarga_Resultado";
            this.gbCarga_Resultado.Size = new System.Drawing.Size(321, 165);
            this.gbCarga_Resultado.TabIndex = 11;
            this.gbCarga_Resultado.TabStop = false;
            this.gbCarga_Resultado.Text = "Equipos Vs Equios";
            // 
            // lbEquipo1
            // 
            this.lbEquipo1.AutoSize = true;
            this.lbEquipo1.Location = new System.Drawing.Point(55, 31);
            this.lbEquipo1.Name = "lbEquipo1";
            this.lbEquipo1.Size = new System.Drawing.Size(54, 13);
            this.lbEquipo1.TabIndex = 0;
            this.lbEquipo1.Text = "lbEquipo1";
            // 
            // lbEquipo2
            // 
            this.lbEquipo2.AutoSize = true;
            this.lbEquipo2.Location = new System.Drawing.Point(219, 31);
            this.lbEquipo2.Name = "lbEquipo2";
            this.lbEquipo2.Size = new System.Drawing.Size(35, 13);
            this.lbEquipo2.TabIndex = 1;
            this.lbEquipo2.Text = "label2";
            // 
            // btnBuenaFe2
            // 
            this.btnBuenaFe2.Location = new System.Drawing.Point(194, 83);
            this.btnBuenaFe2.Name = "btnBuenaFe2";
            this.btnBuenaFe2.Size = new System.Drawing.Size(92, 23);
            this.btnBuenaFe2.TabIndex = 5;
            this.btnBuenaFe2.Text = "Lista Buena Fe";
            this.btnBuenaFe2.UseVisualStyleBackColor = true;
            this.btnBuenaFe2.Click += new System.EventHandler(this.btnBuenaFe2_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(93, 112);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 37);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // txtEquipo1
            // 
            this.txtEquipo1.Location = new System.Drawing.Point(27, 47);
            this.txtEquipo1.Name = "txtEquipo1";
            this.txtEquipo1.Size = new System.Drawing.Size(94, 20);
            this.txtEquipo1.TabIndex = 2;
            // 
            // btnBuenaFe1
            // 
            this.btnBuenaFe1.Location = new System.Drawing.Point(27, 83);
            this.btnBuenaFe1.Name = "btnBuenaFe1";
            this.btnBuenaFe1.Size = new System.Drawing.Size(94, 23);
            this.btnBuenaFe1.TabIndex = 4;
            this.btnBuenaFe1.Text = "Lista Buena Fe";
            this.btnBuenaFe1.UseVisualStyleBackColor = true;
            this.btnBuenaFe1.Click += new System.EventHandler(this.btnBuenaFe1_Click_1);
            // 
            // txtEquipo2
            // 
            this.txtEquipo2.Location = new System.Drawing.Point(194, 47);
            this.txtEquipo2.Name = "txtEquipo2";
            this.txtEquipo2.Size = new System.Drawing.Size(92, 20);
            this.txtEquipo2.TabIndex = 3;
            // 
            // frm_carga_resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_jugador);
            this.Controls.Add(this.gbCarga_Resultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_carga_resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_carga_resultados";
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugador)).EndInit();
            this.gbCarga_Resultado.ResumeLayout(false);
            this.gbCarga_Resultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicSalir;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label DniJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApellJugador;
        private System.Windows.Forms.Label NameJugador;
        private System.Windows.Forms.TextBox textBoxGol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridView dgv_jugador;
        private System.Windows.Forms.GroupBox gbCarga_Resultado;
        private System.Windows.Forms.Label lbEquipo1;
        private System.Windows.Forms.Label lbEquipo2;
        private System.Windows.Forms.Button btnBuenaFe2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtEquipo1;
        private System.Windows.Forms.Button btnBuenaFe1;
        private System.Windows.Forms.TextBox txtEquipo2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAmarilla;
    }
}