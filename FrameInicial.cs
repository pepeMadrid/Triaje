using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace Triaje
{
    public partial class FrameInicial : Form
    {
        ArrayList hosts = new ArrayList();

        public FrameInicial()
        {
            InitializeComponent();
            cargarDatos();
        }
        public void cargarDatos()
        {
            string[] dirs = Directory.GetDirectories(Application.UserAppDataPath, "*", SearchOption.AllDirectories);
            int x = 0;
            comboHosts.Items.Clear();
            foreach (string dir in dirs)
            {
                hosts.Add(leerDatosHost(dir+@"\"+dir.Split(@"\").Last()+".f1rstree"));
                HostObject host = (HostObject)hosts[x];
                comboHosts.Items.Add(host.getNombre());
                x++;
            }
        }

        private HostObject leerDatosHost(string pathEntero)
        {
            BinaryFormatter bf;
            FileStream file;
            HostObject datos = new HostObject();

            bf = new BinaryFormatter();
            Debug.Print(pathEntero);
            file = File.Open(pathEntero, FileMode.Open);
            datos = (HostObject)bf.Deserialize(file);
            file.Close();

            return datos;
        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            Hide();
            FrameHost host = new FrameHost(this);
            host.ShowDialog();
        }

        private void comboHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIP.Text = leerDatosHost(Application.UserAppDataPath+@"\"+comboHosts.SelectedItem + @"\" + comboHosts.SelectedItem+".f1rstree").getIP();
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            Hide();
            FrameArchivo host = new FrameArchivo(this, leerDatosHost(Application.UserAppDataPath + @"\" + comboHosts.SelectedItem + @"\" + comboHosts.SelectedItem + ".f1rstree"));
            host.ShowDialog();
        }
    }
}
