using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Tasks
{
    public static class RecurringTask
    {
        private static CancellationTokenSource cancellationTokenSource;
        private static Task despoolProcessDispatchTask;

        private static object syncLock;

        private static Random R;

        static String HttpClientName = "ExampleClient";
        static String ServiceActionRoot = "Portal3000";
        static String ServiceAction = "P3kConfig/GetEchoTest";
        static String ServiceIp = "10.0.138.24";
        static int ServicePort = 10929;

        static RecurringTask()
        {
            syncLock = new object();
            cancellationTokenSource = new CancellationTokenSource();
            R = new Random();
        }

        public static void Start()
        {
            RegisterHttpClient();

            CancellationToken token = cancellationTokenSource.Token;
            despoolProcessDispatchTask = new Task(() => LoopedCode(token), token, TaskCreationOptions.LongRunning);
            despoolProcessDispatchTask.Start();
        }

        public static void RegisterHttpClient()
        {
            var rootUri = GetRootUri();
            var webApiTimeout = new TimeSpan(0, 15, 0);
        }

        private static Uri GetRootUri()
        {
            return new Uri($"http://{ServiceIp}:{ServicePort}/{ServiceActionRoot}/");
        }

        public static void Stop()
        {
            cancellationTokenSource.Cancel();
        }

        private static async void LoopedCode(CancellationToken cancellationToken)
        {
            try
            {

                while (!cancellationToken.IsCancellationRequested)
                {
                    using (ManualResetEvent manualResetEvent = new ManualResetEvent(false))
                    {
                        var delayMs = 3000;
                        manualResetEvent.WaitOne(delayMs);
                    }

                    var echoThis = R.Next(100);
                    Application.Current?.Dispatcher.Dispatch(() => MessagingCenter.Send<object, int>(App.Current, "NextEchoValue", echoThis));
                }
            }
            catch (Exception e)
            {
                //DailyLog.LogEvent(e.Message.ToString());
            }
            finally
            {
                Stop();
            }
        }
    }
}
