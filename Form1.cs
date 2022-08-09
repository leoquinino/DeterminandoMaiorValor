namespace DeterminandoMaiorValor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            double[] ValorLimite = new double[3];
            double MenorValor = 0.00, MaiorValor = 0.00;
            int posicao_menor = 0, posicao_maior = 0;

            ValorLimite[0] = Convert.ToDouble(txtBoxNum1.Text);
            ValorLimite[1] = Convert.ToDouble(txtBoxNum2.Text);
            ValorLimite[2] = Convert.ToDouble(txtBoxNum3.Text);

            for (int i = 0; i < 3; i++)
            {
                if (ValorLimite[i] < MenorValor)
                {
                    MenorValor = ValorLimite[i];
                    posicao_menor = i;
                }
                else if (ValorLimite[i] > MaiorValor)
                {
                    MaiorValor = ValorLimite[i];
                    posicao_maior = i;
                }
            }
            richTextBox1.Text = "";
            richTextBox1.AppendText("Maior Valor é : " + Convert.ToString(MaiorValor));
        }
    }
}