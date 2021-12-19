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
        private PoolObject pool;
        private HostObject host;
        public FramePool(PoolObject pool, HostObject host)
        {
            InitializeComponent();
            this.pool = pool;
            this.host = host;
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
            new FramePools(host).Show();
            Close();
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            //search por columna 2 "nombre"
            //Debug.WriteLine("*** " + listArchivos.SelectedItems[0].SubItems[1].Text +" - "+ listArchivos.SelectedItems.Count);
            if(listArchivos.SelectedItems.Count > 0)
            {
                for(int x=0;x < listArchivos.SelectedItems.Count; x++)
                {
                    //Debug.WriteLine("*** "+ listArchivos.SelectedItems[x].SubItems[1].Text);
                    pool.removeArchivo(listArchivos.SelectedItems[x].SubItems[1].Text);
                }
            }                    
            listViewRefresh();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            new FramePools(host).Show();
            Close();
        }
    }
}
