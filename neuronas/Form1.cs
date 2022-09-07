namespace neuronas
{
    public partial class Form1 : Form
    {
        List<Neurona> lista = new List<Neurona>();
        Grafico objGrafico = new Grafico();
        int EJEX;
        int EJEY;
        public Form1()
        {
            InitializeComponent(); 
        }
        private void X2_Click(object sender, EventArgs e)
        {

        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {

           
            try
            {
                Neurona neurona;
                float a = float.Parse(txtX1.Text);
                float b = float.Parse(txtX2.Text);
                txtX1.Text = "";
                txtX2.Text = "";
                neurona = new Neurona(a, b);
                objGrafico.setPunto(neurona);
                lista.Add(neurona);
                //bool val = neurona.getY();
                //MessageBox.Show("la neurona es " + val.ToString());
            }
            catch(System.FormatException )
            {
                MessageBox.Show("Parece que a olvidado llenar las variables requeridas para agregar una neurona");
            }


        }

        private void btnPlano_Click(object sender, EventArgs e)
        {
            objGrafico.plano(pb_grafico);
            objGrafico.printDiagonal();
        }

        private void pb_grafico_MouseMove(object sender, MouseEventArgs e)
        {
            EJEX = e.X;
            EJEY = e.Y;
        }
        private void pb_grafico_Click(object sender, EventArgs e)
        {
            Neurona a= objGrafico.setCordenada(EJEX, EJEY);
            objGrafico.setPunto(a);
            lista.Add(a);
        }
    }
}