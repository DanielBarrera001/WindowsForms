namespace Proyecto_con_Windows_Forms
{
    public partial class Form1 : Form
    {
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
            string textoDelTextBox = txt_Nombre.Text;
            lbl_texto.Text = textoDelTextBox;
        }
    }
}
