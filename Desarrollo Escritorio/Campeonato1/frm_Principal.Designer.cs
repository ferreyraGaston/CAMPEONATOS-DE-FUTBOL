namespace Campeonato1
{
    partial class frm_Principal2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PicMin = new System.Windows.Forms.PictureBox();
            this.PicSalir = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEquipoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copaDeOroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copaDePlataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDePosicionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeSancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PicMin
            // 
            this.PicMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicMin.Image = ((System.Drawing.Image)(resources.GetObject("PicMin.Image")));
            this.PicMin.Location = new System.Drawing.Point(639, 7);
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
            this.PicSalir.Location = new System.Drawing.Point(670, 7);
            this.PicSalir.Name = "PicSalir";
            this.PicSalir.Size = new System.Drawing.Size(25, 25);
            this.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicSalir.TabIndex = 0;
            this.PicSalir.TabStop = false;
            this.PicSalir.Click += new System.EventHandler(this.PicSalir_Click);
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
            this.BarraTitulo.Size = new System.Drawing.Size(707, 35);
            this.BarraTitulo.TabIndex = 20;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Agregar Equipos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEquipoToolStripMenuItem,
            this.sorteoToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarEquipoToolStripMenuItem
            // 
            this.agregarEquipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEquipoToolStripMenuItem1,
            this.agregarJugadorToolStripMenuItem});
            this.agregarEquipoToolStripMenuItem.Name = "agregarEquipoToolStripMenuItem";
            this.agregarEquipoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.agregarEquipoToolStripMenuItem.Text = "Comenzar";
            // 
            // agregarEquipoToolStripMenuItem1
            // 
            this.agregarEquipoToolStripMenuItem1.Name = "agregarEquipoToolStripMenuItem1";
            this.agregarEquipoToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.agregarEquipoToolStripMenuItem1.Text = "Agregar equipo";
            this.agregarEquipoToolStripMenuItem1.Click += new System.EventHandler(this.agregarEquipoToolStripMenuItem1_Click);
            // 
            // agregarJugadorToolStripMenuItem
            // 
            this.agregarJugadorToolStripMenuItem.Name = "agregarJugadorToolStripMenuItem";
            this.agregarJugadorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarJugadorToolStripMenuItem.Text = "Gestionar jugadores";
            this.agregarJugadorToolStripMenuItem.Click += new System.EventHandler(this.agregarJugadorToolStripMenuItem_Click);
            // 
            // sorteoToolStripMenuItem
            // 
            this.sorteoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorteoToolStripMenuItem1,
            this.playOffToolStripMenuItem});
            this.sorteoToolStripMenuItem.Name = "sorteoToolStripMenuItem";
            this.sorteoToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.sorteoToolStripMenuItem.Text = "Administrar Campeonato";
            // 
            // sorteoToolStripMenuItem1
            // 
            this.sorteoToolStripMenuItem1.Name = "sorteoToolStripMenuItem1";
            this.sorteoToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.sorteoToolStripMenuItem1.Text = "Sorteo ";
            this.sorteoToolStripMenuItem1.Click += new System.EventHandler(this.sorteoToolStripMenuItem1_Click);
            // 
            // playOffToolStripMenuItem
            // 
            this.playOffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copaDeOroToolStripMenuItem,
            this.copaDePlataToolStripMenuItem});
            this.playOffToolStripMenuItem.Name = "playOffToolStripMenuItem";
            this.playOffToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.playOffToolStripMenuItem.Text = "PlayOff";
            // 
            // copaDeOroToolStripMenuItem
            // 
            this.copaDeOroToolStripMenuItem.Name = "copaDeOroToolStripMenuItem";
            this.copaDeOroToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.copaDeOroToolStripMenuItem.Text = "Copa de oro";
            this.copaDeOroToolStripMenuItem.Click += new System.EventHandler(this.copaDeOroToolStripMenuItem_Click);
            // 
            // copaDePlataToolStripMenuItem
            // 
            this.copaDePlataToolStripMenuItem.Name = "copaDePlataToolStripMenuItem";
            this.copaDePlataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.copaDePlataToolStripMenuItem.Text = "Copa de plata";
            this.copaDePlataToolStripMenuItem.Click += new System.EventHandler(this.copaDePlataToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaDePosicionesToolStripMenuItem,
            this.cargaDeResultadosToolStripMenuItem,
            this.cargaDeSancionesToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // tablaDePosicionesToolStripMenuItem
            // 
            this.tablaDePosicionesToolStripMenuItem.Name = "tablaDePosicionesToolStripMenuItem";
            this.tablaDePosicionesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.tablaDePosicionesToolStripMenuItem.Text = "Tabla de posiciones";
            this.tablaDePosicionesToolStripMenuItem.Click += new System.EventHandler(this.tablaDePosicionesToolStripMenuItem_Click);
            // 
            // cargaDeResultadosToolStripMenuItem
            // 
            this.cargaDeResultadosToolStripMenuItem.Name = "cargaDeResultadosToolStripMenuItem";
            this.cargaDeResultadosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cargaDeResultadosToolStripMenuItem.Text = "Carga de resultados";
            this.cargaDeResultadosToolStripMenuItem.Click += new System.EventHandler(this.cargaDeResultadosToolStripMenuItem_Click);
            // 
            // cargaDeSancionesToolStripMenuItem
            // 
            this.cargaDeSancionesToolStripMenuItem.Name = "cargaDeSancionesToolStripMenuItem";
            this.cargaDeSancionesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cargaDeSancionesToolStripMenuItem.Text = "Carga de sanciones";
            this.cargaDeSancionesToolStripMenuItem.Click += new System.EventHandler(this.cargaDeSancionesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // frm_Principal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 496);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frm_Principal2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Campeonato Amateur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSalir)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicMin;
        private System.Windows.Forms.PictureBox PicSalir;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEquipoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copaDeOroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copaDePlataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDePosicionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeResultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeSancionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}