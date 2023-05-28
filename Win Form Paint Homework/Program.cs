namespace Win_Form_Paint_Homework {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}