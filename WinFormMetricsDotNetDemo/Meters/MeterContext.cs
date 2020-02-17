using Metrics;

namespace WinFormMetricsDotNetDemo.Meters
{
    public class MeterContext : MetricContextBase, IMeterContext
    {
        /// <summary>
        /// 每分钟超额订单的比率
        /// </summary>
        private readonly Meter ExcessMeter;

        public MeterContext()
        {
            this.ExcessMeter = Metric.Meter<MeterContext>(nameof(this.ExcessMeter), UnityAssist.ExcessUnit, TimeUnit.Minutes);
        }


        /// <inheritdoc/>
        public bool CheckOrderAmount(double amount)
        {
            var excess = amount > 10000d;

            if (excess)
            {
                // 金额超过 10000，记录一次
                this.ExcessMeter.Mark();
            }

            return excess;
        }
    }
}
