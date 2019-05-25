using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFM.DAL
{
    public class Ajanda
    {
        public int Id { get; set; }
        public string Icerik { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public bool Durumu { get; set; }
        public string DurumBilgisi
        {
            get
            {
                return Durumu == true ? "Devam Eden" : "Biten";
            }
        }
        public string BaslamaT
        {
            get
            {
                return BaslamaTarihi.ToTarihTR();
            }
        }
        public string BaslamaSaati
        {
            get
            {
                return BaslamaTarihi.ToSaatTR();
            }
        }
        public string BitisT
        {
            get
            {
                return BitisTarihi.ToTarihTR();
            }
        }
        public string BitisSaati
        {
            get
            {
                return BitisTarihi.ToSaatTR();
            }
        }
    }
}
