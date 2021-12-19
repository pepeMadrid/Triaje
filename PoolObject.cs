using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace Triaje
{
    [Serializable]
    public class PoolObject
    {
        private string nombre;
        private ArrayList pool = new ArrayList();

        public PoolObject (string nombre){
            this.nombre = nombre;
        }
        public PoolObject()
        {
        }
        public string getNombre()
        {
            return nombre;
        }
        public void addArchivo(ArchivoObject archivo)
        {
            pool.Add(archivo);
        }
        public ArrayList getPool()
        {
            return pool;
        }

        public void poolToArchivo(PoolObject pool)
        {
            FileStream file = File.Create(Application.UserAppDataPath +"/"+ nombre + ".pool");
            new BinaryFormatter().Serialize(file, pool);
            file.Close();
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
    }
}
