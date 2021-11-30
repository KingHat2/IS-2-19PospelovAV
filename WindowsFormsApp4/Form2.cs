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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
        abstract class Accessoies
        {
            protected string cena;
            protected string godvepuska;

            public Accessoies(string Cena, string Godvepuska)
            {
                cena = Cena;
                godvepuska = Godvepuska;
            }
            public abstract void Display(ListBox ListBox1);

        }

        class Cp : Accessoies
        {
            public string chestota1;
            public string kolvoaider1;
            public string kolvopotokov1;
            public Cp(string Cena, string Godvepuska, string Chestota, string Kolvoaider, string Kolvopotokov)
                    : base(Cena, Godvepuska)
            {
                chestota = Chestota;
                kolvoaider = Kolvoaider;
                kolvopotokov = Kolvopotokov;
            }
             
            public string chestota { get { return chestota1; } set { chestota = value; } }
            public string kolvoaider { get { return kolvoaider1; } set { chestota = value; } }
            public string kolvopotokov { get { return kolvopotokov1; } set { chestota = value; } }
            public override void Display(ListBox ListBox1)
            {
                ListBox1.Items.Add($"{cena},{godvepuska},{chestota},{kolvoaider},{kolvopotokov}");
            }

        }
        class videocart 
        {
        
        
        
        
        
        
        }
    
    }
}
