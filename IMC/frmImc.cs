namespace IMC
{
    public partial class FmrImc : Form
    {
        public FmrImc()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal peso, altura;
            peso  = Convert.ToDecimal(txtPeso.Text);
            altura =  Convert.ToDecimal(textAltura.Text);
            var (descricaoimc, resultadoimc) = CalcularImc(peso, altura/100);
            lblResultado.Text = $"\n{descricaoimc}\nSeu IMC é {resultadoimc:f2}";

        }

        private (string, decimal) CalcularImc(decimal peso, decimal altura)
        {
            decimal imc = peso / (altura * altura);
            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (resultado, imc);
            }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            textAltura.Clear();
            lblResultado.Text = String.Empty;

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}