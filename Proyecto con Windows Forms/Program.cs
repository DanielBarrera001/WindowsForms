namespace Proyecto_con_Windows_Forms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        //Primer comentario de una linea

        /*
         * Comentario de varias lineas
         */

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1()); // Ejecuta el form principal
        }
    }
}