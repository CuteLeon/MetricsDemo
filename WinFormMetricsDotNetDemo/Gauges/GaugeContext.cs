using Metrics;

namespace WinFormMetricsDotNetDemo.Gauges
{
    /// <summary>
    /// 度量交互类
    /// </summary>
    /// <remarks>
    /// 1、泛型类型仅作为 name 的前缀（内部代码实现：typeof(T).Name + "." + name）
    /// 2、valueProvide 作为所记录数据的提供委托
    /// 3、Unit参数为数据的物理单位
    /// </remarks>
    public class GaugeContext : MetricContextBase, IGaugeContext
    {
        public double Amount { get; set; }
        public double Count { get; set; }

        public GaugeContext()
        {
            Metric.Gauge<GaugeContext>(nameof(this.RecordOrderAmount), () => this.Amount, UnityAssist.AmountUnit);
            Metric.Gauge<GaugeContext>(nameof(this.RecordOrderCount), () => this.Count, UnityAssist.CountUnit);
        }

        /// <inheritdoc/>
        public void RecordOrderAmount(double amount)
        {
            this.Amount = amount;
        }

        /// <inheritdoc/>
        public void RecordOrderCount(int count)
        {
            this.Count = count;
        }
    }
}
