using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Giris_Proje_1
{
    
    public class Personel//Bir Class default değeri İnternal'dir.
    {
        //metod içinde tanımlanırsa değişken, Class içinde tanımlanırsa Field adı ile tanımlanır.
        //Class ile üretilmiş her bir nesnenin özelliğidir.
       internal string adi;
       internal string soyadi;
       internal string sicilNo;
       internal string tckn;
       internal DateTime IseGirisTarihi;
       internal decimal maas;
        //Constructor==> Ram'de nesneyi yaratan metotdur.Geri dönüş değeri yoktur,aşırı yükleme(Overload) yapıla bilir.
        //Class oluşturulurken yapılacak işlemler contructor ile yapılır.
        //Mesela Class'ı bir arabaya benzetelim.Araba üretilirken arabayı zevkimize göre şekillendirmek istiyoruzdur.Mesela 2 kapılı olsun,üstü açık olsun,dizel olsun
        //falan diye arabanın şeklini,işleyişini daha üretim aşamasındayken şekillendirmek istiyorsak eğer Contructor kullanırız.
        //Metotlar tetiklenmediği sürece çalışmaz ama Contructor,nesne yaratıldığı an çalışacaktır.
        public Personel()
        {
           

            adi = "İsim Girişi yapılmadı";
            soyadi = "Soyadı Girişi yapılmadı";
            tckn = "TCKN Girişi Yapılmadı";
            sicilNo = "Sicil No Girişi Yapılmadı";
        }
        public Personel(string adi,string soyadi)//Personelin adını soyadını daha nesne ilk yaratıldığında veriyoruz
        {
            IseGirisTarihi = DateTime.Now; //nesene yaratıldığı an o an ki tarihi IseGirisTarihi Field'ine atayacak
            this.adi = adi;
            this.soyadi = soyadi;
           
        }
  
 
       ~Personel() //Destructor (yıkıcı method) deyim yerindeyse "Ölmeden önce ki son isteğin" durumudur.En son çalışır, noktayı koyar gider.
        {
            
         
            {
                System.Windows.Forms.MessageBox.Show("Bayy dostum(Destructor mesajı)");
                
            }
      
        }
       internal void IseAl()
        {
            //Database'ye personel ekleme işi yapacak
        }
       internal decimal KidemTazminatiHesapla()
        {
            return 0;
        }
       internal void IstenKov()
        {
            decimal para = KidemTazminatiHesapla();
        }
    }

}
