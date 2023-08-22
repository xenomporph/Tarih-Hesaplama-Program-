using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarih_Hesaplama_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();

            /* ChartForm form2 = new ChartForm();
             form2.Show();
             this.Hide();*/

        }


        private void hakkımızdaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bu program Kurt Ahmet Erek tarafından hazırlanmıştır.", "Hakkımızda", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan zaman;
            int gunFarki;
            zaman = DateTime.Parse(dateTimePicker2.Text) - DateTime.Parse(dateTimePicker1.Text);
            gunFarki = zaman.Days;
            lblGun.Text = gunFarki.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int eklenenGun = 0;
            eklenenGun = Convert.ToInt16(textBox1.Text);

            if (comboBox1.Text == "EKLE")
            {
                DateTime date1 = new DateTime();
                date1 = DateTime.Parse(dateTimePicker3.Text);
                date1 = date1.AddDays(eklenenGun);

                lblYeniTarih.Text = date1.ToShortDateString();
            }
            else if (comboBox1.Text == "ÇIKAR")
            {
                DateTime date1 = new DateTime();
                date1 = DateTime.Parse(dateTimePicker3.Text);
                date1 = date1.AddDays((eklenenGun)*(-1));

                lblYeniTarih.Text = date1.ToShortDateString();
            }







            /* eklenenGun = ekleZaman.Days;
*/

            /* 
           Console.Write("Eklenecek gün sayısını girin : ");
           int gun = Convert.ToInt32(Console.ReadLine());
           DateTime date = DateTime.Today;
           Console.WriteLine(gun + " gün sonraki tarih " + String.Format("{0:d/M/yyyy}", date.AddDays(gun)));
            */

            /*try
            {

                // creating object of DateTime
                DateTime date1 = new DateTime(2010, 1, 1,
                                               8, 0, 15);

                // adding the 36 days
                // using AddDays() method;
                DateTime date2 = date1.AddDays(36);

                // Display the date1
                System.Console.WriteLine("DateTime before " +
                          "operation: {0:y} {0:dd}", date1);

                // Display the date2
                System.Console.WriteLine("\nDateTime after" +
                         " operation: {0:y} {0:dd}", date2);
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }*/


        }
    }
}
