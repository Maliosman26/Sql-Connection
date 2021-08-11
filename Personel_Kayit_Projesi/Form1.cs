using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql komutlarını kullanabilmek için gerekli olan kütüphanedir.

namespace Personel_Kayit_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source = MALIOSMAN; Initial Catalog = PersonelVeriTabani; Integrated Security = True");


        private void Form1_Load(object sender, EventArgs e)
        {
                     
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            baglanti.Close();
        }
    }
}
