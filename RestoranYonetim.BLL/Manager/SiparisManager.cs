using RestoranYonetim.DLL;
using RestoranYonetim.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranYonetim.BLL.Manager
{
    public class SiparisManager
    {
        RestoranYonetimDBEntities db = new RestoranYonetimDBEntities();
        Repository<Siparisler> repository;

        public SiparisManager()
        {
            db = new RestoranYonetimDBEntities();
            repository = new Repository<Siparisler>(db);
        }

        public Siparisler Bul(int masaID)
        {
            return repository.BulQuery(x => x.MasaID == masaID).FirstOrDefault();
        }

        public string Guncelle(DateTime siparisTarihi, int toplamFiyat, int masaID)
        {
            throw new NotImplementedException();
        }

        public string Kaydet(DateTime siparisTarihi, int toplamFiyat, int masaID)
        {
            db = new RestoranYonetimDBEntities();
            repository = new Repository<Siparisler>(db);

            try
            {
                Siparisler siparis = new Siparisler();
                siparis.SiparisTarihi = siparisTarihi;
                siparis.ToplamFiyat = toplamFiyat;
                siparis.MasaID = masaID;

                int sonuc = repository.Kaydet(siparis);
                if(sonuc > 0)
                    return "Kayıt Başarılı";
                return "Kayıt Başarısız";
            }
            catch(Exception ex) { return "Bir hata oluştu \n HATA" + ex.Message + "inner exception = = = " + ex.InnerException.Message; }
        }

        public IEnumerable<Siparisler> SiparisListesi()
        {
            return repository.Listele();
        }

    }
}
