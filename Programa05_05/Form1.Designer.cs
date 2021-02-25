namespace Programa05_05
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
            this.listbFrutas = new System.Windows.Forms.ListBox();
            this.txtFrutas = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFrutas = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbFrutas
            // 
            this.listbFrutas.FormattingEnabled = true;
            this.listbFrutas.Items.AddRange(new object[] {
            "Manzana",
            "Aguacate",
            "Pera"});
            this.listbFrutas.Location = new System.Drawing.Point(28, 114);
            this.listbFrutas.Name = "listbFrutas";
            this.listbFrutas.Size = new System.Drawing.Size(147, 95);
            this.listbFrutas.TabIndex = 0;
            this.listbFrutas.SelectedIndexChanged += new System.EventHandler(this.ListbFrutas_SelectedIndexChanged);
            // 
            // txtFrutas
            // 
            this.txtFrutas.Location = new System.Drawing.Point(28, 12);
            this.txtFrutas.Name = "txtFrutas";
            this.txtFrutas.Size = new System.Drawing.Size(100, 20);
            this.txtFrutas.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(248, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblFrutas
            // 
            this.lblFrutas.AutoSize = true;
            this.lblFrutas.Location = new System.Drawing.Point(28, 56);
            this.lblFrutas.Name = "lblFrutas";
            this.lblFrutas.Size = new System.Drawing.Size(54, 13);
            this.lblFrutas.TabIndex = 4;
            this.lblFrutas.Text = "Selección";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(248, 45);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 306);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblFrutas);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFrutas);
            this.Controls.Add(this.listbFrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listbFrutas;
        private System.Windows.Forms.TextBox txtFrutas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFrutas;
        private System.Windows.Forms.Button btnEliminar;
    }
}

