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
            Division,
            Potencia
        }

        private double operando1, operando2, resultado;

        private Operacion operacion;
        private bool operacionPendiente;

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
                ActualizarIndicadorOperacion();
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (pnlDisplay.Text.Contains('.')) return;

            pnlDisplay.Text += ".";
            ActualizarEstadoBotonIgual();
            ActualizarIndicadorOperacion();
        }

        private void btnPlusMin_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out double valor)) return;

            pnlDisplay.Text = (-valor).ToString(CultureInfo.InvariantCulture);
            ActualizarEstadoBotonIgual();
            ActualizarIndicadorOperacion();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Suma;
            operacionPendiente = true;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
            ActualizarIndicadorOperacion();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Resta;
            operacionPendiente = true;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
            ActualizarIndicadorOperacion();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Producto;
            operacionPendiente = true;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
            ActualizarIndicadorOperacion();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Division;
            operacionPendiente = true;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
            ActualizarIndicadorOperacion();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (!TryObtenerValorDisplay(out operando1)) return;
            operacion = Operacion.Potencia;
            operacionPendiente = true;
            pnlDisplay.Text = "0";
            ActualizarEstadoBotonIgual();
            ActualizarIndicadorOperacion();
        }

        private void ActualizarIndicadorOperacion()
        {
            if (!operacionPendiente)
            {
                lblOperacion.Text = string.Empty;
                return;
            }

            lblOperacion.Text = $"{operando1.ToString(CultureInfo.InvariantCulture)} {ObtenerSimboloOperacion()} {pnlDisplay.Text}";
        }

        private string ObtenerSimboloOperacion()
        {
            return operacion switch
            {
                Operacion.Suma => "+",
                Operacion.Resta => "−",
                Operacion.Producto => "×",
                Operacion.Division => "÷",
                Operacion.Potencia => "^",
                _ => string.Empty
            };
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!operacionPendiente) return;
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
                case Operacion.Potencia:
                    resultado = Math.Pow(operando1, operando2);
                    break;
            }

            if (double.IsNaN(resultado))
            {
                MessageBox.Show("La potencia no está definida para estos valores.", "Operación no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.IsFinite(resultado))
            {
                MessageBox.Show("La operación excede el rango permitido.", "Desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            pnlDisplay.Text = resultado.ToString(CultureInfo.InvariantCulture);
            lblOperacion.Text = $"{operando1.ToString(CultureInfo.InvariantCulture)} {ObtenerSimboloOperacion()} {operando2.ToString(CultureInfo.InvariantCulture)} = {pnlDisplay.Text}";
            operando1 = 0;
            operando2 = 0;
            operacionPendiente = false;
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
            btnEq.Enabled = !operacionPendiente ||
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
            operacionPendiente = false;
            lblOperacion.Text = string.Empty;
            ActualizarEstadoBotonIgual();
        }


    }
}
