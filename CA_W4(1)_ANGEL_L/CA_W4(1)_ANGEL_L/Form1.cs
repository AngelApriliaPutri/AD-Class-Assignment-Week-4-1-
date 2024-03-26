using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W4_1__ANGEL_L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Country
        {
            public string country { get; set; }
            public string city { get; set; }
            public long population {get; set;}
        }
        List<Country> countryList = new List<Country>();
        private void button_add_Click(object sender, EventArgs e)
        {
            Country negara = new Country();
            negara.country = textBox_country.Text;
            negara.city = textBox_city.Text;
            negara.population = Convert.ToInt64(textBox_population.Text);

            if (string.IsNullOrEmpty(textBox_country.Text) || string.IsNullOrEmpty(textBox_city.Text) || string.IsNullOrEmpty(textBox_population.Text))
            {
                MessageBox.Show("All Field must be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox_countrylist.Items.Add(negara.country);
                listBox_cityllist.Items.Add(negara.city + ", " + negara.country);
                comboBox_choose.Items.Add(negara.country);
                countryList.Add(negara);
                textBox_country.Clear();
                textBox_city.Clear();
                textBox_population.Clear();
            }
        }

        private void comboBox_choose_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_hasil.Items.Clear();
            int index = comboBox_choose.SelectedIndex;
            foreach (Country a in countryList)
            {
                if (a.country == comboBox_choose.Items[index])
                {
                    listBox_hasil.Items.Add("Country : " + a.country);
                    listBox_hasil.Items.Add("City : " + a.city);
                    listBox_hasil.Items.Add("Population : " + a.population);
                }
            }
        }

        private void button_combobox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear Combo Box Countries?", "Clear", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listBox_countrylist.Items.Clear();
                listBox_cityllist.Items.Clear();
                listBox_hasil.Items.Clear();
                comboBox_choose.Items.Clear();
            }
            else
            {
                MessageBox.Show("Gajadi Hapus Ya Bang", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
           
        }

        private void button_delcountry_Click(object sender, EventArgs e)
        {
            listBox_countrylist.Items.Remove(listBox_countrylist.SelectedItems);
            foreach (string co in listBox_cityllist.Items)
            {
                if(co.Contains(listBox_countrylist.Text))
                {
                    listBox_countrylist.Items.Remove(co);
                }
            }
            foreach (string ci in listBox_cityllist.Items)
            {
                if (ci.Contains(listBox_cityllist.Text))
                {
                    listBox_cityllist.Items.Remove(ci);
                }
            }
            foreach (string ha in listBox_cityllist.Items)
            {
                if (ha.Contains(listBox_hasil.Text))
                {
                    listBox_hasil.Items.Remove(ha);
                }
            }
        }
    }
}
