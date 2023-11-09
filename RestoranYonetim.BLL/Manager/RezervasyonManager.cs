using RestoranYonetim.BLL.Interface;
using RestoranYonetim.DLL;
using RestoranYonetim.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranYonetim.BLL.Manager
{
    public class RezervasyonManager
    {

        RestoranYonetimDBEntities db = new RestoranYonetimDBEntities();
        Repository<Rezervasyonlar> repository;

        public RezervasyonManager()
        {
            db = new RestoranYonetimDBEntities();
            repository = new Repository<Rezervasyonlar>(db);
        }

        public Rezervasyonlar Bul(int masaID)
        {
            throw new NotImplementedException();
        }

        public string Guncelle(int rezervasyonID, int masaID, DateTime rezervasyonTarihi, int rezervasyonSaatAraligi, int kisiSayisi)
        {
            try
            {
                var guncellenecekData = repository.BulQuery(r => r.RezervasyonID == rezervasyonID).FirstOrDefault();
                if(guncellenecekData == null)
                    return "Rezervasyon bulunamadı";
                if((CakisiyorMu(rezervasyonTarihi, rezervasyonSaatAraligi, guncellenecekData.RezervasyonTarihi, guncellenecekData.RezervasyonSaatAraligi))&&
                    (masaID==guncellenecekData.MasaID))
                    return "Aynı tarihde başka bir rezervasyon mevcut";

                guncellenecekData.RezervasyonTarihi = rezervasyonTarihi;
                guncellenecekData.RezervasyonID = rezervasyonID;
                guncellenecekData.MasaID = masaID;
                guncellenecekData.RezervasyonSaatAraligi = rezervasyonSaatAraligi;
                guncellenecekData.KisiSayisi = kisiSayisi;
                int sonuc = repository.Guncelle(guncellenecekData);
                if(sonuc > 0)
                    return "Güncelleme Başarılı";
                return "Güncelleme BAŞARISIZ";
            }
            catch(Exception ex) { return "Bir hata oluştu \nHATA" + ex.Message; }
        }

        public string Kaydet(int masaID, DateTime rezervasyonTarihi, int rezervasyonSaatAraligi, int kisiSayisi)
        {
            db = new RestoranYonetimDBEntities();
            repository = new Repository<Rezervasyonlar>(db);

            try
            {
                var varMiRezRepoEF = repository.BulQuery(r => r.RezervasyonTarihi == rezervasyonTarihi).FirstOrDefault();
                if(varMiRezRepoEF != null)
                    return "Aynı rezervasyon kayıtlı";
                //REZERVASYON TARİHLERİ ÇAKIŞIYOR MU?
                Rezervasyonlar rez = new Rezervasyonlar();
                if((CakisiyorMu(rezervasyonTarihi, rezervasyonSaatAraligi, rez.RezervasyonTarihi, rez.RezervasyonSaatAraligi))&&(masaID==rez.MasaID))
                    return "O SAAT ARALIĞINDA REZERVASYON MEVCUT / ÇAKIŞMA";

                rez.RezervasyonTarihi = rezervasyonTarihi;
                rez.RezervasyonSaatAraligi = rezervasyonSaatAraligi;
                rez.MasaID = masaID;
                rez.KisiSayisi = kisiSayisi;
                int sonuc = repository.Kaydet(rez);
                if(sonuc > 0)
                    return "Kayıt başarılı";
                return "Kayıt BAŞARISIZ";
            }
            catch(Exception ex) { return "Bir hata oluştu \nHATA" + ex.Message; }

        }

        public string Sil(int rezervasyonID)
        {
            try
            {
                var pasifData = repository.BulQuery(r => r.RezervasyonID == rezervasyonID).FirstOrDefault();
                if(pasifData == null)
                    return "Rezervasyon bulunamadı, lütfen kontrol ediniz";

                int sonuc = repository.Sil(pasifData);
                if(sonuc > 0)
                    return "Silme işlemi Başarılı";
                return "Silme işlemi BAŞARISIZ";
            }
            catch(Exception ex) { return "Bir hata oluştu \nHATA" + ex.Message; }
        }

        /// <summary>
        /// Yeni eklenen veya güncellenecek olan rezervasyon tarihinin varolan diğer rezervasyon tarihleriyle çakışıp çakışmadığını kontrol eder.
        /// </summary>
        /// <param name="ilkTarih"></param>
        /// <param name="ilkSaatAraligi"></param>
        /// <param name="ikinciTarih"></param>
        /// <param name="ikinciSaatAraligi"></param>
        /// <returns></returns>
        public bool CakisiyorMu(DateTime ilkTarih, int ilkSaatAraligi, DateTime ikinciTarih, int ikinciSaatAraligi)
        {
            DateTime ilkRezervasyonBitisTarihi = ilkTarih.AddHours(ilkSaatAraligi);
            DateTime ikinciRezervasyonBitisTarihi = ikinciTarih.AddHours(ikinciSaatAraligi);

            if(ilkTarih < ikinciRezervasyonBitisTarihi && ilkRezervasyonBitisTarihi > ikinciTarih)
                return true; //çakışma var
            if(ikinciTarih < ilkRezervasyonBitisTarihi && ikinciRezervasyonBitisTarihi > ilkTarih)
                return true; //çakışma var

            return false; //çakışma yok
        }
    }
}
