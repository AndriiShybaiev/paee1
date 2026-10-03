namespace paee1
{
    public partial class principal : Form
    {
        private string lang = "es";
        public principal()
        {
            InitializeComponent();
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

        private void btn7_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "8";
        }
        
        private void btn9_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pnlDisplay.Text += "3";
        }


    }
}
