namespace Proyecto_con_Windows_Forms
{
    public partial class Form1 : Form
    {

        private bool confirmarDatos = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                string txtBoxName = txt_Nombre.Text;
                byte txtBoxEdad = Convert.ToByte(txt_Edad.Text);

                lbl_texto.Text = "Tu nombre es " + txtBoxName + " y tu edad es " + txtBoxEdad;
                lblConfirm.Text = "Confirmas esta informacion?";

                switch (txtBoxName)
                {
                    case "admin":
                        MessageBox.Show("Credenciales de administrador ingresadas");
                        switch (txtBoxEdad)
                        {
                            case 255:
                              MessageBox.Show("Contraseña admin ingresada");
                                break;

                            default:
                              MessageBox.Show("Falta la contraseña de admin");
                                Application.Restart();
                                break;
                        }
                        break;

                    case "guest":
                        MessageBox.Show("Credenciales de invitado ingresadas");
                        break;

                    default:
                        MessageBox.Show("Credencial de usuario estandar ingresada");
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ingresa una edad valida"); ;
            }

            confirmarDatos = true;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {

            if (confirmarDatos == true)
            {
                MessageBox.Show("Estas registrado");
                Application.Exit(); 
            }
            else
            {
                MessageBox.Show("Ingresa los datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           txt_Edad.Clear();
            txt_Nombre.Clear();
            lbl_texto.Text = " ";
            lblConfirm.Text = " ";
        }
    }
}
