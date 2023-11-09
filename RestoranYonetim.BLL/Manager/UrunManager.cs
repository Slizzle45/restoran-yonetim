using RestoranYonetim.DLL;
using RestoranYonetim.DLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranYonetim.BLL.Manager
{
    public class UrunManager
    {
        RestoranYonetimDBEntities db = new RestoranYonetimDBEntities();
        Repository<Urunler> repository;

        public UrunManager()
        {
            db = new RestoranYonetimDBEntities();
            repository = new Repository<Urunler>(db);
        }

        public Urunler Bul(string urunAdi)
        {
            return repository.BulQuery(x => x.UrunAdi == urunAdi).FirstOrDefault();
        }

        public string Guncelle(string urunAdi, string kategori, decimal fiyat)
        {
            throw new NotImplementedException();
        }

        public string Kaydet(string urunAdi, string kategori, int fiyat, string aciklama)
        {
            db = new RestoranYonetimDBEntities();
            repository = new Repository<Urunler>(db);

            try
            {
                var varMiUrunRepoEF = repository.BulQuery(r => r.UrunAdi == urunAdi).FirstOrDefault();

                if(varMiUrunRepoEF != null)
                    return "Aynı ürün kayıtlı";

                Urunler urunler = new Urunler();
                urunler.UrunAdi = urunAdi;
                urunler.Kategori = kategori;
                urunler.Fiyat = fiyat;
                urunler.Aciklama = aciklama;

                int sonuc = repository.Kaydet(urunler);
                if(sonuc > 0)
                    return "Kayıt Başarılı";
                return "Kayıt başarısız";
            }
            catch(Exception ex) { return "Bir hata oluştu \n HATA" + ex.Message + "inner exception ===> " + ex.InnerException.Message; }
        }

        public string Sil(int urunID)
        {
            try
            {
                var pasifData = repository.BulQuery(x => x.UrunlerID == urunID).FirstOrDefault();
                if(pasifData == null)
                    return "Ürün bulunamadı, lütfen kontrol edini";
                //
                int sonuc = repository.Sil(pasifData);
                if(sonuc > 0)
                    return "Ürün silme işlemi BAŞARILI";
                return "Ürün silme işlemi BAŞARISIZ";
            }
            catch(Exception ex) { return "Bir hata oluştu \n HATA" + ex.Message + "inner exception ===> " + ex.InnerException.Message; }
        }

        public IEnumerable<Urunler> UrunListesi()
        {
            return repository.Listele();
        }

    }
}
