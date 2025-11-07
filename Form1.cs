namespace Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            int valorX = int.Parse(inputTextX.Text);
            int valorY = int.Parse(inputTextY.Text);

            int operacao = valorX + valorY;

            string formatoSaida = "Resultado da opera??o entre " + valorX + "e " +
                    valorY + " foi igual ?: " + operacao;

            labelOutput.Visible = true;
            labelOutput.Text = formatoSaida;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }
    }
}