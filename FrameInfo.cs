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
    public partial class FrameInfo : Form
    {
        private FramePrincipal framePrincipal;
        public FrameInfo(FramePrincipal framePrincipal, string info)
        {
            InitializeComponent();
            this.framePrincipal = framePrincipal;
            textInfo.Text = info;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            new FramePrincipal().Show();
            Close();
        }
    }
}
