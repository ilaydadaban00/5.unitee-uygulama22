using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.unite_uygulama22
{
    public partial class Form1 : Form
    {
        ArrayList kaynakveri=new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kitap kitap=new Kitap();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.KitapTur = txtKitapTur.Text;
            kitap.KitapYazar = txtKitapYazar.Text;
            kaynakveri.Add(kitap);
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            listveri.DataSource = null;
            listveri.DataSource = kaynakveri;
            listveri.DisplayMember = "KitapAdi";
         
        }
    }
}
