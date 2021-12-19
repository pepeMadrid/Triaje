using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triaje
{
    public partial class FramePool : Form
    {
        private FramePools framePools;
        private PoolObject pool;
        public FramePool(FramePools framePools, PoolObject pool)
        {
            InitializeComponent();
            this.framePools = framePools;
            this.pool = pool;
            inicializarDatos();
        }

        private void inicializarDatos()
        {
            textPoolNombre.Text = pool.getNombre();
            
            listViewRefresh();
        }
        private void listViewRefresh()
        {
            listArchivos.Items.Clear();
            int x = 1;
            foreach (ArchivoObject archivo in pool.getPool())
            {
                listArchivos.Items.Add(new ListViewItem(new[] { x + "", archivo.getNombre(), archivo.getPath() }));
                x++;
            }
        }


        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            pool.addArchivo(new ArchivoObject(textNombre.Text, textPath.Text));
            listViewRefresh();
            textNombre.Text = "";
            textPath.Text = "";
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            pool.poolToArchivo(pool);
            new FramePools(framePools.framePrincipal).Show();
            Close();
        }
    }
}
