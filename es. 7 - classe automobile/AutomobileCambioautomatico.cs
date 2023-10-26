using es._7___classe_automobile.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._7___classe_automobile
{
    class AutomobileCambioautomatico : Automobile
    {
        public AutomobileCambioautomatico() : base()
        {
            velocità = 0;
            marcia = 0;
            motoreAcceso = false;
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
        //metodidi get e set
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
    

