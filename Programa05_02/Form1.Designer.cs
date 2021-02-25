namespace Programa05_02
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
            this.cmbAlimentos = new System.Windows.Forms.ComboBox();
            this.txtAlimentos = new System.Windows.Forms.TextBox();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAlimentos
            // 
            this.cmbAlimentos.FormattingEnabled = true;
            this.cmbAlimentos.Items.AddRange(new object[] {
            "Harina",
            "Pasta"});
            this.cmbAlimentos.Location = new System.Drawing.Point(40, 32);
            this.cmbAlimentos.Name = "cmbAlimentos";
            this.cmbAlimentos.Size = new System.Drawing.Size(121, 21);
            this.cmbAlimentos.TabIndex = 0;
            this.cmbAlimentos.Text = "Alimentos";
            this.cmbAlimentos.SelectedIndexChanged += new System.EventHandler(this.CmbAlimentos_SelectedIndexChanged);
            // 
            // txtAlimentos
            // 
            this.txtAlimentos.Location = new System.Drawing.Point(40, 140);
            this.txtAlimentos.Name = "txtAlimentos";
            this.txtAlimentos.Size = new System.Drawing.Size(100, 20);
            this.txtAlimentos.TabIndex = 1;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Location = new System.Drawing.Point(40, 91);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(16, 13);
            this.lblIndice.TabIndex = 3;
            this.lblIndice.Text = "Id";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(282, 90);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(85, 13);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "Tipo de alimento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(285, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 280);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.txtAlimentos);
            this.Controls.Add(this.cmbAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAlimentos;
        private System.Windows.Forms.TextBox txtAlimentos;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnAgregar;
    }
}

