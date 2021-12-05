﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace Triaje
{
    [Serializable]
    public class HostObject
    {
        private string nombre;//nombre identificador
        private string ip;//@"192.168.0.102"
        private string user;//"mint"

        private ArrayList archivos = new ArrayList();

        public HostObject(string nombre, string host, string user)
        {
            this.nombre = nombre;
            this.ip = host;
            this.user = user;
        }
        public HostObject() { }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setIP(string host)
        {
            this.ip = host;
        }
        public string getIP()
        {
            return ip;
        }
        public void setUser(string user)
        {
            this.user = user;
        }
        public string getUser()
        {
            return user;
        }
        public void addArchivo(ArchivoObject archivo)
        {
            archivos.Add(archivo);
        }
        public ArrayList getArchivos()
        {
            return archivos;
        }
        public void hostToArchivo(HostObject host)
        {
            //Debug.WriteLine(Application.UserAppDataPath);
            if (!Directory.Exists(Application.UserAppDataPath + "/" + nombre))
            {
                Directory.CreateDirectory(Application.UserAppDataPath + "/" + nombre);
            }
 
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.UserAppDataPath + "/" + nombre + "/" + nombre + ".f1rstree");
            bf.Serialize(file, host);
            file.Close();
        }

        public void descargarArchivo(string pathRemote,string pass)
        {
            Thread hiloParaDescargar = new Thread(delegate () {
                //string pathLocalFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "passwd");
                string pathLocalFile = Path.Combine(Application.UserAppDataPath + "/" + nombre + "/", "passwd");
                using (SftpClient sftp = new SftpClient(ip, user, pass))
                {
                    try
                    {
                        sftp.Connect();

                        using (Stream fileStream = File.OpenWrite(pathLocalFile))
                        {
                            sftp.DownloadFile(pathRemote, fileStream);
                        }

                        sftp.Disconnect();
                    }
                    catch (Exception er)
                    {
                        Console.WriteLine("An exception has been caught " + er.ToString());
                    }
                }
            });

            hiloParaDescargar.Start();

        }
    }


}