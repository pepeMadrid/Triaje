using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triaje
{
    [Serializable]
    public class ArchivoObject
    {
        private string nombre;
        private string path;
        public ArchivoObject(string nombre, string path)
        {
            this.nombre = nombre;
            this.path = path;
        }
        public ArchivoObject() { }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setPath(string path)
        {
            this.path = path;
        }
        public string getPath()
        {
            return path;
        }
    }
}
