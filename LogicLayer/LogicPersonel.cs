using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicLayer;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad != "" && p.Soyad != "" && p.Maas >= 4000 && p.Ad.Length >= 3)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }

        }
        
        public static bool LLPersonelSil(int per)
        {
            if (per >= 1) 
            {
                return DALPersonel.Personelsil(per);
            }
            else
            {
                return false;
            }

        }
        
        public static bool LLPersonelGuncelle(EntityPersonel p)
        {
            if(p.Ad.Length>=3 && p.Ad != "" && p.Maas > 4000)
            {
                return DALPersonel.personelguncelle(p);
            }
            else
            {
                return false;
            }

        }
        
    }
}
