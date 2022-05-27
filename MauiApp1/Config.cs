using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public static class Config
    {
        public static bool ListenTogetherIsVisible => true;

        public static bool Desktop
        {
            get
            {
#if WINDOWS || MACCATALYST
            return true;
#else
                return false;
#endif
            }
        }
    }

    public class Settings
    {
        public int KeyOne { get; set; }
        public bool KeyTwo { get; set; }
        public NestedSettings KeyThree { get; set; } = null!;
    }

    public class NestedSettings
    {
        public string Message { get; set; } = null!;
    }
}
