
namespace Triaje
{
    partial class FrameInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameInfo));
            this.textInfo = new System.Windows.Forms.RichTextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textInfo
            // 
            this.textInfo.AccessibleName = "TextInfo";
            this.textInfo.Enabled = false;
            this.textInfo.Location = new System.Drawing.Point(27, 20);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(529, 276);
            this.textInfo.TabIndex = 0;
            this.textInfo.Text = "";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.AccessibleName = "buttonAceptar";
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAceptar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAceptar.Location = new System.Drawing.Point(234, 302);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(109, 47);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FrameInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrameInfo";
            this.Text = "FrameInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textInfo;
        private System.Windows.Forms.Button buttonAceptar;
    }
}