namespace Campeonato1
{
    partial class frm_carga_sancion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_carga_sancion));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_jugador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.cmb_motivo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_roja = new System.Windows.Forms.RadioButton();
            this.rdb_amarilla = new System.Windows.Forms.RadioButton();
            this.cmb_fechas = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_carga = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido y nombre:";
            // 
            // lbl_jugador
            // 
            this.lbl_jugador.AutoSize = true;
            this.lbl_jugador.Location = new System.Drawing.Point(105, 34);
            this.lbl_jugador.Name = "lbl_jugador";
            this.lbl_jugador.Size = new System.Drawing.Size(13, 13);
            this.lbl_jugador.TabIndex = 1;
            this.lbl_jugador.Text = "..";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Equipo:";
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Location = new System.Drawing.Point(55, 60);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(13, 13);
            this.lbl_equipo.TabIndex = 3;
            this.lbl_equipo.Text = "..";
            // 
            // cmb_motivo
            // 
            this.cmb_motivo.Enabled = false;
            this.cmb_motivo.FormattingEnabled = true;
            this.cmb_motivo.Location = new System.Drawing.Point(157, 18);
            this.cmb_motivo.Name = "cmb_motivo";
            this.cmb_motivo.Size = new System.Drawing.Size(157, 21);
            this.cmb_motivo.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_roja);
            this.groupBox1.Controls.Add(this.cmb_motivo);
            this.groupBox1.Controls.Add(this.rdb_amarilla);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de tarjeta";
            // 
            // rdb_roja
            // 
            this.rdb_roja.AutoSize = true;
            this.rdb_roja.Location = new System.Drawing.Point(94, 19);
            this.rdb_roja.Name = "rdb_roja";
            this.rdb_roja.Size = new System.Drawing.Size(47, 17);
            this.rdb_roja.TabIndex = 1;
            this.rdb_roja.Text = "Roja";
            this.rdb_roja.UseVisualStyleBackColor = true;
            this.rdb_roja.CheckedChanged += new System.EventHandler(this.rdb_roja_CheckedChanged);
            // 
            // rdb_amarilla
            // 
            this.rdb_amarilla.AutoSize = true;
            this.rdb_amarilla.Checked = true;
            this.rdb_amarilla.Location = new System.Drawing.Point(16, 19);
            this.rdb_amarilla.Name = "rdb_amarilla";
            this.rdb_amarilla.Size = new System.Drawing.Size(61, 17);
            this.rdb_amarilla.TabIndex = 0;
            this.rdb_amarilla.TabStop = true;
            this.rdb_amarilla.Text = "Amarilla";
            this.rdb_amarilla.UseVisualStyleBackColor = true;
            // 
            // cmb_fechas
            // 
            this.cmb_fechas.FormattingEnabled = true;
            this.cmb_fechas.Location = new System.Drawing.Point(169, 124);
            this.cmb_fechas.Name = "cmb_fechas";
            this.cmb_fechas.Size = new System.Drawing.Size(121, 21);
            this.cmb_fechas.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbl_jugador);
            this.groupBox2.Controls.Add(this.lbl_equipo);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 92);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del jugador sancionado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de sancion";
            // 
            // btn_carga
            // 
            this.btn_carga.Location = new System.Drawing.Point(193, 221);
            this.btn_carga.Name = "btn_carga";
            this.btn_carga.Size = new System.Drawing.Size(75, 34);
            this.btn_carga.TabIndex = 8;
            this.btn_carga.Text = "Cargar sancion";
            this.btn_carga.UseVisualStyleBackColor = true;
            this.btn_carga.Click += new System.EventHandler(this.btn_carga_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(274, 221);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 34);
            this.btn_salir.TabIndex = 9;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_carga_sancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 262);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_carga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmb_fechas);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_carga_sancion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de sanciones ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_jugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.ComboBox cmb_motivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_roja;
        private System.Windows.Forms.RadioButton rdb_amarilla;
        private System.Windows.Forms.ComboBox cmb_fechas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_carga;
        private System.Windows.Forms.Button btn_salir;
    }
}