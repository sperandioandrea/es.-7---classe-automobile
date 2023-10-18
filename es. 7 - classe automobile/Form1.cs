using es._7___classe_automobile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es._7___classe_automobile
{
    public partial class Form1 : Form
    {
        Automobile auto;
        public Form1()
        {
            InitializeComponent();
            Automobile auto = new Automobile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            auto.Velocità = 10;
            auto.Marcia = 1;
            auto.MotoreAcceso = true;
        }


        //BOTTONE ACCENSIONE
        private void button1_Click(object sender, EventArgs e)
        {
            auto.AccendiMotore();
            listView1.Items.Clear();
            listView1.Items.Add("Motore acceso");
        }
        //BOTTONE SPEGNIMENTO
        private void button2_Click(object sender, EventArgs e)
        {
            auto.SpegniMotore();
            listView1.Items.Clear();
            listView1.Items.Add("Motore spento");
        }
      
        
        //BOTTONE VELOCITA' +
        private void button3_Click(object sender, EventArgs e)
        {
            auto.Accellerare();
            listView1.Items.Clear();
            listView1.Items.Add("Velocità:");
        }
        //BOTTONE VELOCITA' -
        private void button4_Click(object sender, EventArgs e)
        {
            auto.Decelerare();
            listView1.Items.Clear();
            listView1.Items.Add("Velocità:");
        }


        //MARCIA +
        private void button5_Click(object sender, EventArgs e)
        {
            auto.AumentaMarcia();
            listView1.Items.Clear();
            listView1.Items.Add("Marcia:");
        }
        //MARCIA -
        private void button6_Click(object sender, EventArgs e)
        {
            auto.DiminuzioneMarcia();
            listView1.Items.Clear();
            listView1.Items.Add("Marcia:");
        }
    }
}
