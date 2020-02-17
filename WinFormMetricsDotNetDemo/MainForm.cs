using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Windows.Forms;
using WinFormMetricsDotNetDemo.Counters;
using WinFormMetricsDotNetDemo.Gauges;
using WinFormMetricsDotNetDemo.Histograms;
using WinFormMetricsDotNetDemo.Meters;
using WinFormMetricsDotNetDemo.Timers;

namespace WinFormMetricsDotNetDemo
{
    public partial class MainForm : Form
    {
        private readonly Random unityRandom = new Random();
        private readonly ConcurrentDictionary<string, MetricContextBase> MetricContextDictionary = new ConcurrentDictionary<string, MetricContextBase>();
        private const string GaugeKey = "Gauge";
        private const string CounterKey = "Counter";
        private const string HistogramKey = "Histogram";
        private const string MeterKey = "Meter";
        private const string TimerKey = "Timer";

        public MainForm()
        {
            this.InitializeComponent();

            this.MetricContextDictionary.TryAdd(GaugeKey, new GaugeContext());
            this.MetricContextDictionary.TryAdd(CounterKey, new CounterContext());
            this.MetricContextDictionary.TryAdd(HistogramKey, new HistogramContext());
            this.MetricContextDictionary.TryAdd(MeterKey, new MeterContext());
            this.MetricContextDictionary.TryAdd(TimerKey, new TimerContext());
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
            if (!this.MetricContextDictionary.TryGetValue(HistogramKey, out var context) ||
                !(context is IHistogramContext histogramContext))
            {
                return;
            }

            var amount = Convert.ToInt64(this.unityRandom.NextDouble() * 10000);

            Debug.Print($"新的订单：总计 {amount} 元");
            histogramContext.AnalyseOrderAmount(amount);
        }

        private void MeterButton_Click(object sender, EventArgs e)
        {
            if (!this.MetricContextDictionary.TryGetValue(MeterKey, out var context) ||
                !(context is IMeterContext meterContext))
            {
                return;
            }

            var amount = Convert.ToInt64(this.unityRandom.NextDouble() * 15000);

            Debug.Print($"新的订单：总计 {amount} 元");
            _ = meterContext.CheckOrderAmount(amount);
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            if (!this.MetricContextDictionary.TryGetValue(TimerKey, out var context) ||
                !(context is ITimerContext timerContext))
            {
                return;
            }

            var elapsedTime = Convert.ToInt64(this.unityRandom.NextDouble() * 10000);

            Debug.Print($"任务耗时：{elapsedTime}");
            timerContext.RecordElaspedTime(elapsedTime);
        }
    }
}
