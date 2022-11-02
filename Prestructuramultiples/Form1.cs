namespace Prestructuramultiples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            // Declaracion de variable

            byte numero;
            string dia;

            //entrada de dato

            numero = Convert.ToByte(txtnumero.Text);

            //Proceso

            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;

                    case 2:
                    dia = "Martes";
                    break;

                case 3:
                    dia = "Miercoles";
                    break;

                case 4:
                    dia = "Jueves";
                    break ;

                    case 5:
                    dia = "Viernes";
                    break;  

                case 6:
                    dia = "Sabado";
                    break;

                case 7:
                    dia = "Domingo";
                    break;

                    default:
                    dia = "Error Ingrese otro numero";
                    break;

            }
           
            // Salida de informacion

            txtdia.Text = dia;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtdia.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}