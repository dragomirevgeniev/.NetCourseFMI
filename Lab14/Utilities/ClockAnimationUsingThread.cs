using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Utilities
{
    public class ClockAnimationUsingThread : StillClock
    {
        private bool suspended;
        Thread myThread;

        public ClockAnimationUsingThread()
        {
            myThread = new Thread(TicTac);
            myThread.Start();
            suspended = false;
        }

        public void TicTac()
        {
            while (true)
            {
                if (this.IsHandleCreated)
                {
                    lock (this)
                    {
                        while (suspended)
                        {
                            Monitor.Wait(this);
                        }
                    }

                    this.setCurrentTime();
                    this.Invoke(new Action(Refresh));
                    Thread.Sleep(1000);
                }
            } 
        }

        public void Stop()
        {
            suspended = true;
        }

        public void Resume()
        {
            suspended = false;
            lock (this)
            {
                if (!suspended)
                {
                    Monitor.Pulse(this);
                }
            }
        }
    }
}
