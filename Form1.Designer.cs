
namespace Triaje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCreditos = new System.Windows.Forms.Label();
            this.buttonEmpezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(199, 39);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(380, 37);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Triaje y comparador de Hashes";
            // 
            // labelCreditos
            // 
            this.labelCreditos.AutoSize = true;
            this.labelCreditos.Location = new System.Drawing.Point(479, 515);
            this.labelCreditos.Name = "labelCreditos";
            this.labelCreditos.Size = new System.Drawing.Size(293, 37);
            this.labelCreditos.TabIndex = 1;
            this.labelCreditos.Text = "By Pepe Madrid Molina";
            // 
            // buttonEmpezar
            // 
            this.buttonEmpezar.AccessibleName = "buttonEmpezar";
            this.buttonEmpezar.Location = new System.Drawing.Point(311, 168);
            this.buttonEmpezar.Name = "buttonEmpezar";
            this.buttonEmpezar.Size = new System.Drawing.Size(143, 61);
            this.buttonEmpezar.TabIndex = 2;
            this.buttonEmpezar.Text = "Empezar";
            this.buttonEmpezar.UseVisualStyleBackColor = true;
            this.buttonEmpezar.Click += new System.EventHandler(this.buttonEmpezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonEmpezar);
            this.Controls.Add(this.labelCreditos);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCreditos;
        private System.Windows.Forms.Button buttonEmpezar;
    }
}

