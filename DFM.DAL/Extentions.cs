using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFM.DAL
{
    public static class Extentions
    {
        public static string ToTarihTR(this DateTime value)
        {
            return value.ToString("dd.MM.yyyy");
        }
        public static string ToSaatTR(this DateTime value)
        {
            return value.ToString("HH:mm");
        }
    }
}
