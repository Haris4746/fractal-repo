using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Drawing;

namespace FracMaster
{
    public class RenderResult : IAsyncResult //Finds and generates th state of the bitmap render
    {
        public delegate void RenderComplete(Bitmap bmp, int ErrorCode);
        public delegate void RenderStatus(float pcnt);
        
        private bool isCompleted = false;
        private object asyncstate = new object();
        private WaitHandle waitHandle = new AutoResetEvent(false);
          
        public object AsyncState
        {
            get
            {
                return asyncstate;
            }
            set
            {
                asyncstate = value;
            }
        }

        public WaitHandle AsyncWaitHandle
        {
            get
            {
                return waitHandle;
            }
        }

        public bool CompletedSynchronously
        {
            get
            {
                return false;
            }
        }

        public bool IsCompleted
        {
            get
            {
                return isCompleted;
            }
            set
            {
                isCompleted = value;
            }
        }
    }
}
