namespace AsociacionesPOO
{
    public partial class Form1 : Form
    {
        private Almacen almacen = new Almacen();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Opcion 1
            //Cliente ct = new Cliente("Samir", "Vergara", "10992998", "300300303");
            //Fecha f = new Fecha(12, 04, 2023);

            //Opcion 2
            //Venta v1 = new Venta(1, 500, new Cliente("Samir", "Vergara", "10992998", "300300303"), new Fecha(12, 04, 2023));
            //MessageBox.Show("El nombre del cliente es: " + v1.Cliente.Nombres + " " + v1.Cliente.Apellidos);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(textBox1.Text.Equals("") && textBox2.Text.Equals("") && textBox3.Text.Equals("") && textBox4.Text.Equals("") && textBox5.Text.Equals("")))
            {
                Cliente cte = new Cliente(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                String totalVenta = textBox5.Text;

                //Separamos la fecha actual en dia, mes y año
                int dia = dateTimePicker1.Value.Day;
                int mes = dateTimePicker1.Value.Month;
                int anio = dateTimePicker1.Value.Year;

                //Creamos el objeto de tipo Fecha
                Fecha f = new Fecha(dia, mes, anio);

                //Creamos la venta, utilizando el objeto almacen
                almacen.crearVenta(cte, int.Parse(totalVenta), f);

                limpiarCampos();


            }

        }

        public void limpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Venta[] v = almacen.getVentas();
            int len = almacen.getUltimaVentaAgregada().NumVenta;
            MessageBox.Show("Total Ventas almacenadas: " + len);
            double vt = 0;
            for (int i = 0; i < len; i++)
            {
                listBox1.Items.Add((i + 1) + "-" + v[i].Cliente.Nombres + " " + v[i].Cliente.Apellidos + "   " + v[i].Cliente.NumId + "   " + v[i].Cliente.Cell + "   " + v[i].FechaVenta.darFecha() + " $" + v[i].TotalVenta);
                vt = vt + v[i].TotalVenta;
            }

            label7.Text = "$" + vt.ToString();

        }
    }
}