﻿namespace Campeonato1
{
    partial class frm_carga_jugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_carga_jugadores));
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtb_nac = new System.Windows.Forms.MaskedTextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_equipo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
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
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(98, 27);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_apellido.MaxLength = 30;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(174, 20);
            this.txt_apellido.TabIndex = 0;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(98, 58);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_nombres.MaxLength = 50;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(174, 20);
            this.txt_nombres.TabIndex = 1;
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombres_KeyPress);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(98, 128);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_dni.MaxLength = 8;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(99, 20);
            this.txt_dni.TabIndex = 4;
            this.txt_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dni_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtb_nac);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.txt_dni);
            this.groupBox1.Location = new System.Drawing.Point(16, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(295, 174);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de jugador";
            // 
            // mtb_nac
            // 
            this.mtb_nac.Location = new System.Drawing.Point(98, 96);
            this.mtb_nac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtb_nac.Mask = "00/00/0000";
            this.mtb_nac.Name = "mtb_nac";
            this.mtb_nac.Size = new System.Drawing.Size(65, 20);
            this.mtb_nac.TabIndex = 3;
            this.mtb_nac.ValidatingType = typeof(System.DateTime);
            this.mtb_nac.Leave += new System.EventHandler(this.mtb_nac_Leave);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(227, 143);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(63, 26);
            this.btn_limpiar.TabIndex = 5;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(166, 271);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(64, 28);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Equipo:";
            // 
            // lbl_equipo
            // 
            this.lbl_equipo.AutoSize = true;
            this.lbl_equipo.Location = new System.Drawing.Point(67, 47);
            this.lbl_equipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_equipo.Name = "lbl_equipo";
            this.lbl_equipo.Size = new System.Drawing.Size(13, 13);
            this.lbl_equipo.TabIndex = 12;
            this.lbl_equipo.Text = "..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 61);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edad:";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(233, 61);
            this.lbl_edad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(13, 13);
            this.lbl_edad.TabIndex = 14;
            this.lbl_edad.Text = "..";
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
            this.BarraTitulo.Size = new System.Drawing.Size(329, 35);
            this.BarraTitulo.TabIndex = 15;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
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
            this.PicMin.Location = new System.Drawing.Point(261, 7);
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
            this.PicSalir.Location = new System.Drawing.Point(292, 7);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(25, 25);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSalir.TabIndex = 0;
            this.PicSalir.TabStop = false;
            this.PicSalir.Click += new System.EventHandler(this.PicSalir_Click);
            // 
            // frm_carga_jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 313);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_equipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frm_carga_jugadores";
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

        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.MaskedTextBox mtb_nac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_equipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.PictureBox PicSalir;
    }
}