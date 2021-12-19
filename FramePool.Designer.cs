
namespace Triaje
{
    partial class FramePool
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPoolNombre = new System.Windows.Forms.TextBox();
            this.listArchivos = new System.Windows.Forms.ListView();
            this.columnId = new System.Windows.Forms.ColumnHeader();
            this.columnNombre = new System.Windows.Forms.ColumnHeader();
            this.columnPath = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.AccessibleName = "buttonAceptar";
            this.buttonAceptar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAceptar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAceptar.Location = new System.Drawing.Point(12, 344);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(96, 32);
            this.buttonAceptar.TabIndex = 26;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textPath
            // 
            this.textPath.AccessibleName = "textIP";
            this.textPath.Location = new System.Drawing.Point(257, 110);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(250, 23);
            this.textPath.TabIndex = 25;
            // 
            // labelIP
            // 
            this.labelIP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIP.Location = new System.Drawing.Point(172, 108);
            this.labelIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(64, 22);
            this.labelIP.TabIndex = 24;
            this.labelIP.Text = "PATH:";
            // 
            // textNombre
            // 
            this.textNombre.AccessibleName = "textNombre";
            this.textNombre.Location = new System.Drawing.Point(257, 67);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(250, 23);
            this.textNombre.TabIndex = 23;
            // 
            // labelNombre
            // 
            this.labelNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(87, 65);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(150, 22);
            this.labelNombre.TabIndex = 22;
            this.labelNombre.Text = "[ File ] Nombre:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.AccessibleName = "buttonCancelar";
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCancelar.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(543, 344);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(96, 32);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "[ Pool ] Nombre:";
            // 
            // textPoolNombre
            // 
            this.textPoolNombre.AccessibleName = "textPoolNombre";
            this.textPoolNombre.Enabled = false;
            this.textPoolNombre.Location = new System.Drawing.Point(257, 11);
            this.textPoolNombre.Name = "textPoolNombre";
            this.textPoolNombre.Size = new System.Drawing.Size(250, 23);
            this.textPoolNombre.TabIndex = 30;
            // 
            // listArchivos
            // 
            this.listArchivos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listArchivos.BackColor = System.Drawing.SystemColors.MenuText;
            this.listArchivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnNombre,
            this.columnPath});
            this.listArchivos.Font = new System.Drawing.Font("Linux Biolinum G", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listArchivos.ForeColor = System.Drawing.Color.Lime;
            this.listArchivos.FullRowSelect = true;
            this.listArchivos.HideSelection = false;
            this.listArchivos.HoverSelection = true;
            this.listArchivos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listArchivos.Location = new System.Drawing.Point(13, 139);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.ShowItemToolTips = true;
            this.listArchivos.Size = new System.Drawing.Size(644, 199);
            this.listArchivos.TabIndex = 31;
            this.listArchivos.TileSize = new System.Drawing.Size(50, 50);
            this.listArchivos.UseCompatibleStateImageBehavior = false;
            this.listArchivos.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            // 
            // columnPath
            // 
            this.columnPath.Text = "Path";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(668, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "-------------";
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.AccessibleName = "buttonDeleteFile";
            this.buttonDeleteFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteFile.Enabled = false;
            this.buttonDeleteFile.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteFile.Location = new System.Drawing.Point(543, 103);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(87, 32);
            this.buttonDeleteFile.TabIndex = 34;
            this.buttonDeleteFile.Text = "- FILE";
            this.buttonDeleteFile.UseVisualStyleBackColor = false;
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.AccessibleName = "buttonAddFile";
            this.buttonAddFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddFile.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddFile.Location = new System.Drawing.Point(543, 60);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(87, 32);
            this.buttonAddFile.TabIndex = 33;
            this.buttonAddFile.Text = "+ FILE";
            this.buttonAddFile.UseVisualStyleBackColor = false;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // FramePoolModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 388);
            this.Controls.Add(this.buttonDeleteFile);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listArchivos);
            this.Controls.Add(this.textPoolNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Name = "FramePoolModificar";
            this.Text = "FramePools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPoolNombre;
        private System.Windows.Forms.ListView listArchivos;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.Button buttonAddFile;
    }
}