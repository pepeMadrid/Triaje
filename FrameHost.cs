using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triaje
{
    public partial class FrameHost : Form
    {
        private FramePrincipal frameInicial;
        public FrameHost(FramePrincipal frameInicial)
        {
            this.frameInicial = frameInicial;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            FramePrincipal framePrincipal = new FramePrincipal();
            framePrincipal.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            HostObject host = new HostObject(textNombre.Text,textIP.Text,textUser.Text);
            host.hostToArchivo(host);
            Close();
            FramePrincipal framePrincipal = new FramePrincipal();
            framePrincipal.Show();

        }

        private void FrameHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
