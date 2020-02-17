namespace WinFormMetricsDotNetDemo.Gauges
{
    public interface IGaugeContext
    {
        /// <summary>
        /// 记录订单金额
        /// </summary>
        /// <param name="amount">金额</param>
        void RecordOrderAmount(double amount);

        /// <summary>
        /// 记录订单数量
        /// </summary>
        /// <param name="count">数量</param>
        void RecordOrderCount(int count);
    }
}
