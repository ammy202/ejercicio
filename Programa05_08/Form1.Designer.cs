namespace Programa05_08
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
            this.listvAlimentos = new System.Windows.Forms.ListView();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.gbGrupos = new System.Windows.Forms.GroupBox();
            this.rbCarnes = new System.Windows.Forms.RadioButton();
            this.rbFrutas = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbGrupos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listvAlimentos
            // 
            this.listvAlimentos.HideSelection = false;
            this.listvAlimentos.Location = new System.Drawing.Point(12, 12);
            this.listvAlimentos.Name = "listvAlimentos";
            this.listvAlimentos.Size = new System.Drawing.Size(469, 217);
            this.listvAlimentos.TabIndex = 0;
            this.listvAlimentos.UseCompatibleStateImageBehavior = false;
            this.listvAlimentos.View = System.Windows.Forms.View.SmallIcon;
            this.listvAlimentos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListvAlimentos_MouseClick);
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(12, 235);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 20);
            this.txtElemento.TabIndex = 1;
            // 
            // gbGrupos
            // 
            this.gbGrupos.Controls.Add(this.rbCarnes);
            this.gbGrupos.Controls.Add(this.rbFrutas);
            this.gbGrupos.Controls.Add(this.btnAgregar);
            this.gbGrupos.Location = new System.Drawing.Point(244, 235);
            this.gbGrupos.Name = "gbGrupos";
            this.gbGrupos.Size = new System.Drawing.Size(278, 43);
            this.gbGrupos.TabIndex = 2;
            this.gbGrupos.TabStop = false;
            this.gbGrupos.Text = "Grupos";
            // 
            // rbCarnes
            // 
            this.rbCarnes.AutoSize = true;
            this.rbCarnes.Location = new System.Drawing.Point(87, 20);
            this.rbCarnes.Name = "rbCarnes";
            this.rbCarnes.Size = new System.Drawing.Size(58, 17);
            this.rbCarnes.TabIndex = 1;
            this.rbCarnes.TabStop = true;
            this.rbCarnes.Text = "Carnes";
            this.rbCarnes.UseVisualStyleBackColor = true;
            // 
            // rbFrutas
            // 
            this.rbFrutas.AutoSize = true;
            this.rbFrutas.Checked = true;
            this.rbFrutas.Location = new System.Drawing.Point(7, 20);
            this.rbFrutas.Name = "rbFrutas";
            this.rbFrutas.Size = new System.Drawing.Size(54, 17);
            this.rbFrutas.TabIndex = 0;
            this.rbFrutas.TabStop = true;
            this.rbFrutas.Text = "Frutas";
            this.rbFrutas.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(197, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Location = new System.Drawing.Point(525, 29);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(57, 13);
            this.lblSeleccionado.TabIndex = 4;
            this.lblSeleccionado.Text = "Selección ";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(528, 60);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(12, 262);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 6;
            this.txtImagen.Text = "0";
            this.txtImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(118, 235);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(528, 90);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 289);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.gbGrupos);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.listvAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGrupos.ResumeLayout(false);
            this.gbGrupos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listvAlimentos;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.GroupBox gbGrupos;
        private System.Windows.Forms.RadioButton rbCarnes;
        private System.Windows.Forms.RadioButton rbFrutas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblSeleccionado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBorrar;
    }
}

