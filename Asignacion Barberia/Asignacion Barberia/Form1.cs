namespace Asignacion_Barberia
{
    public partial class Form1 : Form
    {
        
        List<string> barberos=new List<string>();
        List<Citas> citas=new List<Citas>();

        public Form1()
        {
            InitializeComponent();
            llenarhoras();
            fillbarberos();
        }

        private void fillbarberos()
        {
            barberos.Add("Carlos");
            barberos.Add("Leonel");
            barberos.Add("Carlitos");
            ListBarb.DataSource = barberos;
        }

        private void llenarhoras()
        {
            var horas = Enumerable.Range(00, 22).Select(i => (DateTime.MinValue.AddHours(i)).ToString("hh.mm tt"));
            Hora.DataSource=horas.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Barbero_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrarcontrol();
            PorDefault();
            Informacion.Enabled = true;
        }

        private void PorDefault()
        {
            ListBarb.SelectedIndex = 0;
            fechaselect.Value = DateTime.Now;
            Hora.SelectedText = DateTime.Now.ToString("hh");
        }

        private void Borrarcontrol()
        {
            NomClnt.Text = String.Empty;
            NumClnt.Text = String.Empty;
            CorreoClnt.Text = String.Empty;
       
        }

        private void SaveBtt_Click(object sender, EventArgs e)
        {
            SaveCita();
        }

        private void Namelbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void SaveCita()
        {
            var random = new Random();
            var cita = new Citas()
            {
                id = Guid.NewGuid(),
                code = random.Next(10000,99999).ToString(),
                nombreCliente = NomClnt.Text,
                telCliente = NumClnt.Text,
                emailCliente = CorreoClnt.Text,
                nombreBarbero = ListBarb.SelectedValue.ToString(),
                fechafijada=fechaselect.Value,
                horafijada = Hora.SelectedValue.ToString(),
                fechaCreada = DateTime.Now,
            };

            var citaexistente = citas.Count(c => c.fechafijada.ToString("dd/mm/yyyy") == fechaselect.Value.ToString("dd/mm/yyyy") && c.horafijada == Hora.SelectedValue.ToString());
            if (citaexistente > 0)
            {
                MessageBox.Show("Este horario ya se encuentra lleno");
            }

            citas.Add(cita);

            GetCitas();

            Informacion.Enabled = false;
            Borrarcontrol();

        }

        private void GetCitas()
        {
            DGVcitas.DataSource = null;
            DGVcitas.DataSource = citas;

        }

        private void CancelBtt_Click(object sender, EventArgs e)
        {
            Informacion.Enabled = false;
        }

        private void NomClnt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBarb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Hora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Citas
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string nombreCliente { get; set; }
        public string telCliente { get; set; }
        public string emailCliente { get; set; }
        public string nombreBarbero { get; set; }
        public string horafijada { get; set; }
        public DateTime fechafijada { get; set; }
        public DateTime fechaCreada { get; set; }    


    }
}