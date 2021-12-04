using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Renci.SshNet;
using Renci.SshNet.Sftp;
using System.IO;
using System.Threading;

namespace Triaje
{
    class SshObject
    {
        private string host;//@"192.168.0.102"
        private string user;//"mint"
        private string pass;//@"1234"

        //private string pathRemote;//"/etc/passwd"
        private string pathLocal;
        public SshObject(string host,string user,string pass)
        {
            this.host = host;
            this.user = user;
            this.pass = pass;
        }

        public SshObject() { }

        public void setHost(string host)
        {
            this.host = host;
        }
        public string getHost()
        {
            return host;
        }
        public void setUser(string user)
        {
            this.user = user;
        }
        public string getUser()
        {
            return user;
        }
        public void setPass(string pass)
        {
            this.pass = pass;
        }
        public string getPass()
        {
            return pass;
        }

        public void descargarArchivo(string pathRemote)
        {
            Thread hiloParaDescargar = new Thread(delegate () {
                string pathLocalFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "passwd");
                
                using (SftpClient sftp = new SftpClient(host, user, pass))
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
