using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskManagerTest
{
    interface IAsyncTask:IDisposable
    {
        public string ProgressInfo { get;}
        public byte Progress { get;}
        public string ReferenceKey { get;}
        public Task ExecuteAsyncThread();
        public CancellationTokenSource TokenSource { get; set; }
        public event TaskEventHandler ResponseRequired;
        public event EventHandler Changed;
        public UserEntry(MessageButton entry);
    }
}
