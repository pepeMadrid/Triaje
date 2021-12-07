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
        private FramePrincipal frameInicial;
        private HostObject host;
        public FrameArchivo(FramePrincipal frameInicial,HostObject host)
        {
            InitializeComponent();
            this.frameInicial = frameInicial;
            this.host = host;

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            int error = host.descargarArchivo(textPath.Text,textPass.Text,textNombre.Text);
            if (error == 0)
            {//archivo descargado sin errores
                host.addArchivo(new ArchivoObject(textNombre.Text, textPath.Text));
                host.hostToArchivo(host);
            }
            Close();
            FramePrincipal framePrincipal = new FramePrincipal();
            framePrincipal.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            FramePrincipal framePrincipal = new FramePrincipal();
            framePrincipal.Show();
        }

        private void FrameArchivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
