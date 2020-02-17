using System;
using System.Threading;
using Metrics;

namespace WinFormMetricsDotNetDemo.Counters
{
    public class CounterContext : MetricContextBase, ICounterContext
    {
        private readonly Counter OrderCounter;
        private readonly Counter ProcessingCounter;

        public CounterContext()
        {
            this.OrderCounter = Metric.Counter<CounterContext>(nameof(this.OrderCounter), Unit.Items);
            this.ProcessingCounter = Metric.Counter<CounterContext>(nameof(this.ProcessingCounter), Unit.Items);
        }

        /// <inheritdoc/>
        public void RecordNewOrder()
        {
            // 订单总数自增
            this.OrderCounter.Increment();

            // 模拟一次异步处理订单，.Net 4.0 对 Task 和 TPL 不友好
            ThreadPool.QueueUserWorkItem(new WaitCallback((order) =>
            {
                // 正在处理的订单数量自增
                this.ProcessingCounter.Increment();

                Thread.Sleep(new Random().Next(1, 6));

                // 正在处理的订单数量自减
                this.ProcessingCounter.Decrement();
            }));
        }
    }
}
