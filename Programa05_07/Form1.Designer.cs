namespace Programa05_07
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imglFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.picbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imglFotos
            // 
            this.imglFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglFotos.ImageStream")));
            this.imglFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglFotos.Images.SetKeyName(0, "divisor10.jpg");
            this.imglFotos.Images.SetKeyName(1, "divisor11.jpg");
            this.imglFotos.Images.SetKeyName(2, "estupenda_casa-pequyeña-porche.jpg");
            this.imglFotos.Images.SetKeyName(3, "Fachadas-de-Casas-p.jpg");
            this.imglFotos.Images.SetKeyName(4, "Fachadas-y-planos-d.jpg");
            this.imglFotos.Images.SetKeyName(5, "idealista_3_1.jpg");
            this.imglFotos.Images.SetKeyName(6, "pequeña.jpg");
            this.imglFotos.Images.SetKeyName(7, "pequeña1.jpg");
            this.imglFotos.Images.SetKeyName(8, "Bitmap1.bmp");
            // 
            // lblFoto
            // 
            this.lblFoto.ImageIndex = 0;
            this.lblFoto.ImageList = this.imglFotos;
            this.lblFoto.Location = new System.Drawing.Point(12, 9);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(100, 100);
            this.lblFoto.TabIndex = 0;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(15, 125);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(97, 23);
            this.btnCambiar.TabIndex = 1;
            this.btnCambiar.Text = "Cambiar imagen";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // picbImagen
            // 
            this.picbImagen.Location = new System.Drawing.Point(175, 13);
            this.picbImagen.Name = "picbImagen";
            this.picbImagen.Size = new System.Drawing.Size(100, 100);
            this.picbImagen.TabIndex = 2;
            this.picbImagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 302);
            this.Controls.Add(this.picbImagen);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imglFotos;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.PictureBox picbImagen;
    }
}

