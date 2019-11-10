using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void flpBolge_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Mayinalani_Click(object sender, EventArgs e)
        {

            Bolge bolge = (Bolge)sender;

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            flpBolge.Controls.Clear();
            for (int i = 0; i < 100; i++)
            {
                Button mayinalani = new Button();
                mayinalani.Width = mayinalani.Height = 45;
                mayinalani.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                int mayin = rnd.Next(0, 2);
                mayinalani.Text = mayin.ToString();
                mayinalani.Tag = mayin;
                mayinalani.Click += Mayinalani_Click;

                flpBolge.Controls.Add(mayinalani);
            }
        }

        class Bolge: Button
        {
            private bool mayinlimi;
            public bool MayinliMi { get { return mayinlimi; } }

            private bool acildimi;
            public bool AcildiMi { get { return acildimi; } }

            private bool koordinatX;
            public bool KoordinatX { get { return koordinatX; } }

            private bool koordinatY;
            public bool KoordinatY { get { return koordinatX; } }

            void BolgeAc(int mayinsayisi)
            {
                if (mayinsayisi != 0)
                {
                    this.Text = mayinsayisi.ToString();
                    this.BackColor = Color.White;
                }
                this.Enabled = false;
                this.acildimi = true;

            }
            void BolgeAc()
            {
                if (mayinlimi == false)
                {
                    this.BackColor = Color.White;
                }
                else
                {
                    this.Image = Image.FromFile("C:/Kullanıcılar/User/Downloads/bomb.png");
                }
                this.acildimi = true;
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }  
}
