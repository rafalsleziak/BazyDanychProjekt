using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazyDanych
{
    public partial class Form1 : Form
    {
        string symbol, material, kolor, okleina;
        float kosztMb;
        bool ornament;
        Connection baza = new Connection();
        DataSet dataset;


        public Form1()
        {
            InitializeComponent();
            //baza.InsertListwa("23-01-02", "sosna","bialy",false,"czarna",(float)3.25);
            dataset = baza.LoadData("SELECT * FROM listwa");
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dataset.Tables[0].DefaultView;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            kolor = textBoxKolor.Text;
            symbol = textBoxSymbol.Text;
            material = textBoxMaterial.Text;
            okleina = textBoxOkleina.Text;
            kosztMb = float.Parse(textBoxKosztMb.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            ornament = checkBoxOrnament.Checked;
            baza.InsertListwa(symbol, material, kolor, ornament, okleina, kosztMb);
            dataset = baza.LoadData("SELECT * FROM listwa");
            dataGridView1.DataSource = dataset.Tables[0].DefaultView;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void textBoxKosztMb_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOkleina_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSymbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaterial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
