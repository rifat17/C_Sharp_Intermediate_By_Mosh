using System;
namespace C_Sharp_Intermediate_By_Mosh.Classes_02.Exercises.SolveByMosh
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _running;

        public void Start()
        {
            if (_running) //If Already Running
                throw new InvalidOperationException("StopWatch is already running!");
            _startTime = DateTime.Now;
            _running = true;
        }
        public void Stop()
        {
            if(!_running) // If Not Running
                throw new InvalidOperationException("StopWatch is not running!");
            _stopTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval()
        {
            return _stopTime - _startTime;
        }
    }
}
