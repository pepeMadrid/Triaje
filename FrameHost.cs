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
        private HostObject host;
        private int modo;//0 crear, 1 modificar
        public FrameHost(FramePrincipal frameInicial)
        {
            modo = 0;
            this.frameInicial = frameInicial;
            InitializeComponent();
        }
        public FrameHost(FramePrincipal frameInicial, HostObject host)
        {//si le pasamos el host significa que estamos modificando
            modo = 1;
            this.frameInicial = frameInicial;
            this.host = host;
            InitializeComponent();
            modoModificacion();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            FramePrincipal framePrincipal = new FramePrincipal();
            framePrincipal.Show();
        }
        private void modoModificacion()
        {
            textNombre.Text = host.getNombre();
            textIP.Text = host.getIP();
            textUser.Text = host.getUser();
            textNombre.Enabled = false;
        }
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (modo == 0)//creando
                host = new HostObject(textNombre.Text, textIP.Text, textUser.Text);
            else
            {//modificando
                host.setIP(textIP.Text);
                host.setUser(textUser.Text);
            }
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
