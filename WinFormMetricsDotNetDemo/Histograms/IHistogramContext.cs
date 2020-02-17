namespace WinFormMetricsDotNetDemo.Histograms
{
    public interface IHistogramContext
    {
        /// <summary>
        /// 分析订单金额
        /// </summary>
        /// <param name="amount">金额</param>
        void AnalyseOrderAmount(long amount);
    }
}
