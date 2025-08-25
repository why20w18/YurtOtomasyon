using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace YurtOtomasyon.UI.WinForms
{
    public partial class frmHome : Form
    {
        private bool isMenuExpand = false;
        private bool isSidebarExpand = true;
        
        private frmOGR_EkleCikartGuncelle? formOgrEkleCikGun;
        private frmOGR_FiltreListe? formOgrFiltreListe;

        public frmHome()
        {
            InitializeComponent();
        }

        private void ogrIslemBaseTimer_Tick(object sender, EventArgs e)
        {
            if (!isMenuExpand)
            {
                ogrContainer.Height += 10;
                if (ogrContainer.Height > 374)
                {
                    ogrIslemBaseTimer.Stop();
                    isMenuExpand = true;
                }
            }
            else
            {
                ogrContainer.Height -= 10;
                if (ogrContainer.Height < 68)
                {
                    ogrIslemBaseTimer.Stop();
                    isMenuExpand = false;
                }
            }
        }

        private void btnOGRIslemBase_Click(object sender, EventArgs e)
        {
            ogrIslemBaseTimer.Start();
        }

        private void picboxSidebar_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (isSidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 65)
                {
                    isSidebarExpand = false;
                    sidebarTimer.Stop();
                    ogrContainer.Enabled = false;


                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 250)
                {
                    isSidebarExpand = true;
                    sidebarTimer.Stop();
                    ogrContainer.Enabled = true;




                }
            }
        }

        private void btnOGREkleSilGuncelle_Click(object sender, EventArgs e)
        {
            this.programPageTittle.Text = "Yurt Otomasyon | Öğrenci Ekleme Çıkartma Güncelleme İşlemleri";
            if (formOgrEkleCikGun is null)
            {
                formOgrEkleCikGun = new frmOGR_EkleCikartGuncelle();
                formOgrEkleCikGun.FormClosed += FormOgrEkleCikGun_FormClosed;
                formOgrEkleCikGun.MdiParent = this;
                formOgrEkleCikGun.Dock = DockStyle.Fill;
                formOgrEkleCikGun.FormBorderStyle = FormBorderStyle.None;
                formOgrEkleCikGun.ControlBox = false;
                formOgrEkleCikGun.Show();
                
            }
            else
            {
                formOgrEkleCikGun.Activate();
            }
        }

        private void FormOgrEkleCikGun_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formOgrEkleCikGun = null;
        }


        private void btnOGRFiltreListe_Click(object sender , EventArgs e)
        {
            this.programPageTittle.Text = "Yurt Otomasyon | Öğrenci Filtreleme ve Listeleme İşlemleri";

            if (formOgrFiltreListe is null)
            {
                formOgrFiltreListe = new frmOGR_FiltreListe();
                formOgrFiltreListe.FormClosed += FormOgrFiltreListe_FormClosed;
                formOgrFiltreListe.Dock = DockStyle.Fill;
                formOgrFiltreListe.FormBorderStyle = FormBorderStyle.None;
                formOgrFiltreListe.MdiParent = this;
                formOgrFiltreListe.Show();
            }
            else
            {
                formOgrFiltreListe.Activate();
            }
        }

        private void FormOgrFiltreListe_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formOgrFiltreListe = null;
        }
    }
}
