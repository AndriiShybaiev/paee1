using System.Globalization;

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

        private double operando1, operando2, resultado;

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
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
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

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (pnlDisplay.Text.Contains('.')) return;

            pnlDisplay.Text += ".";
            ActualizarEstadoBotonIgual();
        }

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out double valor)) return;

            pnlDisplay.Text = (-valor).ToString(CultureInfo.InvariantCulture);
            ActualizarEstadoBotonIgual();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Suma;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Resta;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Producto;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Division;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando2)) return;

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
                    if (operando2 == 0)
                    {
                        MessageBox.Show("Error: no se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultado = operando1 / operando2;
                    break;
            }

            if (!double.IsFinite(resultado))
            {
                MessageBox.Show("La operación excede el rango permitido.", "Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pnlDisplay.Text = resultado.ToString(CultureInfo.InvariantCulture);
            operando1 = 0;
            operando2 = 0;
            ActualizarEstadoBotonIgual();
        }

        private bool TryObtenerValorDisplay(out double valor)
        {
            if (double.TryParse(
                pnlDisplay.Text,
                NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out valor) && double.IsFinite(valor))
            {
                return true;
            }

            MessageBox.Show("Error: el número excede el rango permitido.", "Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void ActualizarEstadoBotonIgual()
        {
            btnEq.Enabled = operacion != Operacion.Division ||
                (double.TryParse(
                    pnlDisplay.Text,
                    NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
                    CultureInfo.InvariantCulture,
                    out double segundoOperando) && double.IsFinite(segundoOperando) && segundoOperando != 0);
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
