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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ESCUDO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EQUIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EQUIPO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESCUDO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESULTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "RESULTADOS DE LA FECHA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESCUDO1,
            this.EQUIPO,
            this.VS,
            this.EQUIPO2,
            this.ESCUDO2,
            this.RESULTADO});
            this.dataGridView1.Location = new System.Drawing.Point(11, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 219);
            this.dataGridView1.TabIndex = 2;
           
            // ESCUDO1
            // 
            this.ESCUDO1.Frozen = true;
            this.ESCUDO1.HeaderText = "ESCUDO1";
            this.ESCUDO1.MinimumWidth = 6;
            this.ESCUDO1.Name = "ESCUDO1";
            this.ESCUDO1.Width = 120;
            // 
            // EQUIPO
            // 
            this.EQUIPO.HeaderText = "EQUIPO";
            this.EQUIPO.MinimumWidth = 6;
            this.EQUIPO.Name = "EQUIPO";
            this.EQUIPO.ReadOnly = true;
            this.EQUIPO.Width = 125;
            // 
            // VS
            // 
            this.VS.HeaderText = "VS";
            this.VS.MinimumWidth = 6;
            this.VS.Name = "VS";
            this.VS.ReadOnly = true;
            this.VS.Width = 50;
            // 
            // EQUIPO2
            // 
            this.EQUIPO2.HeaderText = "EQUIPO2";
            this.EQUIPO2.MinimumWidth = 6;
            this.EQUIPO2.Name = "EQUIPO2";
            this.EQUIPO2.ReadOnly = true;
            this.EQUIPO2.Width = 125;
            // 
            // ESCUDO2
            // 
            this.ESCUDO2.HeaderText = "ESCUDO2";
            this.ESCUDO2.MinimumWidth = 6;
            this.ESCUDO2.Name = "ESCUDO2";
            this.ESCUDO2.ReadOnly = true;
            this.ESCUDO2.Width = 120;
            // 
            // RESULTADO
            // 
            this.RESULTADO.HeaderText = "RESULTADO";
            this.RESULTADO.MinimumWidth = 6;
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 349);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;

            // 
            // frm_resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_resultados";
            this.Text = "frm_resultados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESCUDO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EQUIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EQUIPO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESCUDO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESULTADO;
        private System.Windows.Forms.Button button2;
    }
}