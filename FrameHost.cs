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
        private HostObject host;
        private int modo;//0 crear, 1 modificar
        public FrameHost()
        {
            modo = 0;
            InitializeComponent();
        }
        public FrameHost(HostObject host)
        {//si le pasamos el host significa que estamos modificando
            modo = 1;
            this.host = host;
            InitializeComponent();
            modoModificacion();
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            new FramePrincipal().Show();
            Close();
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
            
            new FramePrincipal().Show();
            Close();
        }

        private void FrameHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
