
namespace Triaje
{
    partial class FramePools
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
            this.comboPools = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelHost = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboPools
            // 
            this.comboPools.FormattingEnabled = true;
            this.comboPools.Location = new System.Drawing.Point(3, 46);
            this.comboPools.Name = "comboPools";
            this.comboPools.Size = new System.Drawing.Size(267, 23);
            this.comboPools.TabIndex = 5;
            this.comboPools.SelectedIndexChanged += new System.EventHandler(this.comboPools_SelectedIndexChanged);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.AccessibleName = "buttonAgregar";
            this.buttonAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAgregar.Enabled = false;
            this.buttonAgregar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregar.Location = new System.Drawing.Point(370, 77);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(96, 32);
            this.buttonAgregar.TabIndex = 30;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(43, 137);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(157, 22);
            this.labelNombre.TabIndex = 28;
            this.labelNombre.Text = "[ Pool ] Nombre:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleName = "buttonCancelar";
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancelar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(271, 167);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 32);
            this.buttonCancelar.TabIndex = 27;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.AccessibleName = "buttonModificar";
            this.buttonModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonModificar.Enabled = false;
            this.buttonModificar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModificar.Location = new System.Drawing.Point(276, 43);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(96, 32);
            this.buttonModificar.TabIndex = 31;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "----------------------------------------------------------------------";
            // 
            // buttonCrear
            // 
            this.buttonCrear.AccessibleName = "buttonCancelar";
            this.buttonCrear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCrear.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCrear.Location = new System.Drawing.Point(138, 167);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(96, 32);
            this.buttonCrear.TabIndex = 33;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = false;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(74, 81);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(267, 23);
            this.textPass.TabIndex = 34;
            // 
            // labelPass
            // 
            this.labelPass.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPass.Location = new System.Drawing.Point(13, 82);
            this.labelPass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(52, 22);
            this.labelPass.TabIndex = 35;
            this.labelPass.Text = "Pass:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(236, 137);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(252, 23);
            this.textNombre.TabIndex = 37;
            // 
            // labelHost
            // 
            this.labelHost.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelHost.AutoSize = true;
            this.labelHost.BackColor = System.Drawing.Color.Black;
            this.labelHost.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHost.ForeColor = System.Drawing.Color.Lime;
            this.labelHost.Location = new System.Drawing.Point(151, 9);
            this.labelHost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(154, 22);
            this.labelHost.TabIndex = 39;
            this.labelHost.Text = "Nombre - 0.0.0.0";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.AccessibleName = "buttonEliminar";
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.Location = new System.Drawing.Point(391, 43);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(96, 32);
            this.buttonEliminar.TabIndex = 40;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // FramePools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(499, 211);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboPools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FramePools";
            this.Text = "FramePools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPools;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Button buttonEliminar;
    }
}