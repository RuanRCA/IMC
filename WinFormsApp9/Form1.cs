namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDefinicao.Visible = false;
            lblIndiceMassa.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {          
            double altura, peso, IMC;

            altura = double.Parse(mskaltura.Text);
            peso = double.Parse(mskPeso.Text);

            IMC = peso / (altura * altura);

            lblDefinicao.Text = IMC.ToString("N2");

            if (IMC < 18.5)
            {
                lblIndiceMassa.Text = "Abaixo do Peso";
                pcbPesos.Image = Properties.Resources.Baixopeso;
                lblDefinicao.Visible = true;
                lblIndiceMassa.Visible = true;
            }

            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                lblIndiceMassa.Text = "Peso Ideal";
                pcbPesos.Image = Properties.Resources.Idealpeso;
                lblDefinicao.Visible = true;
                lblIndiceMassa.Visible = true;
            }

            else if (IMC >= 25.00 && IMC <= 29.9)
            {
                lblIndiceMassa.Text = "Sobre Peso ";
                pcbPesos.Image = Properties.Resources.SobrePeso;
                lblDefinicao.Visible = true;
                lblIndiceMassa.Visible = true;
            }

            else if (IMC >= 30.0 && IMC <= 34.9)
            {
                lblIndiceMassa.Text = "Obesidade 1 ";
                pcbPesos.Image = Properties.Resources.Obesidade1;
                lblDefinicao.Visible = true;
                lblIndiceMassa.Visible = true;
            }

            else if (IMC >= 35.0 && IMC <= 39.9)
            {
                lblIndiceMassa.Text = "Obesidade 2 ";
                pcbPesos.Image = Properties.Resources.Obesidade2;
                lblDefinicao.Visible = true;
                lblIndiceMassa.Visible = true;
            }

            else if (IMC >= 40.0)
            {
                lblIndiceMassa.Text = "Obesidade Grave";
                pcbPesos.Image = Properties.Resources.Obesidadegrave;
                lblDefinicao.Visible = true;
                lblIndiceMassa.Visible = true;
            }






        }
    }
}