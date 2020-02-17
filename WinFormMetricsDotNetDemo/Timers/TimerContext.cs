using Metrics;

namespace WinFormMetricsDotNetDemo.Timers
{
    public class TimerContext : MetricContextBase, ITimerContext
    {
        private readonly Timer TaskTimer;

        public TimerContext()
        {
            this.TaskTimer = Metric.Timer<TimerContext>(
                nameof(TimerContext),
                UnityAssist.ExcessUnit,
                SamplingType.FavourRecent,
                TimeUnit.Minutes,
                TimeUnit.Milliseconds);
        }

        /// <inheritdoc/>
        public void RecordElaspedTime(long elapsedTime)
        {
            this.TaskTimer.Record(elapsedTime, TimeUnit.Seconds);
        }
    }
}
