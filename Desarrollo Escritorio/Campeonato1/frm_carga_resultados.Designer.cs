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
            this.lbEquipo1 = new System.Windows.Forms.Label();
            this.lbEquipo2 = new System.Windows.Forms.Label();
            this.txtEquipo1 = new System.Windows.Forms.TextBox();
            this.txtEquipo2 = new System.Windows.Forms.TextBox();
            this.btnBuenaFe1 = new System.Windows.Forms.Button();
            this.btnBuenaFe2 = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbCarga_Resultado = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgv_jugador = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DniJugador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ApellJugador = new System.Windows.Forms.Label();
            this.NameJugador = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbCarga_Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugador)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEquipo1
            // 
            this.lbEquipo1.AutoSize = true;
            this.lbEquipo1.Location = new System.Drawing.Point(55, 31);
            this.lbEquipo1.Name = "lbEquipo1";
            this.lbEquipo1.Size = new System.Drawing.Size(35, 13);
            this.lbEquipo1.TabIndex = 0;
            this.lbEquipo1.Text = "label1";
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
            // txtEquipo1
            // 
            this.txtEquipo1.Location = new System.Drawing.Point(25, 67);
            this.txtEquipo1.Name = "txtEquipo1";
            this.txtEquipo1.Size = new System.Drawing.Size(100, 20);
            this.txtEquipo1.TabIndex = 2;
            // 
            // txtEquipo2
            // 
            this.txtEquipo2.Location = new System.Drawing.Point(190, 67);
            this.txtEquipo2.Name = "txtEquipo2";
            this.txtEquipo2.Size = new System.Drawing.Size(100, 20);
            this.txtEquipo2.TabIndex = 3;
            // 
            // btnBuenaFe1
            // 
            this.btnBuenaFe1.Location = new System.Drawing.Point(31, 103);
            this.btnBuenaFe1.Name = "btnBuenaFe1";
            this.btnBuenaFe1.Size = new System.Drawing.Size(94, 23);
            this.btnBuenaFe1.TabIndex = 4;
            this.btnBuenaFe1.Text = "Lista Buena Fe";
            this.btnBuenaFe1.UseVisualStyleBackColor = true;
            this.btnBuenaFe1.Click += new System.EventHandler(this.btnBuenaFe1_Click);
            // 
            // btnBuenaFe2
            // 
            this.btnBuenaFe2.Location = new System.Drawing.Point(198, 103);
            this.btnBuenaFe2.Name = "btnBuenaFe2";
            this.btnBuenaFe2.Size = new System.Drawing.Size(92, 23);
            this.btnBuenaFe2.TabIndex = 5;
            this.btnBuenaFe2.Text = "Lista Buena Fe";
            this.btnBuenaFe2.UseVisualStyleBackColor = true;
            this.btnBuenaFe2.Click += new System.EventHandler(this.btnBuenaFe2_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(639, 296);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 37);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gbCarga_Resultado
            // 
            this.gbCarga_Resultado.Controls.Add(this.lbEquipo1);
            this.gbCarga_Resultado.Controls.Add(this.lbEquipo2);
            this.gbCarga_Resultado.Controls.Add(this.btnBuenaFe2);
            this.gbCarga_Resultado.Controls.Add(this.txtEquipo1);
            this.gbCarga_Resultado.Controls.Add(this.btnBuenaFe1);
            this.gbCarga_Resultado.Controls.Add(this.txtEquipo2);
            this.gbCarga_Resultado.Location = new System.Drawing.Point(449, 12);
            this.gbCarga_Resultado.Name = "gbCarga_Resultado";
            this.gbCarga_Resultado.Size = new System.Drawing.Size(321, 150);
            this.gbCarga_Resultado.TabIndex = 7;
            this.gbCarga_Resultado.TabStop = false;
            this.gbCarga_Resultado.Text = "Equipos Vs Equios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(474, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgv_jugador
            // 
            this.dgv_jugador.AllowUserToAddRows = false;
            this.dgv_jugador.AllowUserToDeleteRows = false;
            this.dgv_jugador.AllowUserToResizeRows = false;
            this.dgv_jugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.dgv_jugador.Location = new System.Drawing.Point(11, 12);
            this.dgv_jugador.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_jugador.Name = "dgv_jugador";
            this.dgv_jugador.ReadOnly = true;
            this.dgv_jugador.RowHeadersVisible = false;
            this.dgv_jugador.RowTemplate.Height = 24;
            this.dgv_jugador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_jugador.Size = new System.Drawing.Size(413, 348);
            this.dgv_jugador.TabIndex = 9;
            this.dgv_jugador.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_equipo_MouseDoubleClick);
            // 
            // col1
            // 
            this.col1.HeaderText = "APELLIDO Y NOMBRE";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            this.col1.Width = 250;
            // 
            // col2
            // 
            this.col2.HeaderText = "DNI";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.HeaderText = "EDAD";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            this.col3.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DniJugador);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ApellJugador);
            this.groupBox1.Controls.Add(this.NameJugador);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(449, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 96);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goleadores";
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
            this.label2.Location = new System.Drawing.Point(151, 24);
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
            this.ApellJugador.Location = new System.Drawing.Point(207, 24);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 20);
            this.textBox1.TabIndex = 2;
            // 
            // frm_carga_resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_jugador);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbCarga_Resultado);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frm_carga_resultados";
            this.Text = "frm_carga_resultados";
            this.gbCarga_Resultado.ResumeLayout(false);
            this.gbCarga_Resultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugador)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbEquipo1;
        private System.Windows.Forms.Label lbEquipo2;
        private System.Windows.Forms.TextBox txtEquipo1;
        private System.Windows.Forms.TextBox txtEquipo2;
        private System.Windows.Forms.Button btnBuenaFe1;
        private System.Windows.Forms.Button btnBuenaFe2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gbCarga_Resultado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgv_jugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameJugador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ApellJugador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DniJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}