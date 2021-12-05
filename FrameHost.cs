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
        private FrameInicial frameInicial;
        public FrameHost(FrameInicial frameInicial)
        {
            this.frameInicial = frameInicial;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            frameInicial.Show();

        }

        private void FrameHost_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Close();
            frameInicial.Show();
        }

        private void FrameHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            frameInicial.Show();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            HostObject host = new HostObject(textNombre.Text,textIP.Text,textUser.Text);
            host.hostToArchivo(host);
            Close();
            frameInicial.cargarDatos();
            frameInicial.Show();
        }
    }
}
