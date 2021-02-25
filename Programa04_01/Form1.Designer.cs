namespace Programa04_01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tmrPrueba = new System.Windows.Forms.Timer(this.components);
            this.lblValor = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.trbIntervalo = new System.Windows.Forms.TrackBar();
            this.pgbTrabajo = new System.Windows.Forms.ProgressBar();
            this.lblTvalor = new System.Windows.Forms.Label();
            this.btnControl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrPrueba
            // 
            this.tmrPrueba.Tick += new System.EventHandler(this.TmrPrueba_Tick);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(54, 47);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(30, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Time";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(209, 47);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(209, 76);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 23);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // trbIntervalo
            // 
            this.trbIntervalo.Location = new System.Drawing.Point(31, 152);
            this.trbIntervalo.Maximum = 1000;
            this.trbIntervalo.Minimum = 100;
            this.trbIntervalo.Name = "trbIntervalo";
            this.trbIntervalo.Size = new System.Drawing.Size(302, 45);
            this.trbIntervalo.TabIndex = 3;
            this.trbIntervalo.TickFrequency = 100;
            this.trbIntervalo.Value = 100;
            this.trbIntervalo.Scroll += new System.EventHandler(this.TrbIntervalo_Scroll);
            // 
            // pgbTrabajo
            // 
            this.pgbTrabajo.Location = new System.Drawing.Point(31, 203);
            this.pgbTrabajo.Name = "pgbTrabajo";
            this.pgbTrabajo.Size = new System.Drawing.Size(302, 23);
            this.pgbTrabajo.TabIndex = 5;
            this.pgbTrabajo.Click += new System.EventHandler(this.PgbTrabajo_Click);
            // 
            // lblTvalor
            // 
            this.lblTvalor.AutoSize = true;
            this.lblTvalor.Location = new System.Drawing.Point(165, 271);
            this.lblTvalor.Name = "lblTvalor";
            this.lblTvalor.Size = new System.Drawing.Size(35, 13);
            this.lblTvalor.TabIndex = 4;
            this.lblTvalor.Text = "label1";
            this.lblTvalor.Click += new System.EventHandler(this.LblTvalor_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(208, 324);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(75, 23);
            this.btnControl.TabIndex = 6;
            this.btnControl.Text = "Control";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.BtnControl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 393);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.pgbTrabajo);
            this.Controls.Add(this.lblTvalor);
            this.Controls.Add(this.trbIntervalo);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrPrueba;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.TrackBar trbIntervalo;
        private System.Windows.Forms.ProgressBar pgbTrabajo;
        private System.Windows.Forms.Label lblTvalor;
        private System.Windows.Forms.Button btnControl;
    }
}

