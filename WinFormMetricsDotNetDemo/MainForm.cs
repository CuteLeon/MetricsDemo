using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Windows.Forms;
using WinFormMetricsDotNetDemo.Counters;
using WinFormMetricsDotNetDemo.Gauges;
using WinFormMetricsDotNetDemo.Histograms;

namespace WinFormMetricsDotNetDemo
{
    public partial class MainForm : Form
    {
        private readonly Random unityRandom = new Random();
        private readonly ConcurrentDictionary<string, MetricContextBase> MetricContextDictionary = new ConcurrentDictionary<string, MetricContextBase>();
        private const string GaugeKey = "Gauge";
        private const string CounterKey = "Counter";
        private const string HistogramKey = "Histogram";

        public MainForm()
        {
            this.InitializeComponent();

            MetricContextDictionary.TryAdd(GaugeKey, new GaugeContext());
            MetricContextDictionary.TryAdd(CounterKey, new CounterContext());
            MetricContextDictionary.TryAdd(HistogramKey, new HistogramContext());
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

        private void CounterButton_Click(object sender, EventArgs e)
        {
            if (!this.MetricContextDictionary.TryGetValue(CounterKey, out var context) ||
                !(context is ICounterContext counterContext))
            {
                return;
            }

            Debug.Print($"新增一笔订单 ...");
            counterContext.RecordNewOrder();
        }

        private void HistogramButton_Click(object sender, EventArgs e)
        {
            if (!this.MetricContextDictionary.TryGetValue(GaugeKey, out var context) ||
                !(context is IHistogramContext histogramContext))
            {
                return;
            }

            var amount = Convert.ToInt64(this.unityRandom.NextDouble() * 10000);

            Debug.Print($"新的订单：总计 {amount} 元");
            histogramContext.AnalyseOrderAmount(amount);
        }
    }
}
