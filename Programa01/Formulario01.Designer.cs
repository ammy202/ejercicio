namespace Programa01
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
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.btnDespedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Location = new System.Drawing.Point(339, 58);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(75, 23);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludo!!";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.BtnSaludo_Click);
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(70, 58);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(35, 13);
            this.lbMensaje.TabIndex = 1;
            this.lbMensaje.Text = "label1";
            // 
            // btnDespedida
            // 
            this.btnDespedida.Location = new System.Drawing.Point(339, 121);
            this.btnDespedida.Name = "btnDespedida";
            this.btnDespedida.Size = new System.Drawing.Size(75, 23);
            this.btnDespedida.TabIndex = 2;
            this.btnDespedida.Text = "Despedida";
            this.btnDespedida.UseVisualStyleBackColor = true;
            this.btnDespedida.Click += new System.EventHandler(this.BtnDespedida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 319);
            this.Controls.Add(this.btnDespedida);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.btnSaludo);
            this.Name = "Form1";
            this.Text = "Programa01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Button btnDespedida;
    }
}

