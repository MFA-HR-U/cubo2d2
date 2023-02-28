namespace cubo2d
{
    public partial class Form1 : Form
    {

        Graphics g;
        Bitmap bmp;

        FiguraGrupPuntos puntosCubo;


        Transformaciones t;
        int Sx;
        int Sy;
        float angulo=30;

        public Form1()
        {
            InitializeComponent();
        }

        public void Inicialiizar()
        {
            bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);//el constructor de la vrable global

            g = Graphics.FromImage(bmp); //trabje el bitmap como objeto de clase grapihcs +

            pictureBox1.Image = bmp;

            


            
             Sx = (pictureBox1.Width / 2);  // origen central en x
          Sy= (pictureBox1.Height / 2);

        }

        public void InicioCuadrado()
        {

            puntosCubo = new FiguraGrupPuntos();

            puntosCubo.Addo(new PointF(0, 0));//a
            puntosCubo.Addo(new Point(0, 100)); //b
            puntosCubo.Addo(new Point(100, 100));  //c
            puntosCubo.Addo(new Point(100, 0));    //d
            t = new Transformaciones(puntosCubo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicialiizar();

            //pongo este metod aqui para guarde valores que voy a estar trabajndo
            

           
            g.DrawLine(Pens.Yellow, bmp.Width / 2, 0, bmp.Width / 2, bmp.Height);
            g.DrawLine(Pens.Yellow, 0, bmp.Height / 2, bmp.Width, bmp.Height / 2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            InicioCuadrado();
            List<PointF> xxx = new List<PointF>();

            // aqui figura temp tiene valores orginales

            t.OrigenAkkaEsquiina(g);
            //aqui temp y listatrabjo tiene valores de -50 50



           t.rotar(angulo);
            //hacer transformacuiones y devolver


            t.CuadradoAlcentro(Sx, Sy, g);



            //aqui temp tiene valores del centro 670
            pictureBox1.Invalidate();
            //t.clear();
            
            angulo = angulo + 1;

            

        }
    }
}