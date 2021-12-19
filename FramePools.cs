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
        private HostObject host;
        public FramePools(HostObject host)
        {
            InitializeComponent();
            this.host = host;
            cargarDatos();

        }

        public void cargarDatos()
        {
            string[] dirs = Directory.GetFiles(Application.UserAppDataPath, "*", SearchOption.AllDirectories);
            int x = 1;
            comboPools.Items.Clear();
            foreach (string dir in dirs)
            {
                //Debug.WriteLine("*** "+dir.Split(".").Last());
                if (dir.Split(".").Last().Equals("pool"))
                {
                    //Debug.WriteLine("*** " + dir);
                    comboPools.Items.Add(leerDatosPool(dir).getNombre());
                    x++;
                }
             }

            labelHost.Text = host.getNombre() + " - "+host.getIP() ;
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
            new FramePool(pool,host).Show();
            Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            int error;
            foreach (ArchivoObject archivo in leerDatosPool(Application.UserAppDataPath + "/" + comboPools.SelectedItem.ToString() + ".pool").getPool())
            {
                error = host.descargarArchivo(archivo.getPath(), textPass.Text, archivo.getNombre());
                if (error == 0)
                {//archivo descargado sin errores
                    host.addArchivo(archivo);
                    host.hostToArchivo(host);
                }
            }
            new FramePrincipal().Show();
            Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            PoolObject pool = leerDatosPool(Application.UserAppDataPath+"/"+comboPools.SelectedItem.ToString()+".pool");
            new FramePool(pool,host).Show();
            Close();
        }

        private void comboPools_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAgregar.Enabled = true;
            buttonModificar.Enabled = true;
            buttonEliminar.Enabled = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            new FramePrincipal().Show();
            Close();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            File.Delete(Application.UserAppDataPath + "/" + comboPools.SelectedItem.ToString() + ".pool");

            new FramePools(host).Show();
            Close();
        }
    }
}
