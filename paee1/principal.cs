namespace paee1
{
    public partial class principal : Form
    {
        private enum Operacion
        {
            Suma,
            Resta,
            Producto,
            Division
        }

        private int operando1, operando2, resultado;

        private Operacion operacion;

        private string lang = "es";
        public principal()
        {
            InitializeComponent();
            pnlDisplay.Text = "0";
            operando1 = 0;
            operando2 = 0;
            resultado = 0;
            ActualizarEstadoBotonIgual();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lang == "es")
            {
                lang = "en";
                label1.Text = "Hello World!";
            }
            else
            {
                lang = "es";
                label1.Text = "Hola Mundo!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {

        }

        private void menuAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Autor: Andrii Shybaiev \nVersion: 0.0.1",
                "Acerca de: Calculadora",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                if (pnlDisplay.Text == "0")
                {
                    pnlDisplay.Text = button.Text;
                }
                else
                {
                    pnlDisplay.Text += button.Text;
                }
                ActualizarEstadoBotonIgual();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt32(pnlDisplay.Text);
            operacion = Operacion.Suma;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt32(pnlDisplay.Text);
            operacion = Operacion.Resta;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt32(pnlDisplay.Text);
            operacion = Operacion.Producto;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operando1 = Convert.ToInt32(pnlDisplay.Text);
            operacion = Operacion.Division;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            operando2 = Convert.ToInt32(pnlDisplay.Text);
            switch (operacion)
            {
                case Operacion.Suma:
                    resultado = operando1 + operando2;
                    break;
                case Operacion.Resta:
                    resultado = operando1 - operando2;
                    break;
                case Operacion.Producto:
                    resultado = operando1 * operando2;
                    break;
                case Operacion.Division:
                    if (operando2 != 0)
                        resultado = operando1 / operando2;
                    else
                        MessageBox.Show("Error: Division por cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            pnlDisplay.Text = resultado.ToString();
            operando1 = 0;
            operando2 = 0;
            ActualizarEstadoBotonIgual();
        }

        private void ActualizarEstadoBotonIgual()
        {
            btnEq.Enabled = operacion != Operacion.Division || pnlDisplay.Text != "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text = "0";
            operando1 = 0;
            operando2 = 0;
            resultado = 0;
            ActualizarEstadoBotonIgual();
        }


    }
}
