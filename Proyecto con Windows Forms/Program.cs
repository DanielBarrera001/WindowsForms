namespace Proyecto_con_Windows_Forms
{
    internal static class Program
    {
        

        [STAThread]
        static void Main()
        {

            // Variables de tipo numerio

            string Nombre = "Daniel";

            int num1 = 22; // Entero
            uint num2 = 22; // Variable enteger siempre positivo
            float num3 = 22.0f; // Numero decimal
            double num4 = 22.00; // Numero decimal mas grande que float
            decimal num5 = 22.00m; // Numero decimal mucho mayor
            byte num6 = 255; // Llega hasta el 255

            bool acceso = true; // Solo acepta true o false


            MessageBox.Show(Nombre);
            MessageBox.Show(num1.ToString());
            MessageBox.Show(acceso.ToString());


            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1()); // Ejecuta el form principal
        }
    }
}