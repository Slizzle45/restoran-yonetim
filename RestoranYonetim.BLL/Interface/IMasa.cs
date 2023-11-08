using System;
using RestoranYonetim.DLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoranYonetim.BLL.Interface
{
    public interface IMasa
    {
        string Kaydet(string masaAdi, int kapasite, string durum);
        string Guncelle(int masaId, string masaAdi, int kapasite, string durum);
        string Sil(int masaID);
        Masalar Bul(string masaAdi);
        
    }
}
