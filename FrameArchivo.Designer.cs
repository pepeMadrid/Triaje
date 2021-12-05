
namespace Triaje
{
    partial class FrameArchivo
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
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTituloArchivo = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.AccessibleName = "buttonAceptar";
            this.buttonAceptar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAceptar.Location = new System.Drawing.Point(39, 160);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(96, 32);
            this.buttonAceptar.TabIndex = 18;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textPath
            // 
            this.textPath.AccessibleName = "textIP";
            this.textPath.Location = new System.Drawing.Point(132, 113);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(250, 23);
            this.textPath.TabIndex = 17;
            // 
            // labelIP
            // 
            this.labelIP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIP.Location = new System.Drawing.Point(25, 111);
            this.labelIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(64, 22);
            this.labelIP.TabIndex = 16;
            this.labelIP.Text = "PATH:";
            // 
            // textNombre
            // 
            this.textNombre.AccessibleName = "textNombre";
            this.textNombre.Location = new System.Drawing.Point(132, 59);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(250, 23);
            this.textNombre.TabIndex = 15;
            // 
            // labelNombre
            // 
            this.labelNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(15, 57);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 22);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelTituloArchivo
            // 
            this.labelTituloArchivo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelTituloArchivo.AutoSize = true;
            this.labelTituloArchivo.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloArchivo.Location = new System.Drawing.Point(161, 9);
            this.labelTituloArchivo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTituloArchivo.Name = "labelTituloArchivo";
            this.labelTituloArchivo.Size = new System.Drawing.Size(42, 22);
            this.labelTituloArchivo.TabIndex = 13;
            this.labelTituloArchivo.Text = "File";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleName = "buttonCancelar";
            this.buttonCancelar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(236, 160);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 32);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrameArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 208);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTituloArchivo);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "FrameArchivo";
            this.Text = "FrameArchivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTituloArchivo;
        private System.Windows.Forms.Button buttonCancelar;
    }
}