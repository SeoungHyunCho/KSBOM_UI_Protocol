using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Common.UI;
using System.Runtime.InteropServices;

namespace SKAI_KSBOM_UI_protocol
{
    public static class Program
    {
        #region Define
        #endregion

        #region Field
        //private static bool m_ProcessDuplicationCheck = true;
        private static bool m_ProcessDuplicationCheck = false;
        #endregion

        #region Constructor
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (IsExistProcess(Process.GetCurrentProcess().ProcessName) && m_ProcessDuplicationCheck == true)
                {
                    var mb = new MessageBoxOk();
                    mb.ShowDialog("Program", "�̹� ���� �� �Դϴ�.", 5);
                }
                else
                {
                    ApplicationRun();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("System", e.Message);
            }
        }
        #endregion

        #region Property
        #endregion

        #region Event Handler
        static void exceptionDump(object sender, System.Threading.ThreadExceptionEventArgs args)
        {
            //Exception e = args.Exception;
            //Console.WriteLine("errMsg: " + e.Message);
            //Console.WriteLine("errPos: " + e.TargetSite);

            //���� ���� ��� ����(MinidumpHelp.cs ������ ����)
            //MinidumpHelp.Minidump.install_self_mini_dump(Application.StartupPath);

            MinidumpHelp.Minidump.install_self_mini_dump();
        }

        //�̺�Ʈ Ŭ����(ó������ ���� ����)
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //Exception e = args.Exception;
            //Console.WriteLine("errMsg: " + e.Message);
            //Console.WriteLine("errPos: " + e.TargetSite);

            //���� ���� ��� ����(MinidumpHelp.cs ������ ����)
            //MinidumpHelp.Minidump.install_self_mini_dump(Application.StartupPath);

            MinidumpHelp.Minidump.install_self_mini_dump();
        }
        #endregion

        #region Method
        private static bool IsExistProcess(string processName)
        {
            Process[] process = Process.GetProcesses();
            int cnt = 0;
            //���μ��������� Ȯ���ؼ� ������ ���μ��� ������ 2���̻����� Ȯ���մϴ�.  
            //��������ϴ� ���μ����� ���ԵǱ⶧���� 1����Ŀ���մϴ�. 
            foreach (var p in process)
            {
                if (p.ProcessName == processName)
                {
                    cnt++;
                }
                if (cnt > 1)
                {
                    return true;
                }
            }
            return false;
        }

        private static void ApplicationRun()
        {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(exceptionDump);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);


            //ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dpi.SetProcessDpiAwareness((int)Dpi.DpiAwareness.None);
            Application.Run(new FormMain());
        }
        #endregion

        #region Members
        public static class Dpi
        {
            [DllImport("Shcore.dll")]
            public static extern int SetProcessDpiAwareness(int processDpiAwareness);
            /// <summary>
            /// According to https://learn.microsoft.com/en-us/windows/win32/api/shellscalingapi/ne-shellscalingapi-process_dpi_awareness
            /// </summary>
            public enum DpiAwareness
            {
                None = 0,
                SystemAware = 1,
                PerMonitorAware = 2
            }
        }
        #endregion
    }
}