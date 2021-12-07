
namespace Triaje
{
    partial class FrameHost
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
            System.Windows.Forms.Label labelUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameHost));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelTituloHost = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            labelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            labelUser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            labelUser.AutoSize = true;
            labelUser.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelUser.Location = new System.Drawing.Point(38, 176);
            labelUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelUser.Name = "labelUser";
            labelUser.Size = new System.Drawing.Size(55, 22);
            labelUser.TabIndex = 9;
            labelUser.Text = "User:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleName = "buttonCancelar";
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancelar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(299, 239);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 32);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelTituloHost
            // 
            this.labelTituloHost.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelTituloHost.AutoSize = true;
            this.labelTituloHost.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloHost.Location = new System.Drawing.Point(205, 9);
            this.labelTituloHost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTituloHost.Name = "labelTituloHost";
            this.labelTituloHost.Size = new System.Drawing.Size(51, 22);
            this.labelTituloHost.TabIndex = 4;
            this.labelTituloHost.Text = "Host";
            // 
            // labelNombre
            // 
            this.labelNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(28, 67);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(87, 22);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre:";
            // 
            // textNombre
            // 
            this.textNombre.AccessibleName = "textNombre";
            this.textNombre.Location = new System.Drawing.Point(157, 69);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(250, 23);
            this.textNombre.TabIndex = 6;
            // 
            // textIP
            // 
            this.textIP.AccessibleName = "textIP";
            this.textIP.Location = new System.Drawing.Point(157, 123);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(250, 23);
            this.textIP.TabIndex = 8;
            // 
            // labelIP
            // 
            this.labelIP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIP.Location = new System.Drawing.Point(50, 121);
            this.labelIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(34, 22);
            this.labelIP.TabIndex = 7;
            this.labelIP.Text = "IP:";
            // 
            // textUser
            // 
            this.textUser.AccessibleName = "textUser";
            this.textUser.Location = new System.Drawing.Point(157, 178);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(250, 23);
            this.textUser.TabIndex = 10;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.AccessibleName = "buttonAceptar";
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAceptar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAceptar.Location = new System.Drawing.Point(90, 239);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(96, 32);
            this.buttonAceptar.TabIndex = 11;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FrameHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textUser);
            this.Controls.Add(labelUser);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTituloHost);
            this.Controls.Add(this.buttonCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrameHost";
            this.Text = "Host";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrameHost_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelTituloHost;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonAceptar;
    }
}