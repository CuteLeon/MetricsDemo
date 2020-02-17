using Metrics;

namespace WinFormMetricsDotNetDemo.Histograms
{
    /// <summary>
    /// 直方图交互类
    /// </summary>
    public class HistogramContext : MetricContextBase, IHistogramContext
    {
        /// <summary>
        /// 向前衰减直方图
        /// </summary>
        private readonly Histogram AmountFavourRecentHistogram;

        /// <summary>
        /// 长方形直方图
        /// </summary>
        private readonly Histogram AmountLongTermHistogram;

        /// <summary>
        /// 滑动窗口直方图
        /// </summary>
        private readonly Histogram AmountSlidingWindowHistogram;

        public HistogramContext()
        {
            this.AmountFavourRecentHistogram = Metric.Histogram<HistogramContext>(nameof(this.AmountFavourRecentHistogram), UnityAssist.AmountUnit, SamplingType.FavourRecent);
            this.AmountLongTermHistogram = Metric.Histogram<HistogramContext>(nameof(this.AmountLongTermHistogram), UnityAssist.AmountUnit, SamplingType.LongTerm);
            this.AmountSlidingWindowHistogram = Metric.Histogram<HistogramContext>(nameof(this.AmountSlidingWindowHistogram), UnityAssist.AmountUnit, SamplingType.SlidingWindow);
        }

        /// <inheritdoc/>
        public void AnalyseOrderAmount(long amount)
        {
            this.AmountFavourRecentHistogram.Update(amount);
            this.AmountLongTermHistogram.Update(amount);
            this.AmountSlidingWindowHistogram.Update(amount);
        }
    }
}
