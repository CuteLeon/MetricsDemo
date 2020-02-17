using System;
using System.Diagnostics;
using System.Windows.Forms;
using WinFormMetricsDotNetDemo.Gauges;

namespace WinFormMetricsDotNetDemo
{
    public partial class MainForm : Form
    {
        private readonly Random unityRandom = new Random();
        private readonly GaugeContext gaugeContext = new GaugeContext();

        public MainForm()
        {
            this.InitializeComponent();
        }

        private void GaugeButton_Click(object sender, EventArgs e)
        {
            {
                var amount = this.unityRandom.NextDouble() * 10000;
                var count = this.unityRandom.Next(1, 101);

                Debug.Print($"新的订单：{count} 个商品，总计 {amount} 元，单价 {(amount / count).ToString("#.00")} 元");
                this.gaugeContext.RecordOrderAmount(amount);
                this.gaugeContext.RecordOrderCount(count);
            }
        }
    }
}
