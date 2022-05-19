namespace Calcula_sueldoneto
{
    public partial class Form1 : Form
    {
        double afp,ISR,srs,sb,sn;

        private void txtSN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSN.Text =Convert.ToString(sb-((sb*afp)+(sb*ISR)+(sb*srs)));
        }

        private void txtARS_TextChanged(object sender, EventArgs e)
        {
            ISR=Convert.ToDouble(txtISR.Text);
        }

        private void txtSRS_TextChanged(object sender, EventArgs e)
        {
            srs=Convert.ToDouble(txtSRS.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSB_TextChanged(object sender, EventArgs e)
        {
            sb=Convert.ToDouble(txtSB.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            afp = Convert.ToDouble(txtafp.Text);
            
        }
    }
}