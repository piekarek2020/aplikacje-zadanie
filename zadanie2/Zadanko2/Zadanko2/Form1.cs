using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadanko2
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 2021; i >= 1900; i--)
                {
                    comboBox3.Items.Add(i);
                }
            panel1.Visible = false;
        }
        private void show()
        {
            panel1.Visible = true;
        }
        private void hide()
        {
            panel1.Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox3.Text) <= 2003)
            {
                show();
            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox4.Text.Length != 0)
            {
                richTextBox1.Text += comboBox4.Text;
                richTextBox1.Text += ", ";
            }
            else
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\macie\Desktop\halo\" + nazwisko.Text + "_" + imie.Text + ".txt";
            string tekst = "Dane klienta: \r\n ";
            tekst += "nazwisko: " + nazwisko.Text + " " + "imie: " + " " + imie.Text + "\r\n ";
            tekst += "Dane kontaktowe: \r\n";
            tekst += "Adres: " + adres.Text + "\r\n";
            tekst += "Telefon: " + lokal.Text + "\r\n";
            tekst += "Zamówienie: " + richTextBox1.Text + "\r\n";
            tekst += "złożono: " + DateTime.Now.ToString("dddd, dd MM yyyy") + "\r\n";
            if (imie.Text.Length == 0 || nazwisko.Text.Length == 0 || adres.Text.Length == 0 || lokal.Text.Length == 0)
            {
                MessageBox.Show("Uzupełnij dane!");
            }
            else 
            { 
                    if (!File.Exists(path))
                    {
                        File.WriteAllText(path, tekst);
                    }
                    else
                    {
                        string zmiana = "";
                        zmiana += "złożono: " + DateTime.Now.ToString("dddd, dd MM yyyy") + "\r\n";
                        File.AppendAllText(path, zmiana);
                    }
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
