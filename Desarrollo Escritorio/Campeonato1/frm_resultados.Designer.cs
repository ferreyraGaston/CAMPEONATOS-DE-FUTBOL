namespace Campeonato1
{
    partial class frm_resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_resultados));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_fechas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PicMin = new System.Windows.Forms.PictureBox();
            this.PicSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmb_fechas
            // 
            this.cmb_fechas.FormattingEnabled = true;
            this.cmb_fechas.Location = new System.Drawing.Point(188, 45);
            this.cmb_fechas.Name = "cmb_fechas";
            this.cmb_fechas.Size = new System.Drawing.Size(134, 21);
            this.cmb_fechas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ver Fecha";
            // 
            // btn_ver
            // 
            this.btn_ver.Location = new System.Drawing.Point(365, 48);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(75, 23);
            this.btn_ver.TabIndex = 7;
            this.btn_ver.Text = "Seleccionar";
            this.btn_ver.UseVisualStyleBackColor = true;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 198);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            this.BarraTitulo.Size = new System.Drawing.Size(522, 35);
            this.BarraTitulo.TabIndex = 11;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "RESULTADOS DE LA FECHA";
            // 
            // PicMin
            // 
            this.PicMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMin.Image = ((System.Drawing.Image)(resources.GetObject("PicMin.Image")));
            this.PicMin.Location = new System.Drawing.Point(454, 7);
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
            this.PicSalir.Location = new System.Drawing.Point(485, 7);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(25, 25);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSalir.TabIndex = 0;
            this.PicSalir.TabStop = false;
            this.PicSalir.Click += new System.EventHandler(this.PicSalir_Click);
            // 
            // frm_resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 360);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_fechas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_resultados";
            this.Text = "frm_resultados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_fechas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.PictureBox PicSalir;
    }
}