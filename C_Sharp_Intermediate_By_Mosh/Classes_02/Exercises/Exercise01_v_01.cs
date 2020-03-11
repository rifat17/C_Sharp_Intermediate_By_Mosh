using System;
namespace C_Sharp_Intermediate_By_Mosh.Classes_02.Exercises
{
    public class Exercise01_v_01
    {
        private bool stopWatchOn;
        private bool stopWatchOff;
        private DateTime _startTime;
        private DateTime _stopTime;

        public Exercise01_v_01()
        {
            stopWatchOn = false;
            stopWatchOff = true;
            _startTime = new DateTime();
            _stopTime = new DateTime();
        }

        public bool isStopWatchOFF()
        {
            return stopWatchOff;
        }

        public bool isStopWatchON()
        {
            return stopWatchOn;
        }

        public void Start()
        {
            if (stopWatchOn)
                throw new InvalidOperationException("stopWatch already started..!");
            stopWatchOn = true;
            stopWatchOff = false;
            _startTime = DateTime.Now;

        }

        public void Stop()
        {
            if (stopWatchOff)
                throw new InvalidOperationException("Start the watch before stop it!");
            stopWatchOn = false;
            stopWatchOff = true;
            _stopTime = DateTime.Now;
        }

        public TimeSpan Duaration()
        {
            if (stopWatchOn) throw new InvalidOperationException("STOP THE WATCH FIRST!");
            return _stopTime - _startTime;
        }
    }
}
