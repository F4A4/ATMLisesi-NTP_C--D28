using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace anonimsiniflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Anonim Sınıf :
            //aşağıdaki gibi tanımlanır, içine yalnızca alan
            //(yani değişken) alabilir ve hepsi public olur.
            //metot barındıramaz. değişken türleri verilen
            //değere göre belirlenir.
            //değişkenlere sonradan değer atanamaz.
            var myBisiklet = new { tekerSayisi = 2, vitesSayisi = 12, marka = "bianchi" };
            MessageBox.Show(myBisiklet.marka);
            MessageBox.Show(myBisiklet.tekerSayisi.ToString());
            MessageBox.Show(myBisiklet.vitesSayisi.ToString());
        }
    }
}
