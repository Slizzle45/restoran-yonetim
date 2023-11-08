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
    public class MasaManager : IMasa
    {
        RestoranYonetimDBEntities db = new RestoranYonetimDBEntities();
        Repository<Masalar> repository;

        public MasaManager()
        {
            db = new RestoranYonetimDBEntities();
            repository = new Repository<Masalar>(db);
        }

        public Masalar Bul(string masaAdi)
        {
            return repository.BulQuery(x => x.MasaAdi == masaAdi).FirstOrDefault();
        }

        public string Guncelle(int masaId, string masaAdi, int kapasite, string durum)
        {
            throw new NotImplementedException();
        }

        public string Kaydet(string masaAdi, int kapasite, string durum)
        {
            db = new RestoranYonetimDBEntities();
            repository = new Repository<Masalar>(db);

            try
            {
                var varMiMasaRepoEF = repository.BulQuery(r => r.MasaAdi == masaAdi).FirstOrDefault();

                if(varMiMasaRepoEF != null)
                    return "Aynı masa kayıtlı";

                Masalar masalar = new Masalar();
                masalar.MasaAdi = masaAdi;
                masalar.Kapasite = kapasite;
                masalar.Durum = durum;

                int sonuc = repository.Kaydet(masalar);
                if(sonuc > 0)
                    return "Kayıt Başarılı";
                return "Kayıt başarısız";

            }
            catch(Exception ex) { return "Bir hata oluştu \n HATA" + ex.Message + "inner exception = = = " + ex.InnerException.Message; }
        }

        public string Sil(int masaID)
        {
            try
            {
                var pasifData = repository.BulQuery(r => r.MasaID == masaID).FirstOrDefault();
                if(pasifData == null)
                {
                    return "Masa bulunamadı, lütfen kontrol ediniz";
                }
                //
                int sonuc = repository.Sil(pasifData);
                if(sonuc > 0)
                {
                    return "Masa Silme işlemi başarılı";
                }
                return "Masa silme işlemi BAŞARISIZ";
            }
            catch(Exception ex) { return "Bir hata oluştu \n HATA" + ex.Message + "inner exception = = = " + ex.InnerException.Message; }
        }

        public IEnumerable<Masalar> MasaListesi()
        {
            return repository.Listele();
        }




    }
}
