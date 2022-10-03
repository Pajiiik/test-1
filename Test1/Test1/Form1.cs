using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void vypis(ListBox list, List<char> znak)
        {
            for(int i=0; i < znak.Count;i++)
            {
            list.Items.Add(znak[i]);
            }
        }


        string cislo_n_hodnot;
        int cislo;
        char rznak;
        List<char> list = new List<char>();
        List<int> cis_hodnoty = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            cislo_n_hodnot = textBox1.Text;
            try
            {
                cislo = int.Parse(cislo_n_hodnot);
                for (int i = 0; i <= cislo; i++)
                {
                    int nahoda = rng.Next(32, 128);
                    rznak = (char)nahoda;
                    list.Add(rznak);
                }

                ////////////////////////////////

                for (int z = 0; z < list.Count; z++)
                {
                    if (list[z].ToString() != " ")
                    {
                        textBox2.Text = textBox2.Text + list[z].ToString();
                    }
                    else
                    { 
                    
                    }
                }
                string slovo = "";
                for (int y = 0; y < list.Count;y++)
                {
                    if ((list[y] >= 65 && list[y] <= 90) || (list[y] >= 97 && list[y] <= 122))
                    {
                        slovo = slovo + list[y].ToString();
                    }
                    else if(slovo.Length >= 2)
                    {
                        listBox1.Items.Add(slovo);
                        slovo = "";
                    }
                }
                for (int u = 0; u < list.Count; u++)
                {
                    if (list[u] >= 48 && list[u] <= 57)
                    {
                        int znak = list[u];
                        cis_hodnoty.Add(znak);
                        listBox2.Items.Add(znak);   
                    }
                }

            }
            catch
            {
                textBox1.Clear();
            }


        }
    }
}
