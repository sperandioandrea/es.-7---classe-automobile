using es._7___classe_automobile;
using es._7___classe_automobile.Properties;
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
            velocità = 0;
            marcia = 0;
            motoreAcceso = false;
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
            set { motoreAcceso = value; }
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
            if (motoreAcceso)
            {
                velocità += 10;
            }
        }
        public void Decelerare()
        {
            if (motoreAcceso && velocità > 0)
            {
                velocità -= 10;
            }
        }


        //AUMENTO E DIMINUZIONE MARCIA CAMBIO MANUALE
        public void AumentaMarcia()
        {
            if (motoreAcceso && marcia < 5)
            {
                marcia++;
            }
        }
        public void DiminuzioneMarcia()
        {
            if (motoreAcceso && marcia > 1)
            {
                marcia--;
            }
        }

        //AUMENTO E DIMINUZIONE MARCIA CAMBIO AUTOMATICO
        public void AggiornaMarcia()
        {
            if (velocità < 20)
            {
                marcia = 1;
            }
            else if (velocità >= 20 && velocità < 40)
            {
                marcia = 2;
            }
            else if (velocità >= 40 && velocità < 60)
            {
                marcia = 3;
            }
            else if (velocità >= 60 && velocità < 100)
            {
                marcia = 4;
            }
            else
            {
                marcia = 5;
            }
        }

        public int GetVelocita()
        {
            return velocità;
        }

        public int GetMarcia()
        {
            return marcia;
        }

    }

}
//Classe derivata
class AutomobileCambioautomatico : Automobile 
{

}


