using MauiApp1.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Extensions
{
    public static class RecurringTaskExtensions
    {
        public static void StartTasks()
        {
            RecurringTask.Start();
        }
    }
}
