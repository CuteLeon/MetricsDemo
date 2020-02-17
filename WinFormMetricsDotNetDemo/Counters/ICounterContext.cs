namespace WinFormMetricsDotNetDemo.Counters
{
    public interface ICounterContext
    {
        /// <summary>
        /// 记录新订单
        /// </summary>
        void RecordNewOrder();
    }
}
