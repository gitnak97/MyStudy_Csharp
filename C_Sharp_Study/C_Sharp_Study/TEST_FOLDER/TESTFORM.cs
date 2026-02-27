using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp_Study.TEST_FOLDER
{
    public partial class TESTFORM : Form
    {
        [DllImport("user32.dll")]
        private static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);
        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr hWnd); // 실제 눈에 보이는 창만 필터링

        private delegate bool EnumDelegate(IntPtr hWnd, IntPtr lParam);

        public TESTFORM()
        {
            InitializeComponent();
            // 버튼 클릭 이벤트 등에 연결해서 사용하세요.
            Task.Run(() => RunAllProcessMonitor());
        }

        public async void RunAllProcessMonitor()
        {
            this.Invoke(new Action(() => {
                textBox1.Clear();
                textBox1.Font = new System.Drawing.Font("Consolas", 9);
                textBox1.Text = "전체 프로세스 분석 중... (1초 측정)\r\n";
            }));

            var windowList = new List<(string Title, int Pid)>();
            HashSet<int> addedPids = new HashSet<int>();

            // 1. 현재 떠 있는 모든 가시적인 창 찾기
            EnumDesktopWindows(IntPtr.Zero, (hWnd, lParam) =>
            {
                if (IsWindowVisible(hWnd))
                {
                    StringBuilder sb = new StringBuilder(256);
                    GetWindowText(hWnd, sb, sb.Capacity);
                    string title = sb.ToString();

                    if (!string.IsNullOrEmpty(title))
                    {
                        uint pid;
                        GetWindowThreadProcessId(hWnd, out pid);

                        // 중복 PID 방지 (한 프로그램이 여러 창을 가질 수 있음)
                        if (!addedPids.Contains((int)pid))
                        {
                            windowList.Add((title, (int)pid));
                            addedPids.Add((int)pid);
                        }
                    }
                }
                return true;
            }, IntPtr.Zero);

            // 2. CPU 측정 준비
            var startStats = new List<(Process Proc, TimeSpan StartTime)>();
            foreach (var item in windowList)
            {
                try
                {
                    var p = Process.GetProcessById(item.Pid);
                    startStats.Add((p, p.TotalProcessorTime));
                }
                catch { }
            }

            DateTime startTime = DateTime.Now;
            await Task.Delay(1000); // 1초간 변화량 관찰
            DateTime endTime = DateTime.Now;

            // 3. 결과 출력
            StringBuilder result = new StringBuilder();
            result.AppendLine($"전체 프로세스 감시 시각: {endTime:HH:mm:ss}");
            result.AppendLine("----------------------------------------------------------------------");
            result.AppendLine(string.Format("{0,-30} | {1,-7} | {2,-8} | {3,-10}", "Window Title", "PID", "CPU", "Memory"));
            result.AppendLine("----------------------------------------------------------------------");

            double coreCount = Environment.ProcessorCount;

            foreach (var stat in startStats)
            {
                try
                {
                    TimeSpan endTotalTime = stat.Proc.TotalProcessorTime;
                    double cpuUsage = (endTotalTime.TotalMilliseconds - stat.StartTime.TotalMilliseconds) /
                                      (endTime.Subtract(startTime).TotalMilliseconds) * 100 / coreCount;

                    long memUsage = stat.Proc.WorkingSet64 / 1024 / 1024;
                    string title = stat.Proc.MainWindowTitle;
                    if (string.IsNullOrEmpty(title)) title = stat.Proc.ProcessName;
                    if (title.Length > 30) title = title.Substring(0, 27) + "...";

                    result.AppendLine(string.Format("{0,-30} | {1,7} | {2,7:F1}% | {3,8} MB",
                        title, stat.Proc.Id, cpuUsage, memUsage));
                }
                catch { }
            }

            this.Invoke(new Action(() => {
                textBox1.Text = result.ToString();
            }));
        }
    }
}