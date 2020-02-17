namespace WinFormMetricsDotNetDemo.Meters
{
    public interface IMeterContext
    {
        /// <summary>
        /// 检查订单金额
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        bool CheckOrderAmount(double amount);
    }
}
