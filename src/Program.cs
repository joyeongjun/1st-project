namespace DJing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (args.Contains("--mixing", StringComparer.OrdinalIgnoreCase))
            {
                Application.Run(new DJform());
                return;
            }

            if (string.IsNullOrWhiteSpace(DatabaseSettings.ConnectionString))
            {
                MessageBox.Show(
                    $"계정 기능을 사용하려면 {DatabaseSettings.VariableName} 환경 변수를 설정하세요.\n" +
                    "DJ 믹싱 화면은 --mixing 옵션으로 바로 열 수 있습니다.",
                    "DJing");
                return;
            }

            Application.Run(new Login());
        }
    }
}
