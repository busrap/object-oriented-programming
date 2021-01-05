using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Giris_Proje_1
{
    public partial class Prsnl_Form : Form
    {
        public Prsnl_Form()
        {
            InitializeComponent();
        }

        private void Prsnl_Form_Load(object sender, EventArgs e)
        {

        }
        Personel[] personeler = new Personel[100];
        int sayac = 0;
        public void PersonelEkle(Personel p)
        {
            personeler[sayac] = p;
            lstListe.Items.Add(p.adi + " " + p.soyadi);
            sayac++;

        }

        private void btnKov_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedIndex == -1) return; //Herhagi bişi seçili değilse çık
            
            Personel Prs_kov = new Personel();
           Prs_kov= personeler[lstListe.SelectedIndex];
            Prs_kov.IstenKov();
        }

        private void Prsnl_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Prsnl_Form kapatıldığında program kapatılsın
        }
    }
}
