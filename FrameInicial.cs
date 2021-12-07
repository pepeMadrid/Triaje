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
    public partial class FrameInicial : Form
    {
        public FrameInicial()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Hide();
            FramePrincipal framePrincipal = new FramePrincipal();
            framePrincipal.Show();
        }
    }
}
