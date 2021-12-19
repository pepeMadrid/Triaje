
namespace Triaje
{
    partial class FramePrincipal
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FramePrincipal));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonAddHost = new System.Windows.Forms.Button();
            this.labelCreditos = new System.Windows.Forms.Label();
            this.comboHosts = new System.Windows.Forms.ComboBox();
            this.buttonDeleteHost = new System.Windows.Forms.Button();
            this.listArchivos = new System.Windows.Forms.ListView();
            this.columnId = new System.Windows.Forms.ColumnHeader();
            this.columnNombre = new System.Windows.Forms.ColumnHeader();
            this.columnPath = new System.Windows.Forms.ColumnHeader();
            this.columnHash = new System.Windows.Forms.ColumnHeader();
            this.columnRemoteHash = new System.Windows.Forms.ColumnHeader();
            this.columnVerificado = new System.Windows.Forms.ColumnHeader();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.labelIP = new System.Windows.Forms.Label();
            this.buttonModificarHost = new System.Windows.Forms.Button();
            this.buttonPools = new System.Windows.Forms.Button();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(344, 9);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(101, 22);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Triaje v1.0";
            // 
            // buttonAddHost
            // 
            this.buttonAddHost.AccessibleName = "buttonAddHost";
            this.buttonAddHost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddHost.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddHost.Location = new System.Drawing.Point(12, 112);
            this.buttonAddHost.Name = "buttonAddHost";
            this.buttonAddHost.Size = new System.Drawing.Size(87, 32);
            this.buttonAddHost.TabIndex = 2;
            this.buttonAddHost.Text = "+ HOST";
            this.buttonAddHost.UseVisualStyleBackColor = false;
            this.buttonAddHost.Click += new System.EventHandler(this.buttonEmpezar_Click);
            // 
            // labelCreditos
            // 
            this.labelCreditos.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelCreditos.AutoSize = true;
            this.labelCreditos.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCreditos.Location = new System.Drawing.Point(595, 534);
            this.labelCreditos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCreditos.Name = "labelCreditos";
            this.labelCreditos.Size = new System.Drawing.Size(174, 18);
            this.labelCreditos.TabIndex = 3;
            this.labelCreditos.Text = "Pepe Madrid (F1rstree)";
            // 
            // comboHosts
            // 
            this.comboHosts.FormattingEnabled = true;
            this.comboHosts.Location = new System.Drawing.Point(12, 44);
            this.comboHosts.Name = "comboHosts";
            this.comboHosts.Size = new System.Drawing.Size(267, 45);
            this.comboHosts.TabIndex = 4;
            this.comboHosts.SelectedIndexChanged += new System.EventHandler(this.comboHosts_SelectedIndexChanged);
            this.comboHosts.Click += new System.EventHandler(this.comboHosts_Click);
            // 
            // buttonDeleteHost
            // 
            this.buttonDeleteHost.AccessibleName = "buttonDeleteHost";
            this.buttonDeleteHost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteHost.Enabled = false;
            this.buttonDeleteHost.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteHost.Location = new System.Drawing.Point(129, 112);
            this.buttonDeleteHost.Name = "buttonDeleteHost";
            this.buttonDeleteHost.Size = new System.Drawing.Size(87, 32);
            this.buttonDeleteHost.TabIndex = 5;
            this.buttonDeleteHost.Text = "- HOST";
            this.buttonDeleteHost.UseVisualStyleBackColor = false;
            this.buttonDeleteHost.Click += new System.EventHandler(this.buttonDeleteHost_Click);
            // 
            // listArchivos
            // 
            this.listArchivos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listArchivos.BackColor = System.Drawing.SystemColors.MenuText;
            this.listArchivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnNombre,
            this.columnPath,
            this.columnHash,
            this.columnRemoteHash,
            this.columnVerificado});
            this.listArchivos.Font = new System.Drawing.Font("Linux Biolinum G", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listArchivos.ForeColor = System.Drawing.Color.Lime;
            this.listArchivos.FullRowSelect = true;
            this.listArchivos.HideSelection = false;
            this.listArchivos.HoverSelection = true;
            this.listArchivos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listArchivos.Location = new System.Drawing.Point(12, 150);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.ShowItemToolTips = true;
            this.listArchivos.Size = new System.Drawing.Size(757, 368);
            this.listArchivos.TabIndex = 6;
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
            // columnHash
            // 
            this.columnHash.Text = "Hash";
            // 
            // columnRemoteHash
            // 
            this.columnRemoteHash.Text = "R.Hash";
            // 
            // columnVerificado
            // 
            this.columnVerificado.Text = "Verificado";
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.AccessibleName = "buttonAddFile";
            this.buttonAddFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddFile.Enabled = false;
            this.buttonAddFile.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddFile.Location = new System.Drawing.Point(462, 112);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(87, 32);
            this.buttonAddFile.TabIndex = 7;
            this.buttonAddFile.Text = "+ FILE";
            this.buttonAddFile.UseVisualStyleBackColor = false;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.AccessibleName = "buttonDeleteFile";
            this.buttonDeleteFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteFile.Enabled = false;
            this.buttonDeleteFile.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteFile.Location = new System.Drawing.Point(572, 112);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(87, 32);
            this.buttonDeleteFile.TabIndex = 8;
            this.buttonDeleteFile.Text = "- FILE";
            this.buttonDeleteFile.UseVisualStyleBackColor = false;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // labelIP
            // 
            this.labelIP.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelIP.AutoSize = true;
            this.labelIP.BackColor = System.Drawing.Color.Black;
            this.labelIP.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIP.ForeColor = System.Drawing.Color.Lime;
            this.labelIP.Location = new System.Drawing.Point(361, 46);
            this.labelIP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(65, 22);
            this.labelIP.TabIndex = 9;
            this.labelIP.Text = "0.0.0.0";
            // 
            // buttonModificarHost
            // 
            this.buttonModificarHost.AccessibleName = "buttonMoficarHost";
            this.buttonModificarHost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonModificarHost.Enabled = false;
            this.buttonModificarHost.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonModificarHost.Location = new System.Drawing.Point(242, 112);
            this.buttonModificarHost.Name = "buttonModificarHost";
            this.buttonModificarHost.Size = new System.Drawing.Size(87, 32);
            this.buttonModificarHost.TabIndex = 10;
            this.buttonModificarHost.Text = "* HOST";
            this.buttonModificarHost.UseVisualStyleBackColor = false;
            this.buttonModificarHost.Click += new System.EventHandler(this.buttonModificarHost_Click);
            // 
            // buttonPools
            // 
            this.buttonPools.AccessibleName = "buttonPools";
            this.buttonPools.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPools.Enabled = false;
            this.buttonPools.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPools.Location = new System.Drawing.Point(682, 112);
            this.buttonPools.Name = "buttonPools";
            this.buttonPools.Size = new System.Drawing.Size(87, 32);
            this.buttonPools.TabIndex = 11;
            this.buttonPools.Text = "Pools";
            this.buttonPools.UseVisualStyleBackColor = false;
            this.buttonPools.Click += new System.EventHandler(this.buttonPools_Click);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(511, 46);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(258, 43);
            this.textPass.TabIndex = 12;
            // 
            // buttonStart
            // 
            this.buttonStart.AccessibleName = "buttonStart";
            this.buttonStart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStart.Enabled = false;
            this.buttonStart.Font = new System.Drawing.Font("Linux Biolinum G", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(350, 85);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(95, 59);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "[CHECK]";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // FramePrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.buttonPools);
            this.Controls.Add(this.buttonModificarHost);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.buttonDeleteFile);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.listArchivos);
            this.Controls.Add(this.buttonDeleteHost);
            this.Controls.Add(this.comboHosts);
            this.Controls.Add(this.labelCreditos);
            this.Controls.Add(this.buttonAddHost);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FramePrincipal";
            this.Text = "Triaje - F1rstree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FramePrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FramePrincipal_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAddHost;
        private System.Windows.Forms.Label labelCreditos;
        private System.Windows.Forms.ComboBox comboHosts;
        private System.Windows.Forms.Button buttonDeleteHost;
        private System.Windows.Forms.ListView listArchivos;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Button buttonModificarHost;
        private System.Windows.Forms.Button buttonPools;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.ColumnHeader columnHash;
        private System.Windows.Forms.ColumnHeader columnRemoteHash;
        private System.Windows.Forms.ColumnHeader columnVerificado;
    }
}

