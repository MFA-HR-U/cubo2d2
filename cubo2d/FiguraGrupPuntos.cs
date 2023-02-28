using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubo2d
{
    public class FiguraGrupPuntos
    {

        //varibales globales
        public List<PointF> vertices;
        public PointF Centroide;



        public FiguraGrupPuntos()//metodo constructor
        {
            // inicializar objeto lista
            vertices = new List<PointF>();
        }

        public void Addo(PointF point)   //agrgar los vertices a la lista
        {
            Centroide = new PointF();
            vertices.Add(point);

            for (int p = 0; p < vertices.Count; p++)
            {
                Centroide.X += vertices[p].X;
                Centroide.Y += vertices[p].Y;
            }


            Centroide.X /= vertices.Count;
            Centroide.Y /= vertices.Count;
        }


        public void actualizar(List<PointF> verticesnuevos)   //agrgar los vertices a la lista
        {
            Centroide = new PointF();
            vertices.Clear();
            for (int i = 0; i < verticesnuevos.Count; i++)
            {

                vertices.Add(new PointF(verticesnuevos[i].X, verticesnuevos[i].Y));
            }

            for (int p = 0; p < verticesnuevos.Count; p++)
            {
                Centroide.X += vertices[p].X;
                Centroide.Y += vertices[p].Y;
            }


            Centroide.X /= vertices.Count;
            Centroide.Y /= vertices.Count;
        }

        public void reiniciar()   //agrgar los vertices a la lista
        {
            vertices.Clear();
            Centroide= new PointF();
        }
    }
    


}
