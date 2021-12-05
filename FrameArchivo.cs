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
    public partial class FrameArchivo : Form
    {
        private FrameInicial frameInicial;
        private HostObject host;
        public FrameArchivo(FrameInicial frameInicial,HostObject host)
        {
            InitializeComponent();
            this.frameInicial = frameInicial;
            this.host = host;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            host.addArchivo(new ArchivoObject(textNombre.Text,textPath.Text));
            host.hostToArchivo(host);
            Close();
            frameInicial.cargarDatos();
            frameInicial.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            frameInicial.Show();
        }
    }
}
