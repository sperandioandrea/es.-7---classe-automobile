using System;

namespace es._7___classe_automobile.Properties
{
    class Automobile
    {
        //attributi
        private int velocità;
        private int marcia;
        private bool motoreAcceso;

        //costruttore
        public Automobile()
        {
            velocità= 0;
            marcia= 0;
            motoreAcceso= false;
        }
        //metodi get e set
        public int Velocità
        {
            get { return velocità; }
            set { velocità = value; }
        }
        public int Marcia
        {
            get { return marcia; }  
            set { marcia = value; }
        }
        public bool MotoreAcceso
        {
            get { return motoreAcceso; }
            set {  motoreAcceso = value; }
        }


        //ACCENSIONE E SPEGNIMENTO MOTORE
        public void AccendiMotore()
        {
            motoreAcceso = true;
        }
        public void SpegniMotore()
        {
            motoreAcceso = false;
        }


        //ACCELERARE E DECELERARE
        public void Accellerare()
        {
            if(motoreAcceso)
            {
                velocità += 10;
            }
        }
        public void Decelerare()
        {
            if(motoreAcceso && velocità > 0)
            {
                velocità -= 10;
            }
        }


        //AUMENTO E DIMINUZIONE MARCIA
        public void AumentaMarcia()
        {
            if (motoreAcceso && marcia < 5)
            {
                marcia++;
            }
        }
        public void DiminuzioneMarcia()
        {
            if(motoreAcceso && marcia > 1)
            {
                marcia--;
            }
        }
    }
}
