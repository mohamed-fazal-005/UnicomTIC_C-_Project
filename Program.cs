using UTIC_WindowsForm_By_Fazal.Data;
using UTIC_WindowsForm_By_Fazal.Views;

namespace UTIC_WindowsForm_By_Fazal
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Migration.InitializeDatabase();
            Application.Run(new LoginForm());
        }
    }
}