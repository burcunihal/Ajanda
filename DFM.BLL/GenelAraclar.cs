using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFM.BLL
{
    public static class GenelAraclar
    {
        public static int GetId(string TableName)
        {
            string filename = "db\\"+ TableName + "Log.txt";
            string directory = Sabitler.appPath;
            string path = directory + filename;

            string _Id = File.ReadAllText(path);
            int Id = Convert.ToInt32(_Id);
            Id++;

            File.WriteAllText(path, Id.ToString());

            return Id;
        }
    }
}