using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        int id; //bu değişkenler private kalmaya devam ediyor sınıfın türüyle çok bağlantılı değiller anladığım kadarıyla.
        string ad;
        string soyad;
        string sehir;
        string gorev;
        short maas;

        public int Id //benim bildiğim bu şekliydi bunun adı kapsülleme bu arada
        {
            get { return id; }
            set { id = value; }
        }
        //ama böylede oluyomuş
        public string Ad { get => ad; set => ad = value; } 
        public string Soyad { get => soyad; set => soyad = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string Gorev { get => gorev; set => gorev = value; }
        public short Maas { get => maas; set => maas = value; }

        
    }
}
