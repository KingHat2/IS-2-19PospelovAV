using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class zadanie1 : Form
    {
        public zadanie1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
        abstract class Accessoies<a>
        {
            protected string cena;
            protected string godvepuska;
            protected string articul;
            public Accessoies(string Cena, string Godvepuska,string Articul)
            {
                cena = Cena;
                godvepuska = Godvepuska;
                articul = Articul;
            }
            public abstract void Display(ListBox ListBox1);

        }

        class Cp : Accessoies<string>
        {
            public string chestota1;
            public string kolvoaider1;
            public string kolvopotokov1;
            public Cp(string Cena, string Godvepuska, string Articul, string Chestota, string Kolvoaider, string Kolvopotokov)
                    : base(Cena, Godvepuska,Articul)
            {
                chestota = Chestota;
                kolvoaider = Kolvoaider;
                kolvopotokov = Kolvopotokov;
            }
             
            public string chestota { get { return chestota1; } set {chestota1 = value; } }
            public string kolvoaider { get { return kolvoaider1; } set { kolvoaider1 = value; } }
            public string kolvopotokov { get { return kolvopotokov1; } set { kolvopotokov1 = value; } }
            public override void Display(ListBox ListBox1)
            {
                ListBox1.Items.Add($"Цена{cena},Год выпуска{godvepuska},Частота{chestota},Количесвто ядер{kolvoaider},Количество потоков{kolvopotokov}, Артикул{articul}");
            }

        }
        class videocart :Accessoies<string>
        {
            public string chestota1;
            public string proizvod1;
            public string obempamati1;
            public videocart(string Cena, string Godvepuska,string Articul, string Chestota, string Proizvod, string Obempamati)
                    : base(Cena, Godvepuska,Articul)
            {
                chestota = Chestota;
                proizvod = Proizvod;
                obempamati = Obempamati;

            }

            public string chestota { get { return chestota1; } set { chestota1 = value; } }
            public string proizvod { get { return proizvod1; } set { proizvod1 = value; } }
            public string obempamati { get { return obempamati1; } set { obempamati1 = value; } }
            public override void Display(ListBox ListBox1)
            {
                ListBox1.Items.Add($"Цена{cena},Год выпуска{godvepuska},Частота{chestota},Производитель {proizvod},обьем памяти{obempamati},Артикул{articul}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cena = Convert.ToString(textBox1.Text);
            string godvepuska = Convert.ToString(textBox2.Text);
            string chestota = Convert.ToString(textBox3.Text);
            string proizvod = Convert.ToString(textBox4.Text);
            string obempamati = Convert.ToString(textBox5.Text);
            string Articul = Convert.ToString(textBox6.Text);
            videocart vd1 = new videocart(cena, godvepuska, Articul,chestota, proizvod, obempamati);
            vd1.Display(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cena = Convert.ToString(textBox1.Text);
            string godvepuska = Convert.ToString(textBox2.Text);
            string chestota = Convert.ToString(textBox3.Text);
            string Kolvoaider = Convert.ToString(textBox4.Text);
            string Kolvopotokov = Convert.ToString(textBox5.Text);
            string Articul = Convert.ToString(textBox6.Text);
            Cp  cp1 = new Cp(cena, godvepuska,Articul, chestota, Kolvoaider, Kolvopotokov);
            cp1.Display(listBox1);
        }
    }
}
