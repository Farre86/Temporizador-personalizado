namespace WindowsFormsApplication1
{
    partial class frmTemporizador
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemporizador));
            this.nudTemps = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSegons = new System.Windows.Forms.Label();
            this.timerTemps = new System.Windows.Forms.Timer(this.components);
            this.menuTiemposPredeterminados = new System.Windows.Forms.MenuStrip();
            this.tsMenuItemTiempos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSegundos3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinutos3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinutos5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinutos10 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinutos20 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinutos30 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinutos45 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHora1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHora2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemps)).BeginInit();
            this.menuTiemposPredeterminados.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudTemps
            // 
            this.nudTemps.BackColor = System.Drawing.SystemColors.InfoText;
            this.nudTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTemps.ForeColor = System.Drawing.Color.Red;
            this.nudTemps.Location = new System.Drawing.Point(12, 37);
            this.nudTemps.Maximum = new decimal(new int[] {
            36000,
            0,
            0,
            0});
            this.nudTemps.Name = "nudTemps";
            this.nudTemps.Size = new System.Drawing.Size(120, 26);
            this.nudTemps.TabIndex = 0;
            this.nudTemps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudTemps.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudTemps.ValueChanged += new System.EventHandler(this.nudTemps_ValueChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(197, 37);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSegons
            // 
            this.lblSegons.AutoSize = true;
            this.lblSegons.Location = new System.Drawing.Point(140, 40);
            this.lblSegons.Name = "lblSegons";
            this.lblSegons.Size = new System.Drawing.Size(55, 13);
            this.lblSegons.TabIndex = 2;
            this.lblSegons.Text = "Segundos";
            // 
            // timerTemps
            // 
            this.timerTemps.Interval = 1000;
            this.timerTemps.Tick += new System.EventHandler(this.timerTemps_Tick);
            // 
            // menuTiemposPredeterminados
            // 
            this.menuTiemposPredeterminados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemTiempos});
            this.menuTiemposPredeterminados.Location = new System.Drawing.Point(0, 0);
            this.menuTiemposPredeterminados.Name = "menuTiemposPredeterminados";
            this.menuTiemposPredeterminados.Size = new System.Drawing.Size(284, 24);
            this.menuTiemposPredeterminados.TabIndex = 3;
            this.menuTiemposPredeterminados.Text = "Tiempos predeterminados";
            // 
            // tsMenuItemTiempos
            // 
            this.tsMenuItemTiempos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSegundos3,
            this.tsmiMinutos3,
            this.tsmiMinutos5,
            this.tsmiMinutos10,
            this.tsmiMinutos20,
            this.tsmiMinutos30,
            this.tsmiMinutos45,
            this.tsmiHora1,
            this.tsmiHora2});
            this.tsMenuItemTiempos.Name = "tsMenuItemTiempos";
            this.tsMenuItemTiempos.Size = new System.Drawing.Size(158, 20);
            this.tsMenuItemTiempos.Text = "Tiempos predeterminados";
            // 
            // tsmiSegundos3
            // 
            this.tsmiSegundos3.Name = "tsmiSegundos3";
            this.tsmiSegundos3.Size = new System.Drawing.Size(167, 22);
            this.tsmiSegundos3.Tag = "3";
            this.tsmiSegundos3.Text = "(Test) 3 segundos";
            this.tsmiSegundos3.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // tsmiMinutos3
            // 
            this.tsmiMinutos3.Name = "tsmiMinutos3";
            this.tsmiMinutos3.Size = new System.Drawing.Size(167, 22);
            this.tsmiMinutos3.Tag = "180";
            this.tsmiMinutos3.Text = "3 minutos";
            this.tsmiMinutos3.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // tsmiMinutos5
            // 
            this.tsmiMinutos5.Name = "tsmiMinutos5";
            this.tsmiMinutos5.Size = new System.Drawing.Size(167, 22);
            this.tsmiMinutos5.Tag = "300";
            this.tsmiMinutos5.Text = "5 minutos";
            this.tsmiMinutos5.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // tsmiMinutos10
            // 
            this.tsmiMinutos10.Name = "tsmiMinutos10";
            this.tsmiMinutos10.Size = new System.Drawing.Size(167, 22);
            this.tsmiMinutos10.Tag = "600";
            this.tsmiMinutos10.Text = "10 minutos";
            this.tsmiMinutos10.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // tsmiMinutos20
            // 
            this.tsmiMinutos20.Name = "tsmiMinutos20";
            this.tsmiMinutos20.Size = new System.Drawing.Size(167, 22);
            this.tsmiMinutos20.Tag = "1200";
            this.tsmiMinutos20.Text = "20 minutos";
            this.tsmiMinutos20.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // tsmiMinutos30
            // 
            this.tsmiMinutos30.Name = "tsmiMinutos30";
            this.tsmiMinutos30.Size = new System.Drawing.Size(167, 22);
            this.tsmiMinutos30.Tag = "1800";
            this.tsmiMinutos30.Text = "30 minutos";
            this.tsmiMinutos30.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // tsmiMinutos45
            // 
            this.tsmiMinutos45.Name = "tsmiMinutos45";
            this.tsmiMinutos45.Size = new System.Drawing.Size(167, 22);
            this.tsmiMinutos45.Tag = "2700";
            this.tsmiMinutos45.Text = "45 minutos";
            this.tsmiMinutos45.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // tsmiHora1
            // 
            this.tsmiHora1.Name = "tsmiHora1";
            this.tsmiHora1.Size = new System.Drawing.Size(167, 22);
            this.tsmiHora1.Tag = "3600";
            this.tsmiHora1.Text = "1 hora";
            this.tsmiHora1.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // tsmiHora2
            // 
            this.tsmiHora2.Name = "tsmiHora2";
            this.tsmiHora2.Size = new System.Drawing.Size(167, 22);
            this.tsmiHora2.Tag = "7200";
            this.tsmiHora2.Text = "2 horas";
            this.tsmiHora2.Click += new System.EventHandler(this.tsmiMinutosPredeterminados);
            // 
            // frmTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(284, 77);
            this.Controls.Add(this.lblSegons);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudTemps);
            this.Controls.Add(this.menuTiemposPredeterminados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTiemposPredeterminados;
            this.Name = "frmTemporizador";
            this.Text = "Temporizador";
            ((System.ComponentModel.ISupportInitialize)(this.nudTemps)).EndInit();
            this.menuTiemposPredeterminados.ResumeLayout(false);
            this.menuTiemposPredeterminados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudTemps;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSegons;
        private System.Windows.Forms.Timer timerTemps;
        private System.Windows.Forms.MenuStrip menuTiemposPredeterminados;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemTiempos;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinutos3;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinutos5;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinutos10;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinutos20;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinutos30;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinutos45;
        private System.Windows.Forms.ToolStripMenuItem tsmiHora1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHora2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSegundos3;
    }
}

