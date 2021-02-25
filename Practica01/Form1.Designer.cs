namespace Practica01
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbSeguro = new System.Windows.Forms.GroupBox();
            this.rbTotal = new System.Windows.Forms.RadioButton();
            this.rbTerceros = new System.Windows.Forms.RadioButton();
            this.rbBasico = new System.Windows.Forms.RadioButton();
            this.gbEquipamiento = new System.Windows.Forms.GroupBox();
            this.chkSonido = new System.Windows.Forms.CheckBox();
            this.chkAire = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.gbSeguro.SuspendLayout();
            this.gbEquipamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // gbSeguro
            // 
            this.gbSeguro.Controls.Add(this.rbTotal);
            this.gbSeguro.Controls.Add(this.rbTerceros);
            this.gbSeguro.Controls.Add(this.rbBasico);
            this.gbSeguro.Location = new System.Drawing.Point(16, 68);
            this.gbSeguro.Name = "gbSeguro";
            this.gbSeguro.Size = new System.Drawing.Size(156, 108);
            this.gbSeguro.TabIndex = 2;
            this.gbSeguro.TabStop = false;
            this.gbSeguro.Text = "Tipo de Seguro";
            // 
            // rbTotal
            // 
            this.rbTotal.AutoSize = true;
            this.rbTotal.Location = new System.Drawing.Point(56, 75);
            this.rbTotal.Name = "rbTotal";
            this.rbTotal.Size = new System.Drawing.Size(49, 17);
            this.rbTotal.TabIndex = 2;
            this.rbTotal.TabStop = true;
            this.rbTotal.Text = "Total";
            this.rbTotal.UseVisualStyleBackColor = true;
            // 
            // rbTerceros
            // 
            this.rbTerceros.AutoSize = true;
            this.rbTerceros.Location = new System.Drawing.Point(56, 52);
            this.rbTerceros.Name = "rbTerceros";
            this.rbTerceros.Size = new System.Drawing.Size(73, 17);
            this.rbTerceros.TabIndex = 1;
            this.rbTerceros.Text = "A terceros";
            this.rbTerceros.UseVisualStyleBackColor = true;
            // 
            // rbBasico
            // 
            this.rbBasico.AutoSize = true;
            this.rbBasico.Checked = true;
            this.rbBasico.Location = new System.Drawing.Point(56, 29);
            this.rbBasico.Name = "rbBasico";
            this.rbBasico.Size = new System.Drawing.Size(57, 17);
            this.rbBasico.TabIndex = 0;
            this.rbBasico.TabStop = true;
            this.rbBasico.Text = "Básico";
            this.rbBasico.UseVisualStyleBackColor = true;
            // 
            // gbEquipamiento
            // 
            this.gbEquipamiento.Controls.Add(this.chkSonido);
            this.gbEquipamiento.Controls.Add(this.chkAire);
            this.gbEquipamiento.Location = new System.Drawing.Point(257, 68);
            this.gbEquipamiento.Name = "gbEquipamiento";
            this.gbEquipamiento.Size = new System.Drawing.Size(163, 108);
            this.gbEquipamiento.TabIndex = 3;
            this.gbEquipamiento.TabStop = false;
            this.gbEquipamiento.Text = "Equipamiento";
            // 
            // chkSonido
            // 
            this.chkSonido.AutoSize = true;
            this.chkSonido.Location = new System.Drawing.Point(40, 53);
            this.chkSonido.Name = "chkSonido";
            this.chkSonido.Size = new System.Drawing.Size(112, 17);
            this.chkSonido.TabIndex = 1;
            this.chkSonido.Text = "Sistema de sonido";
            this.chkSonido.UseVisualStyleBackColor = true;
            // 
            // chkAire
            // 
            this.chkAire.AutoSize = true;
            this.chkAire.Location = new System.Drawing.Point(40, 29);
            this.chkAire.Name = "chkAire";
            this.chkAire.Size = new System.Drawing.Size(117, 17);
            this.chkAire.TabIndex = 0;
            this.chkAire.Text = "Aire acondicionado";
            this.chkAire.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(16, 212);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(72, 204);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 5;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(257, 204);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 23);
            this.btnCotizar.TabIndex = 6;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.BtnCotizar_Click);
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Location = new System.Drawing.Point(19, 249);
            this.txtCotizacion.Multiline = true;
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(395, 143);
            this.txtCotizacion.TabIndex = 7;
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(162, 407);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(94, 40);
            this.btnNueva.TabIndex = 8;
            this.btnNueva.Text = "Nueva cotización";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.BtnNueva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 459);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.gbEquipamiento);
            this.Controls.Add(this.gbSeguro);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSeguro.ResumeLayout(false);
            this.gbSeguro.PerformLayout();
            this.gbEquipamiento.ResumeLayout(false);
            this.gbEquipamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gbSeguro;
        private System.Windows.Forms.RadioButton rbTotal;
        private System.Windows.Forms.RadioButton rbTerceros;
        private System.Windows.Forms.RadioButton rbBasico;
        private System.Windows.Forms.GroupBox gbEquipamiento;
        private System.Windows.Forms.CheckBox chkSonido;
        private System.Windows.Forms.CheckBox chkAire;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox txtCotizacion;
        private System.Windows.Forms.Button btnNueva;
    }
}

