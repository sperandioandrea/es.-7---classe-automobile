using es._7___classe_automobile.Properties;
using System;
using System.Windows.Forms;

namespace es._7___classe_automobile
{
    public partial class Form1 : Form
    {
        Automobile auto;
        public Form1()
        {
            InitializeComponent();
            auto = new Automobile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //BOTTONE ACCENSIONE
        private void button1_Click(object sender, EventArgs e)
        {
            bool accensione = auto.MotoreAcceso;
            auto.AccendiMotore();
            listView1.Items.Clear();
            listView1.Items.Add("MOTORE ACCESO " + accensione);
        }
        //BOTTONE SPEGNIMENTO
        private void button2_Click(object sender, EventArgs e)
        {
            bool spegnimento = auto.MotoreAcceso;
            auto.SpegniMotore();
            listView1.Items.Clear();
            listView1.Items.Add("MOTORE SPENTO " + spegnimento);
            
        }
      

        
        //BOTTONE VELOCITA' +
        private void button3_Click(object sender, EventArgs e)
        {
            int acc = auto.Velocità;
            auto.Accellerare();
            listView1.Items.Clear();
            listView1.Items.Add("VELOCITA': " + acc + " k/h");
        }
        //BOTTONE VELOCITA' -
        private void button4_Click(object sender, EventArgs e)
        {
            int dec = auto.Velocità;
            auto.Decelerare();
            listView1.Items.Clear();
            listView1.Items.Add("VELOCITA':" + dec + " k/h");
        }




        //MARCIA +
        private void button5_Click(object sender, EventArgs e)
        {
            auto.AumentaMarcia();
            listView1.Items.Clear();
            listView1.Items.Add("SEI IN MARCIA:  " + auto.Marcia);
        }
        //MARCIA -
        private void button6_Click(object sender, EventArgs e)
        {
            auto.DiminuzioneMarcia();
            listView1.Items.Clear();
            listView1.Items.Add("SEI IN MARCIA: " + auto.Marcia);
        }

    }
}
