namespace Campeonato1
{
    partial class frm_posicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_posicion));
            this.dgv_posicion = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PicMin = new System.Windows.Forms.PictureBox();
            this.PicSalir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posicion)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_posicion
            // 
            this.dgv_posicion.AllowUserToAddRows = false;
            this.dgv_posicion.AllowUserToDeleteRows = false;
            this.dgv_posicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_posicion.Location = new System.Drawing.Point(11, 69);
            this.dgv_posicion.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_posicion.Name = "dgv_posicion";
            this.dgv_posicion.ReadOnly = true;
            this.dgv_posicion.RowTemplate.Height = 24;
            this.dgv_posicion.Size = new System.Drawing.Size(526, 227);
            this.dgv_posicion.TabIndex = 0;
            this.dgv_posicion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_posicion_CellContentClick);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(453, 300);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(82, 33);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
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
            this.BarraTitulo.Size = new System.Drawing.Size(544, 35);
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
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tabla de Posiciones";
            // 
            // PicMin
            // 
            this.PicMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMin.Image = ((System.Drawing.Image)(resources.GetObject("PicMin.Image")));
            this.PicMin.Location = new System.Drawing.Point(476, 7);
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
            this.PicSalir.Location = new System.Drawing.Point(507, 7);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(25, 25);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSalir.TabIndex = 0;
            this.PicSalir.TabStop = false;
            this.PicSalir.Click += new System.EventHandler(this.PicSalir_Click);
            // 
            // frm_posicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 356);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dgv_posicion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_posicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla de posiciones";
            this.Load += new System.EventHandler(this.frm_posicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posicion)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_posicion;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.PictureBox PicSalir;
    }
}