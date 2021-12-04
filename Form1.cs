using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Triaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            SshObject ssh = new SshObject("192.168.0.102", "mint", @"1234");
            ssh.descargarArchivo("/etc/passwd");

        }
    }
}
