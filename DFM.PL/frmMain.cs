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
    public partial class frmMain : Form
    {
        public int MousePosX = 0, MousePosY = 0;
        public bool mouseDown = false;
        AjandaBLL _ajanda = new AjandaBLL();
        int globalId = 0;

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MousePosX, MousePosition.Y - MousePosY);
            }
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MousePosX = e.X;
            MousePosY = e.Y;
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = Sabitler.appPath + @"ses\acildi.wav";
            ses.Play();
            ses.Dispose();


            BekleyenleriYukle();
            BitenleriYukle();
            
            
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void BitenleriYukle()
        {
            gridBitenler.DataSource = null;
            gridBitenler.DataSource = _ajanda.Get(g => g.Durumu == false);
            lblBitenler.Text = _ajanda.GetCount(g => g.Durumu == false).ToString();
        }
        private void BekleyenleriYukle()
        {
            gridBekleyenler.DataSource = null;
            gridBekleyenler.DataSource = _ajanda.Get(g => g.Durumu == true);
            lblBekleyen.Text = _ajanda.GetCount(g => g.Durumu == true).ToString();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Ajanda model = new Ajanda();
            model.BaslamaTarihi = dtBaslamaTarihi.Value;
            model.BitisTarihi = dtBitisTarihi.Value;
            model.Icerik = txtIcerik.Text;
            model.Durumu = true;
            _ajanda.Insert(model);

            txtIcerik.Text = "";

            BekleyenleriYukle();
            BitenleriYukle();

            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = Sabitler.appPath +  @"ses\kapat.wav";
            ses.Play();
            ses.Dispose();
        }


        private void dtBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            //başlama bitişten büyük olamaz
            if (dtBaslamaTarihi.Value > dtBitisTarihi.Value)
            {
                dtBaslamaTarihi.Value = dtBitisTarihi.Value;
            }
        }
        private void dtBitisTarihi_ValueChanged(object sender, EventArgs e)
        {
            //bitiş başlamadan küçük olamaz
            if (dtBitisTarihi.Value < dtBaslamaTarihi.Value)
            {
                dtBitisTarihi.Value = dtBaslamaTarihi.Value;
            }
        }

        private void gridBekleyenler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = (int)gridBekleyenler.Rows[e.RowIndex].Cells[0].Value;
                globalId = Id;

                frmDetay frm = new PL.frmDetay(globalId, this);
                frm.ShowDialog();
            }
        }

        private void gridBitenler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = (int)gridBitenler.Rows[e.RowIndex].Cells[0].Value;
                globalId = Id;

                frmDetay frm = new PL.frmDetay(globalId, this);
                frm.ShowDialog();



            }
        }
    }
}
