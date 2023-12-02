namespace Campeonato1
{
    partial class frm_editar_jugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editar_jugadores));
            this.lbl_edad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_modi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_nac = new System.Windows.Forms.CheckBox();
            this.chk_nom = new System.Windows.Forms.CheckBox();
            this.chk_ape = new System.Windows.Forms.CheckBox();
            this.mtb_nac = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PicMin = new System.Windows.Forms.PictureBox();
            this.PicSalir = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(223, 60);
            this.lbl_edad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(13, 13);
            this.lbl_edad.TabIndex = 21;
            this.lbl_edad.Text = "..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Edad:";
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Location = new System.Drawing.Point(57, 46);
            this.lbl_equipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(13, 13);
            this.lbl_equipo.TabIndex = 19;
            this.lbl_equipo.Text = "..";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Equipo:";
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(233, 270);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(64, 28);
            this.btn_salir.TabIndex = 16;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_modi
            // 
            this.btn_modi.Location = new System.Drawing.Point(156, 270);
            this.btn_modi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modi.Name = "btn_modi";
            this.btn_modi.Size = new System.Drawing.Size(64, 28);
            this.btn_modi.TabIndex = 15;
            this.btn_modi.Text = "Modificar";
            this.btn_modi.UseVisualStyleBackColor = true;
            this.btn_modi.Click += new System.EventHandler(this.btn_modi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_nac);
            this.groupBox1.Controls.Add(this.chk_nom);
            this.groupBox1.Controls.Add(this.chk_ape);
            this.groupBox1.Controls.Add(this.mtb_nac);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Location = new System.Drawing.Point(6, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(295, 174);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de jugador";
            // 
            // chk_nac
            // 
            this.chk_nac.AutoSize = true;
            this.chk_nac.Location = new System.Drawing.Point(168, 99);
            this.chk_nac.Name = "chk_nac";
            this.chk_nac.Size = new System.Drawing.Size(15, 14);
            this.chk_nac.TabIndex = 10;
            this.chk_nac.UseVisualStyleBackColor = true;
            this.chk_nac.CheckedChanged += new System.EventHandler(this.chk_nac_CheckedChanged);
            // 
            // chk_nom
            // 
            this.chk_nom.AutoSize = true;
            this.chk_nom.Location = new System.Drawing.Point(277, 62);
            this.chk_nom.Name = "chk_nom";
            this.chk_nom.Size = new System.Drawing.Size(15, 14);
            this.chk_nom.TabIndex = 9;
            this.chk_nom.UseVisualStyleBackColor = true;
            this.chk_nom.CheckedChanged += new System.EventHandler(this.chk_nom_CheckedChanged);
            // 
            // chk_ape
            // 
            this.chk_ape.AutoSize = true;
            this.chk_ape.Location = new System.Drawing.Point(277, 31);
            this.chk_ape.Name = "chk_ape";
            this.chk_ape.Size = new System.Drawing.Size(15, 14);
            this.chk_ape.TabIndex = 8;
            this.chk_ape.UseVisualStyleBackColor = true;
            this.chk_ape.CheckedChanged += new System.EventHandler(this.chk_ape_CheckedChanged);
            // 
            // mtb_nac
            // 
            this.mtb_nac.BackColor = System.Drawing.SystemColors.Info;
            this.mtb_nac.Enabled = false;
            this.mtb_nac.Location = new System.Drawing.Point(98, 96);
            this.mtb_nac.Margin = new System.Windows.Forms.Padding(2);
            this.mtb_nac.Mask = "00/00/0000";
            this.mtb_nac.Name = "mtb_nac";
            this.mtb_nac.Size = new System.Drawing.Size(65, 20);
            this.mtb_nac.TabIndex = 2;
            this.mtb_nac.ValidatingType = typeof(System.DateTime);
            this.mtb_nac.Leave += new System.EventHandler(this.mtb_nac_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido";
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.Info;
            this.txt_apellido.Enabled = false;
            this.txt_apellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_apellido.Location = new System.Drawing.Point(98, 27);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2);
            this.txt_apellido.MaxLength = 30;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(174, 20);
            this.txt_apellido.TabIndex = 0;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_nombres
            // 
            this.txt_nombres.BackColor = System.Drawing.SystemColors.Info;
            this.txt_nombres.Enabled = false;
            this.txt_nombres.Location = new System.Drawing.Point(98, 58);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombres.MaxLength = 50;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(174, 20);
            this.txt_nombres.TabIndex = 1;
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            // 
            // txt_dni
            // 
            this.txt_dni.BackColor = System.Drawing.SystemColors.Info;
            this.txt_dni.Enabled = false;
            this.txt_dni.Location = new System.Drawing.Point(98, 128);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(2);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(99, 20);
            this.txt_dni.TabIndex = 3;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(148)))));
            this.BarraTitulo.Controls.Add(this.label6);
            this.BarraTitulo.Controls.Add(this.PicMin);
            this.BarraTitulo.Controls.Add(this.PicSalir);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(341, 35);
            this.BarraTitulo.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Editar Jugador";
            // 
            // PicMin
            // 
            this.PicMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMin.Image = ((System.Drawing.Image)(resources.GetObject("PicMin.Image")));
            this.PicMin.Location = new System.Drawing.Point(273, 7);
            this.PicMin.Name = "PicMin";
            this.PicMin.Size = new System.Drawing.Size(25, 25);
            this.PicMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicMin.TabIndex = 0;
            this.PicMin.TabStop = false;
            this.PicMin.Click += new System.EventHandler(this.PicMin_Click);
            // 
            // PicSalir
            // 
            this.PicSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicSalir.Image = ((System.Drawing.Image)(resources.GetObject("PicSalir.Image")));
            this.PicSalir.Location = new System.Drawing.Point(304, 7);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(25, 25);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSalir.TabIndex = 0;
            this.PicSalir.TabStop = false;
            // 
            // frm_editar_jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 325);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_equipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_modi);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_editar_jugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar jugador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_modi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.CheckBox chk_nac;
        private System.Windows.Forms.CheckBox chk_nom;
        private System.Windows.Forms.CheckBox chk_ape;
        private System.Windows.Forms.MaskedTextBox mtb_nac;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.PictureBox PicSalir;
    }
}