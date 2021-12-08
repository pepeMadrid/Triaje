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
using System.Security.Cryptography;


namespace Triaje
{
    public partial class FramePrincipal : Form
    {
        ArrayList hosts = new ArrayList();
        
        public FramePrincipal()
        {
            InitializeComponent();
            cargarDatos();
            //listArchivos.Items.Add(new ListViewItem(new[] { "1", "2", "3", "4" ,"5","6" }));
            listArchivos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listArchivos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public void cargarArchivos()
        {
            listArchivos.Items.Clear();
            HostObject host = leerDatosHost(Application.UserAppDataPath + @"\" + comboHosts.SelectedItem + @"\" + comboHosts.SelectedItem + ".f1rstree");
            int x = 1;
            string hash,rHash,comprobacion;
            foreach (ArchivoObject archivo in host.getArchivos())
            {
                //id - nombre - path - hash - remote hash - comparacion
                hash = calcularHASH(Application.UserAppDataPath + @"\" + comboHosts.SelectedItem + @"\" + archivo.getNombre());
                rHash = calcularHASH(Application.UserAppDataPath + @"\" + comboHosts.SelectedItem + @"\" + archivo.getNombre()+".remote");
                if (hash.Equals(rHash))
                    comprobacion = "Correcto";
                else
                    comprobacion = "*ERROR*";
                listArchivos.Items.Add(new ListViewItem(new[] { x + "", archivo.getNombre(),archivo.getPath(),hash, rHash, comprobacion }));
                x++;
            }
        }
        private string calcularHASH(string path)
        {
            try
            {
                return BitConverter.ToString(SHA512.Create().ComputeHash(File.OpenRead(path))).Replace("-", "");
            }
            catch(Exception e)
            {
                return "NULL";
            }
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
                Debug.WriteLine(host.getNombre());
                x++;
            }
        }

        private HostObject leerDatosHost(string pathEntero)
        {
            BinaryFormatter bf;
            FileStream file;
            HostObject datos = new HostObject();

            bf = new BinaryFormatter();
            file = File.Open(pathEntero, FileMode.Open);
            datos = (HostObject)bf.Deserialize(file);
            file.Close();

            return datos;
        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            Hide();
            FrameHost hostFrame = new FrameHost(this);
            hostFrame.Show();
        }

        private void comboHosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelIP.Text = leerDatosHost(Application.UserAppDataPath+@"\"+comboHosts.SelectedItem + @"\" + comboHosts.SelectedItem+".f1rstree").getIP();
            cargarArchivos();
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            Hide();
            FrameArchivo hostFrame = new FrameArchivo(this, leerDatosHost(Application.UserAppDataPath + @"\" + comboHosts.SelectedItem + @"\" + comboHosts.SelectedItem + ".f1rstree"));
            hostFrame.Show();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            HostObject host = leerDatosHost(Application.UserAppDataPath + @"\" + comboHosts.SelectedItem + @"\" + comboHosts.SelectedItem + ".f1rstree");
            foreach(ArchivoObject archivo in host.getArchivos())
            {
                host.descargarArchivo(archivo.getPath(),textPass.Text,archivo.getNombre()+".remote");
            }
            cargarArchivos();
        }

        private void buttonDeleteHost_Click(object sender, EventArgs e)
        {
            Directory.Delete(Application.UserAppDataPath + @"\" + comboHosts.SelectedItem,true);

            Hide();
            FramePrincipal framePrincipal = new FramePrincipal();
            framePrincipal.Show();

        }
        private void comboHosts_Click(object sender, EventArgs e)
        {

        }

        private void buttonModificarHost_Click(object sender, EventArgs e)
        {
            Hide();
            FrameHost hostFrame = new FrameHost(this, leerDatosHost(Application.UserAppDataPath + @"\" + comboHosts.SelectedItem + @"\" + comboHosts.SelectedItem + ".f1rstree"));
            hostFrame.Show();
        }

        private void FramePrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void FramePrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
