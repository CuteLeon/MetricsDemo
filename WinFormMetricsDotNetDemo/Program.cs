using System;
using System.Windows.Forms;
using Metrics;

namespace WinFormMetricsDotNetDemo
{
    internal static class Program
    {
        private const string HttpUriPrefix = "http://localhost:9090/";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ConfigMetrics();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void ConfigMetrics()
        {
            Metric.Config
                .WithHttpEndpoint(HttpUriPrefix);
        }
    }
}
