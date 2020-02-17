namespace WinFormMetricsDotNetDemo.Timers
{
    public interface ITimerContext
    {
        /// <summary>
        /// 记录耗时
        /// </summary>
        /// <param name="elapsedTime"></param>
        /// <returns></returns>
        void RecordElaspedTime(long elapsedTime);
    }
}
