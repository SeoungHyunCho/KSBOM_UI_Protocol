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
                    mb.ShowDialog("Program", "이미 실행 중 입니다.", 5);
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

            //덤프 파일 경로 설정(MinidumpHelp.cs 에서도 수정)
            //MinidumpHelp.Minidump.install_self_mini_dump(Application.StartupPath);

            MinidumpHelp.Minidump.install_self_mini_dump();
        }

        //이벤트 클래스(처리되지 않은 예외)
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            //Exception e = args.Exception;
            //Console.WriteLine("errMsg: " + e.Message);
            //Console.WriteLine("errPos: " + e.TargetSite);

            //덤프 파일 경로 설정(MinidumpHelp.cs 에서도 수정)
            //MinidumpHelp.Minidump.install_self_mini_dump(Application.StartupPath);

            MinidumpHelp.Minidump.install_self_mini_dump();
        }
        #endregion

        #region Method
        private static bool IsExistProcess(string processName)
        {
            Process[] process = Process.GetProcesses();
            int cnt = 0;
            //프로세스명으로 확인해서 동일한 프로세스 개수가 2개이상인지 확인합니다.  
            //현재실행하는 프로세스도 포함되기때문에 1보다커야합니다. 
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