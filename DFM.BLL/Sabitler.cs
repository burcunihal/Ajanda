using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFM.BLL
{
    public static class Sabitler
    {
        public static string appPath = (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)).ToString() + "\\";
    }
}
