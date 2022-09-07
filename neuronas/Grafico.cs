using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace neuronas
{
    internal class Grafico
    {
        Pen lapiznegro = new Pen(Color.Black, 2);
        Pen lapizRojo = new Pen(Color.Red, 15);
        Pen lapizVerde = new Pen(Color.Green, 2);
        Pen lapizAzul = new Pen(Color.Blue, 15);

        Graphics dibujo;
        int i;
     
        public void plano(PictureBox cuadro)
        {

            int x = cuadro.Width / 2;
            int y = cuadro.Height / 2;
            dibujo = cuadro.CreateGraphics();
            dibujo.TranslateTransform(x, y);
            dibujo.ScaleTransform(1, -1);

            dibujo.DrawLine(lapiznegro, x * -1, 0, x * 1, 0);
            dibujo.DrawLine(lapiznegro, 0, y * -1, 0, y * 1);

            for (i = 0; i < 400; i = i + 40)
            {

                dibujo.DrawLine(lapiznegro, 10, i, -10, i);
                dibujo.DrawLine(lapiznegro, i, 10, i, -10);
                dibujo.DrawLine(lapiznegro, 10, -i, -10, -i);
                dibujo.DrawLine(lapiznegro, -i, 10, -i, -10);
            }
 

        }

        public void setPunto(Neurona a)
        {

            float x1 = a.getX1()*40;
            float x2 = a.getX2()*40;

            //dibujar una linea al rededor de la particula
            if (a.getY())
            {
                dibujo.DrawLine(lapizAzul, x1 - 2, x2 - 2, x1 + 2, x2 + 2);
            }
            else
            {
                dibujo.DrawLine(lapizRojo, x1 - 2, x2 - 2, x1 + 2, x2 + 2);
            }



            //2,2
            ;
        }
        public void printDiagonal()
        {
            dibujo.DrawLine(lapizVerde, 400, -340, -400, 460);
        }
        public Neurona setCordenada(int x,int y)
        {
            
            //MessageBox.Show("el eje x es "+x.ToString()+ "Eje y "+y.ToString());
                x = x-400;   
                y = 400-y;

            //MessageBox.Show("Coordenadas " + x.ToString() + " y: " + y.ToString());
            Neurona a = new Neurona((((float)x)/40),(((float)y)/40));

            return a;

        }
        
    }
    

}
