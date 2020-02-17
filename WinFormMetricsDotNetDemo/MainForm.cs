using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Windows.Forms;
using WinFormMetricsDotNetDemo.Gauges;

namespace WinFormMetricsDotNetDemo
{
    public partial class MainForm : Form
    {
        private readonly Random unityRandom = new Random();
        private readonly ConcurrentDictionary<string, MetricContextBase> MetricContextDictionary = new ConcurrentDictionary<string, MetricContextBase>();
        private const string GaugeKey = "Gauge";

        public MainForm()
        {
            this.InitializeComponent();

            MetricContextDictionary.TryAdd(GaugeKey, new GaugeContext());
        }

        private void GaugeButton_Click(object sender, EventArgs e)
        {
            if (!this.MetricContextDictionary.TryGetValue(GaugeKey, out var context) ||
                !(context is IGaugeContext gaugeContext))
            {
                return;
            }

            var amount = this.unityRandom.NextDouble() * 10000;
            var count = this.unityRandom.Next(1, 101);

            Debug.Print($"新的订单：{count} 个商品，总计 {amount} 元，单价 {(amount / count).ToString("#.00")} 元");
            gaugeContext.RecordOrderAmount(amount);
            gaugeContext.RecordOrderCount(count);
        }
    }
}
