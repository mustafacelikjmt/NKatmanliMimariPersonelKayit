using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using LogicLayer;
using DataAccessLayer;
using System.Net.Configuration;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listele()
        {
            List<EntityPersonel> perlist = LogicPersonel.LLPersonelListesi(); //baştaki list entity personel yerine var da oluyo.
            dataGridView1.DataSource = perlist;
        }

        private void Buttonlist_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            EntityPersonel add = new EntityPersonel();
            add.Ad = textBoxad.Text;
            add.Soyad = textBoxsoyad.Text;
            add.Gorev = textBoxgorev.Text;
            add.Sehir = textBoxsehir.Text;
            add.Maas = short.Parse(textBoxmaas.Text);
            LogicPersonel.LLPersonelEkle(add);
            listele();
        }

        private void button1_Click(object sender, EventArgs e)//sil
        {
            EntityPersonel sil = new EntityPersonel();
            sil.Id = int.Parse(textBoxıd.Text);
            LogicPersonel.LLPersonelSil(sil.Id);
            listele();

        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            EntityPersonel guncelle = new EntityPersonel();
            guncelle.Id = int.Parse(textBoxıd.Text);
            guncelle.Ad = textBoxad.Text;
            guncelle.Soyad = textBoxsoyad.Text;
            guncelle.Maas = short.Parse(textBoxmaas.Text);
            guncelle.Sehir = textBoxsehir.Text;
            guncelle.Gorev = textBoxgorev.Text;
            LogicPersonel.LLPersonelGuncelle(guncelle);
            listele();

        }
    }
}
