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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PersonelFormEkrani.Show(); //Form1 ve Prsnl_Form ekranı aynı anda açılsın işlemi yaptık
        }

        void PersonelAl(Personel yeniKisi)
        {

        }

        Prsnl_Form PersonelFormEkrani = new Prsnl_Form();//"Prsnl_Form" form'u tipinde intance yarattık.
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            Personel prs = new Personel(txtAdi.Text,txtSoyadi.Text); 
            //Personel prs; ==> Personel tipinde bir değişken ürettik.  new Personel(); Heap'de Personel tipinde nesne yaratıldı
         
            prs.tckn = txtTckn.Text;
            prs.maas = nmrMaas.Value;
            prs.sicilNo = txtSicilNo.Text;
            
            PersonelFormEkrani.PersonelEkle(prs);
            //this.Dispose();      Garbage Collector'ü çağırmamıza yarar.Ama  Garbage Collector'ün kafasına göre takılma ihtimali var.
            //GC.Collect();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt =(TextBox)item;
                    txt.Clear();
                }
            }
            nmrMaas.Value = 0;
            txtAdi.Focus();
        }
    }
}
