using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleSupportProgram
{
    
    public class WaitScreenFunc
    {
        private System.Threading.Timer timer;
        waitScreen wait;
        Thread loadthread;
        

        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcess));
            loadthread.Start();
            timer = new System.Threading.Timer(TimerClose, null, 60000, Timeout.Infinite);

        }

        public void Show(Form parent)
        {
            
            loadthread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadthread.Start(parent);
            timer = new System.Threading.Timer(TimerClose, null, 60000, Timeout.Infinite);


        }
        private void TimerClose(object state)
        {
                Close();
        }
        public void Close()
        {
            if (wait != null)
            {
                    wait.BeginInvoke(new System.Threading.ThreadStart(wait.CloseWaitScreen));
                
                    wait = null;
                    loadthread = null;
                    
            }
        }
        private void LoadingProcess()
        {
            wait = new waitScreen();
            wait.ShowDialog();
        }
        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            wait = new waitScreen(parent1);
            wait.ShowDialog();
            
        }
    }

    
}
