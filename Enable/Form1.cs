namespace Enable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double total = 0;
            double iva = 0;
            double subTotal = 0;
            double cantidadFamiliar = 0;
            double cantidadDuo = 0;
            double cantidadInfantil = 0;
            double cantidadEltrio = 0;

            cantidadFamiliar = double.Parse(txtFamiliar.Text);
            cantidadDuo = double.Parse(txtDuo.Text);
            cantidadInfantil = double.Parse(txtInfantil.Text);
            cantidadEltrio = double.Parse(txtEltrio.Text);

            
         
            if (chkFamiliar.Checked = true)
            {
                subTotal = subTotal + (cantidadFamiliar * 85);
            }
            if (chkDuo.Checked = true)
            {
                subTotal = subTotal + (cantidadDuo * 90);
            }
            if (chkInfantil.Checked = true)
            {
                subTotal = subTotal + (cantidadInfantil * 105);
            }
            if (chkEltrio.Checked = true)
            {
                subTotal = subTotal + (cantidadEltrio * 95.5);
            }

            MessageBox.Show("El total es " + subTotal);
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chkFamiliar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFamiliar.Checked = true)
            {
                txtFamiliar.Enabled = true;
            }

        }

        private void chkDuo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDuo.Checked = true)
            {
                txtDuo.Enabled = true;
            }
        }

        private void chkInfantil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInfantil.Checked = true)
            {
                txtInfantil.Enabled = true;
            }
        }

        private void chkEltrio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEltrio.Checked = true)
            {
                txtEltrio.Enabled = true;
            }
        }
    }
}
