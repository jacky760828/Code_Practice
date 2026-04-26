using n1.sp1;
using n1.sp2;


namespace name_space_practice
{
    internal static class Program
    {
        static Na_space1 N1;
        static Na_space2 N2;
       /// <summary>
       ///  The main entry point for the application.
       /// </summary>
       [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}