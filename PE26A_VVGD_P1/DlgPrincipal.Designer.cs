namespace PE26A_VVGD_P1
{
    partial class DlgPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPrincipal));
            this.TituloGradoFarenheit = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTNMesaPracticas1 = new System.Windows.Forms.Button();
            this.BTNMesaPracticas3 = new System.Windows.Forms.Button();
            this.BTNMesaPracticas2 = new System.Windows.Forms.Button();
            this.BTNMesaPracticas4 = new System.Windows.Forms.Button();
            this.LblTimer = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BackGroundMusica = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.BtnPanCompleta = new System.Windows.Forms.Button();
            this.LblFecha = new System.Windows.Forms.Label();
            this.PnlBackMusica = new System.Windows.Forms.Panel();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.PanelBackOpacity = new System.Windows.Forms.Panel();
            this.BtnElegirCancion = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.BarNavBrave = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.BackGroundMusica.SuspendLayout();
            this.PanelBackOpacity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloGradoFarenheit
            // 
            resources.ApplyResources(this.TituloGradoFarenheit, "TituloGradoFarenheit");
            this.TituloGradoFarenheit.Name = "TituloGradoFarenheit";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zzToolStripMenuItem,
            this.holaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // zzToolStripMenuItem
            // 
            this.zzToolStripMenuItem.Name = "zzToolStripMenuItem";
            resources.ApplyResources(this.zzToolStripMenuItem, "zzToolStripMenuItem");
            // 
            // holaToolStripMenuItem
            // 
            this.holaToolStripMenuItem.Name = "holaToolStripMenuItem";
            resources.ApplyResources(this.holaToolStripMenuItem, "holaToolStripMenuItem");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTNMesaPracticas1
            // 
            resources.ApplyResources(this.BTNMesaPracticas1, "BTNMesaPracticas1");
            this.BTNMesaPracticas1.BackColor = System.Drawing.Color.Transparent;
            this.BTNMesaPracticas1.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.File1;
            this.BTNMesaPracticas1.FlatAppearance.BorderSize = 0;
            this.BTNMesaPracticas1.Name = "BTNMesaPracticas1";
            this.BTNMesaPracticas1.UseVisualStyleBackColor = false;
            this.BTNMesaPracticas1.Click += new System.EventHandler(this.BTNMesaPracticas1_Click);
            // 
            // BTNMesaPracticas3
            // 
            resources.ApplyResources(this.BTNMesaPracticas3, "BTNMesaPracticas3");
            this.BTNMesaPracticas3.BackColor = System.Drawing.Color.Transparent;
            this.BTNMesaPracticas3.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.File1;
            this.BTNMesaPracticas3.FlatAppearance.BorderSize = 0;
            this.BTNMesaPracticas3.Name = "BTNMesaPracticas3";
            this.BTNMesaPracticas3.UseVisualStyleBackColor = false;
            this.BTNMesaPracticas3.Click += new System.EventHandler(this.BTNMesaPracticas3_Click);
            // 
            // BTNMesaPracticas2
            // 
            resources.ApplyResources(this.BTNMesaPracticas2, "BTNMesaPracticas2");
            this.BTNMesaPracticas2.BackColor = System.Drawing.Color.Transparent;
            this.BTNMesaPracticas2.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.File1;
            this.BTNMesaPracticas2.FlatAppearance.BorderSize = 0;
            this.BTNMesaPracticas2.ForeColor = System.Drawing.Color.Transparent;
            this.BTNMesaPracticas2.Name = "BTNMesaPracticas2";
            this.BTNMesaPracticas2.UseVisualStyleBackColor = false;
            this.BTNMesaPracticas2.Click += new System.EventHandler(this.BTNMesaPracticas2_Click);
            // 
            // BTNMesaPracticas4
            // 
            resources.ApplyResources(this.BTNMesaPracticas4, "BTNMesaPracticas4");
            this.BTNMesaPracticas4.BackColor = System.Drawing.Color.Transparent;
            this.BTNMesaPracticas4.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.File1;
            this.BTNMesaPracticas4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNMesaPracticas4.FlatAppearance.BorderSize = 0;
            this.BTNMesaPracticas4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTNMesaPracticas4.Name = "BTNMesaPracticas4";
            this.BTNMesaPracticas4.UseVisualStyleBackColor = false;
            this.BTNMesaPracticas4.Click += new System.EventHandler(this.BTNMesaPracticas4_Click);
            // 
            // LblTimer
            // 
            resources.ApplyResources(this.LblTimer, "LblTimer");
            this.LblTimer.BackColor = System.Drawing.Color.Transparent;
            this.LblTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Click += new System.EventHandler(this.LblTimer_Click);
            // 
            // BtnSalir
            // 
            resources.ApplyResources(this.BtnSalir, "BtnSalir");
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.Mundos_Click);
            // 
            // BackGroundMusica
            // 
            this.BackGroundMusica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackGroundMusica.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.BarraBrave;
            resources.ApplyResources(this.BackGroundMusica, "BackGroundMusica");
            this.BackGroundMusica.Controls.Add(this.btnMinimizar);
            this.BackGroundMusica.Controls.Add(this.BtnPanCompleta);
            this.BackGroundMusica.Controls.Add(this.BtnSalir);
            this.BackGroundMusica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BackGroundMusica.Name = "BackGroundMusica";
            this.BackGroundMusica.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.BackGroundMusica.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackGroundMusica_MouseDown);
            this.BackGroundMusica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackGroundMusica_MouseMove);
            this.BackGroundMusica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BackGroundMusica_MouseUp);
            // 
            // btnMinimizar
            // 
            resources.ApplyResources(this.btnMinimizar, "btnMinimizar");
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // BtnPanCompleta
            // 
            resources.ApplyResources(this.BtnPanCompleta, "BtnPanCompleta");
            this.BtnPanCompleta.BackColor = System.Drawing.Color.Transparent;
            this.BtnPanCompleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPanCompleta.FlatAppearance.BorderSize = 0;
            this.BtnPanCompleta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPanCompleta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPanCompleta.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPanCompleta.Name = "BtnPanCompleta";
            this.BtnPanCompleta.UseVisualStyleBackColor = false;
            this.BtnPanCompleta.Click += new System.EventHandler(this.BtnPanCompleta_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.LblFecha, "LblFecha");
            this.LblFecha.Name = "LblFecha";
            // 
            // PnlBackMusica
            // 
            resources.ApplyResources(this.PnlBackMusica, "PnlBackMusica");
            this.PnlBackMusica.BackColor = System.Drawing.Color.Transparent;
            this.PnlBackMusica.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.PortadaMusica;
            this.PnlBackMusica.ForeColor = System.Drawing.SystemColors.Control;
            this.PnlBackMusica.Name = "PnlBackMusica";
            this.PnlBackMusica.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnPause
            // 
            resources.ApplyResources(this.BtnPause, "BtnPause");
            this.BtnPause.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.IconoPausa;
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnPlay
            // 
            resources.ApplyResources(this.BtnPlay, "BtnPlay");
            this.BtnPlay.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlay.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.IconoPlay;
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // PanelBackOpacity
            // 
            resources.ApplyResources(this.PanelBackOpacity, "PanelBackOpacity");
            this.PanelBackOpacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelBackOpacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBackOpacity.Controls.Add(this.BtnElegirCancion);
            this.PanelBackOpacity.Controls.Add(this.axWindowsMediaPlayer1);
            this.PanelBackOpacity.Controls.Add(this.BarNavBrave);
            this.PanelBackOpacity.Controls.Add(this.BtnPause);
            this.PanelBackOpacity.Controls.Add(this.PnlBackMusica);
            this.PanelBackOpacity.Controls.Add(this.BtnPlay);
            this.PanelBackOpacity.Controls.Add(this.LblFecha);
            this.PanelBackOpacity.Controls.Add(this.BackGroundMusica);
            this.PanelBackOpacity.Controls.Add(this.LblTimer);
            this.PanelBackOpacity.Controls.Add(this.BTNMesaPracticas4);
            this.PanelBackOpacity.Controls.Add(this.BTNMesaPracticas2);
            this.PanelBackOpacity.Controls.Add(this.BTNMesaPracticas3);
            this.PanelBackOpacity.Controls.Add(this.BTNMesaPracticas1);
            this.PanelBackOpacity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PanelBackOpacity.Name = "PanelBackOpacity";
            this.PanelBackOpacity.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackOpacity_Paint);
            // 
            // BtnElegirCancion
            // 
            resources.ApplyResources(this.BtnElegirCancion, "BtnElegirCancion");
            this.BtnElegirCancion.BackColor = System.Drawing.Color.Transparent;
            this.BtnElegirCancion.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.ListaMusica;
            this.BtnElegirCancion.Name = "BtnElegirCancion";
            this.BtnElegirCancion.UseVisualStyleBackColor = false;
            this.BtnElegirCancion.Click += new System.EventHandler(this.BtnElegirCancion_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            resources.ApplyResources(this.axWindowsMediaPlayer1, "axWindowsMediaPlayer1");
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            // 
            // BarNavBrave
            // 
            resources.ApplyResources(this.BarNavBrave, "BarNavBrave");
            this.BarNavBrave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BarNavBrave.BackgroundImage = global::PE26A_VVGD_P1.Properties.Resources.BarNavBrave;
            this.BarNavBrave.Name = "BarNavBrave";
            // 
            // DlgPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.PanelBackOpacity);
            this.Controls.Add(this.TituloGradoFarenheit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgPrincipal";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Load += new System.EventHandler(this.DlgPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.BackGroundMusica.ResumeLayout(false);
            this.PanelBackOpacity.ResumeLayout(false);
            this.PanelBackOpacity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TituloGradoFarenheit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTNMesaPracticas1;
        private System.Windows.Forms.Button BTNMesaPracticas3;
        private System.Windows.Forms.Button BTNMesaPracticas2;
        private System.Windows.Forms.Button BTNMesaPracticas4;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel BackGroundMusica;
        private System.Windows.Forms.Panel PnlBackMusica;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel PanelBackOpacity;
        private System.Windows.Forms.Panel BarNavBrave;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button BtnPanCompleta;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button BtnElegirCancion;
    }
}

