﻿using Metrics;

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
        /// <inheritdoc/>
        public void RecordOrderAmount(double amount)
        {
            const string GaugeName = nameof(this.RecordOrderAmount);
            Metric.Gauge<GaugeContext>(GaugeName, () => amount, Unit.Custom("元"));
        }

        /// <inheritdoc/>
        public void RecordOrderCount(int count)
        {
            const string GaugeName = nameof(this.RecordOrderCount);
            Metric.Gauge<GaugeContext>(GaugeName, () => count, Unit.Custom("个"));
        }
    }
}