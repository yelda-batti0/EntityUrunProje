using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrunProje
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities1 db = new DbEntityUrunEntities1();

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.TBLKATEGORILER.Count().ToString();
            label3.Text = db.TBLURUNLER.Count().ToString();
            label5.Text = db.TBLMUSTERILER.Count(x => x.DURUM == true).ToString();
            label19.Text = db.TBLMUSTERILER.Count(x => x.DURUM == false).ToString();
            label9.Text = db.TBLURUNLER.Sum(y => y.STOK).ToString();
            label15.Text = db.TBSATISLAR.Sum(z => z.FIYAT).ToString() + " TL ";
            label7.Text = (from x in db.TBLURUNLER orderby x.FİYAT descending select x.URUNAD).FirstOrDefault();
            label21.Text = (from x in db.TBLURUNLER orderby x.FİYAT ascending select x.URUNAD).FirstOrDefault();
            label11.Text = db.TBLURUNLER.Count(X => X.KATEGORI == 1).ToString();
            label17.Text = (from x in db.TBLMUSTERILER select x.SEHIR).Distinct().Count().ToString();
            label13.Text = db.MARKAGETIR().FirstOrDefault();
            
            
               
            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
