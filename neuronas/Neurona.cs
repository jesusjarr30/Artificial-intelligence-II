using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neuronas
{
   
    internal class Neurona
    {
        private float x1;
        private float x2;
        private bool y;//para ver si la ponderacion paso el caso
        private float w1;
        private float w2;


        public Neurona(float a,float b)
        {
            //definimos vsaores constantes
            w1 = 1;
            w2 = 1;
            x1 = a;
            x2 = b;
            y = false;
            umbralActivacion();
        }
        public void umbralActivacion()
        {
            //definimos el umbral de activacion como una constante
            float umbral = 1.5f;
            float suma = 0;

            suma = (x1 * w1) + (x2 * w2);
            if (suma > umbral)
            {
                y = true;
            }
        }
        public Boolean getY()
        {
            return y;
        }
        public float getX1()
        {
            return x1;
        }
        public float getX2()
        {
            return x2;
        }
       



    }
}
