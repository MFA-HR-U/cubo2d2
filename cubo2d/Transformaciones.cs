using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace cubo2d
{
    public class Transformaciones
    {

        List<PointF> listaTrabajotemp = new List<PointF>();
        public List<PointF> verticesnuevossss;
        FiguraGrupPuntos temp;

        public Transformaciones(FiguraGrupPuntos f) 
        {
           //asignar valores originales a variable tempo
            temp = f;
            verticesnuevossss= new List<PointF>();

        }

       
            public void CuadradoAlcentro(int Sx, int Sy, Graphics Dib)
            {
            for (int i = 0; i < 1; i++)
            {
                temp.actualizar(listaTrabajotemp);
            }
            float x = temp.Centroide.X - temp.Centroide.X - temp.Centroide.X;
                float xCentroid = x + Sx;

                float y = temp.Centroide.Y - temp.Centroide.Y - temp.Centroide.Y;
                float yCentroid = y + Sy;

            

            listaTrabajotemp.Clear();


            for (int i = 0; i < temp.vertices.Count ; i++)
                {
                listaTrabajotemp.Add(new Point((int)temp.vertices[i].X + (int)xCentroid, (int)temp.vertices[i].Y + (int)yCentroid));
                }
            Dib.DrawPolygon(Pens.Orange, listaTrabajotemp.ToArray());
            Dib.Dispose();

            }

        public void  OrigenAkkaEsquiina(Graphics g)//lo ponel el 00 en la esquina
        {


            //guardo valores antiguos para trabajar pero guardo todo nueva lista
   
            for (int p = 0; p < temp.vertices.Count ; p++)
            {
                listaTrabajotemp.Add(new PointF((float)temp.vertices[p].X - temp.Centroide.X, temp.vertices[p].Y - temp.Centroide.Y));


            }
       // g.DrawPolygon(Pens.Yellow, listaTrabajotemp.ToArray());

        }


       

       

        public void rotar(float angle)
        {

            if (angle > 360)
                angle = 360;

            if (angle < -360)
                angle = 0;

            for (int i = 0; i <1 ; i++)
            {
                temp.actualizar(listaTrabajotemp);
            }

            float x, y;


            listaTrabajotemp.Clear();



          

            for (int i = 0; i < temp.vertices.Count ; i++)
            {

              
                x = (float)((temp.vertices[i].X * Math.Cos(angle)) - (temp.vertices[i].Y * Math.Sin(angle)));

                y = (float)((temp.vertices[i].X * Math.Sin(angle)) + (temp.vertices[i].Y * Math.Cos(angle)));

                listaTrabajotemp.Add(new PointF(x,y));

            }
           

        }
        public void clear()
        {
            for (int i = 0; i < temp.vertices.Count && listaTrabajotemp.Count < 5; i++)
            {
               // temp.actualizar((List<PointF>)temp.vertices[i]);
            }
        }

    }
}
