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
            this.dgv_equipo = new System.Windows.Forms.DataGridView();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbCarga_Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipo)).BeginInit();
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
            // dgv_equipo
            // 
            this.dgv_equipo.AllowUserToAddRows = false;
            this.dgv_equipo.AllowUserToDeleteRows = false;
            this.dgv_equipo.AllowUserToResizeRows = false;
            this.dgv_equipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1,
            this.col2,
            this.col3});
            this.dgv_equipo.Location = new System.Drawing.Point(11, 12);
            this.dgv_equipo.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_equipo.Name = "dgv_equipo";
            this.dgv_equipo.ReadOnly = true;
            this.dgv_equipo.RowHeadersVisible = false;
            this.dgv_equipo.RowTemplate.Height = 24;
            this.dgv_equipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_equipo.Size = new System.Drawing.Size(413, 348);
            this.dgv_equipo.TabIndex = 9;
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(449, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Goleadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // frm_carga_resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_equipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbCarga_Resultado);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frm_carga_resultados";
            this.Text = "frm_carga_resultados";
            this.gbCarga_Resultado.ResumeLayout(false);
            this.gbCarga_Resultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipo)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}