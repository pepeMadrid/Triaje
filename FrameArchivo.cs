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
        private HostObject host;
        public FrameArchivo(HostObject host)
        {
            InitializeComponent();
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
            
            new FramePrincipal().Show();
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            new FramePrincipal().Show();
            Close();
        }

        private void FrameArchivo_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
