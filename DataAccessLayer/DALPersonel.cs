using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {
        private static void bagla(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static List<EntityPersonel> PersonelListesi() //list<entitypersonel> diyerek liste türünde bir metoda dönüştürdük metodun adınada PersonelListesi dedik
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand kmtlist = new SqlCommand("select * from TblBilgi", Baglanti.bgl);
            bagla(kmtlist.Connection);
            SqlDataReader dr = kmtlist.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["Ad"].ToString();
                ent.Soyad = dr["Soyad"].ToString();
                ent.Sehir = dr["sehir"].ToString();
                ent.Gorev = dr["Gorev"].ToString();
                ent.Maas = short.Parse(dr["Maas"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand kmtekle = new SqlCommand("insert into TblBilgi" +
                "(Ad,Soyad,Gorev,Sehir,Maas) values (@pad,@psoyad,@pgorev,@psehir,@pmaas)", Baglanti.bgl);
            bagla(kmtekle.Connection);
            kmtekle.Parameters.AddWithValue("@pad", p.Ad);
            kmtekle.Parameters.AddWithValue("@psoyad", p.Soyad);
            kmtekle.Parameters.AddWithValue("@pgorev", p.Gorev);
            kmtekle.Parameters.AddWithValue("psehir", p.Sehir);
            kmtekle.Parameters.AddWithValue("pmaas", p.Maas);

            return kmtekle.ExecuteNonQuery();
        }

        public static bool Personelsil(int p)
        {
            SqlCommand kmtsil = new SqlCommand("delete from TblBilgi where ID=@pid",Baglanti.bgl);
            bagla(kmtsil.Connection);
            kmtsil.Parameters.AddWithValue("@pid", p);

            return kmtsil.ExecuteNonQuery() > 0;
        }

        public static bool personelguncelle(EntityPersonel p)
        {
            SqlCommand kmtguncelle = new SqlCommand("update TblBilgi set " +
                "ad=@pad,soyad=@psoyad,maas=@pmaas,gorev=@pgorev,sehir=@psehir" +
                " where ıd=@pid", Baglanti.bgl);
            bagla(kmtguncelle.Connection);
            kmtguncelle.Parameters.AddWithValue("@pid", p.Id);
            kmtguncelle.Parameters.AddWithValue("@pad", p.Ad);
            kmtguncelle.Parameters.AddWithValue("@psoyad", p.Soyad);
            kmtguncelle.Parameters.AddWithValue("@pmaas", p.Maas);
            kmtguncelle.Parameters.AddWithValue("@pgorev", p.Gorev);
            kmtguncelle.Parameters.AddWithValue("@psehir", p.Sehir);

            return kmtguncelle.ExecuteNonQuery() > 0;
        }
        
    }
}
