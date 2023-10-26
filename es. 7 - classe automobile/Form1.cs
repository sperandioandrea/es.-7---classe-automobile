using es._7___classe_automobile.Properties;
using System;
using System.Windows.Forms;

namespace es._7___classe_automobile
{
    public partial class Form1 : Form
    {
        Automobile auto;
        AutomobileCambioautomatico cambio; //classe derivata
        public Form1()
        {
            InitializeComponent();
            auto = new Automobile();
            cambio = new AutomobileCambioautomatico(); //classe derivata
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //BOTTONE ACCENSIONE
        private void button1_Click(object sender, EventArgs e)
        {           
            auto.AccendiMotore();
            listView1.Items.Clear();
            listView1.Items.Add("ACCENSIONE MOTORE  -->  MOTORE ACCESO");
        }
        //BOTTONE SPEGNIMENTO
        private void button2_Click(object sender, EventArgs e)
        {
            auto.SpegniMotore();
            listView1.Items.Clear();
            listView1.Items.Add("SPEGNIMENTO MOTORE  -->  MOTORE SPENTO");            
        }
      

        
        //BOTTONE VELOCITA' +
        private void button3_Click(object sender, EventArgs e)
        {
            
            auto.Accellerare();
            listView1.Items.Clear();
            listView1.Items.Add("VELOCITA':  " + auto.Velocità + " k/h");
        }
        //BOTTONE VELOCITA' -
        private void button4_Click(object sender, EventArgs e)
        {
            
            auto.Decelerare();
            listView1.Items.Clear();
            listView1.Items.Add("VELOCITA':  " + auto.Velocità + " k/h");
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

        //MARCIA + AUTOMATICO (classe derivata)
        private void button7_Click(object sender, EventArgs e)
        {
            cambio.AggiornaMarcia();
            cambio.GetMarcia();
            cambio.GetVelocita();
            listView1.Items.Clear();
            listView1.Items.Add("SEI IN MARCIA: " + cambio.Marcia);
        }
        //MARCIA - AUTOMATICO
        private void button8_Click(object sender, EventArgs e)
        {
            cambio.AggiornaMarcia();
            listView1.Items.Clear();
            listView1.Items.Add("SEI IN MARCIA: " + cambio.Marcia);
        }
    }
}
