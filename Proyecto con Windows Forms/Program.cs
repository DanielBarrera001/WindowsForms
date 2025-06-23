namespace Proyecto_con_Windows_Forms
{
    internal static class Program
    {
        

        [STAThread]
        static void Main()
        {

            // Variables y los tipos de datos

            string Nombre = "Daniel";

            MessageBox.Show(Nombre); 

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1()); // Ejecuta el form principal
        }
    }
}