using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triaje
{
    public partial class FramePools : Form
    {
        public FramePrincipal framePrincipal;
        private ArrayList pools = new ArrayList();
        public FramePools(FramePrincipal framePrincipal )
        {
            InitializeComponent();
            this.framePrincipal = framePrincipal;
            cargarDatos();
        }

        public void cargarDatos()
        {

            string[] dirs = Directory.GetFiles(Application.UserAppDataPath, "*", SearchOption.AllDirectories);
            int x = 1;
            comboPools.Items.Clear();
            foreach (string dir in dirs)
            {
                Debug.WriteLine("*** "+dir.Split(".").Last());
                if (dir.Split(".").Last().Equals("pool"))
                {
                    Debug.WriteLine("*** " + dir);
                    comboPools.Items.Add(leerDatosPool(dir).getNombre());
                    x++;
                }
             }
        }
        

        private PoolObject leerDatosPool(string pathEntero)
        {
            BinaryFormatter bf;
            FileStream file;
            PoolObject datos = new PoolObject();

            bf = new BinaryFormatter();
            file = File.Open(pathEntero, FileMode.Open);
            datos = (PoolObject)bf.Deserialize(file);
            file.Close();

            return datos;
        }
        private void buttonCrear_Click(object sender, EventArgs e)
        {
            // Debug.WriteLine("*** "+ textNombre.Text);
            PoolObject pool = new PoolObject(textNombre.Text);
            pool.poolToArchivo(pool);
            new FramePool(this, pool).Show();
            Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
