using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DFM.DAL;
using DFM.BLL;
using System.Media;

namespace DFM.PL
{
    public partial class frmDetay : Form
    {
        AjandaBLL _ajanda = new AjandaBLL();
        int globalId = 0;
        private readonly frmMain frmParent;

        public frmDetay(int _Id, frmMain frm)
        {
            frmParent = frm;
            globalId = _Id;
            InitializeComponent();
        }

        private void frmDetay_Load(object sender, EventArgs e)
        {
            var model = _ajanda.GetById(globalId);
            txtIcerik.Text = model.Icerik;
            dtBaslamaTarihi.Value = model.BaslamaTarihi;
            dtBitisTarihi.Value = model.BitisTarihi;

            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = Sabitler.appPath + @"ses\sil.wav";
            ses.Play();
            ses.Dispose();
        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            _ajanda.Delete(globalId);
            globalId = 0;
            BekleyenleriYukle();
            BitenleriYukle();

            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = Sabitler.appPath + @"ses\sil.wav";
            ses.Play();
            ses.Dispose();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            var model = _ajanda.GetById(globalId);
            model.Durumu = !model.Durumu;
            _ajanda.Update(globalId, model);
            globalId = 0;
            BekleyenleriYukle();
            BitenleriYukle();

            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = Sabitler.appPath + @"ses\kapat.wav";
            ses.Play();
            ses.Dispose();
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Ajanda model = _ajanda.GetById(globalId);
            model.BaslamaTarihi = dtBaslamaTarihi.Value;
            model.BitisTarihi = dtBitisTarihi.Value;
            model.Icerik = txtIcerik.Text;
            _ajanda.Update(globalId, model);

            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = Sabitler.appPath + @"ses\guncelle.wav";
            ses.Play();
            ses.Dispose();
        }


        private void BitenleriYukle()
        {
            frmParent.gridBitenler.DataSource = null;
            frmParent.gridBitenler.DataSource = _ajanda.Get(g => g.Durumu == false);
        }
        private void BekleyenleriYukle()
        {
            frmParent.gridBekleyenler.DataSource = null;
            frmParent.gridBekleyenler.DataSource = _ajanda.Get(g => g.Durumu == true);
        }
    }
}
