namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCompletivo.Enabled = false;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNota1.Text);
            double n2 = double.Parse(txtNota2.Text);
            double n3 = double.Parse(txtNota3.Text);
            double n4 = double.Parse(txtNota4.Text);

            double promedio = (n1 + n2 + n3 + n4) / 4;
            lblPromedio.Text = promedio.ToString("0.00");


            if (promedio > 69)
            {
                lblResultado.Text = "aprobado tu ere un duro";
                txtCompletivo.Enabled = false;
                return;
            }

            txtCompletivo.Enabled = true;

            if (string.IsNullOrEmpty(txtCompletivo.Text))
            {
                MessageBox.Show("Ingrese la nota del completivo");
                return;
            }

            double completivo = double.Parse(txtCompletivo.Text);


            double notaCompletiva = (promedio * 0.50) + (completivo * 0.50);

            if (notaCompletiva > 69)
            {
                lblResultado.Text = "aprobado por completivo te salvate";
            }
            else
            {

                double notaExtraordinaria = (promedio * 0.30) + (completivo * 0.70);

                if (notaExtraordinaria > 69)
                {
                    lblResultado.Text = "aprobado por extraordinario buen especial";
                }
                else
                {
                    lblResultado.Text = "reprobado anormal";
                }
            }
        }




        private void btnLimpiar_click_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtCompletivo.Clear();

            txtCompletivo.Enabled = false;

            lblPromedio.Text = "";
            lblResultado.Text = "";

            txtNota1.Focus();
        }

        private void lblPromedio_Click(object sender, EventArgs e)
        {

        }
    }
}