using System;
using System.Collections.Generic;
using System.Text;

namespace Analiza.File
{
    public class OneLine
    {
        public int code;
        public string hour;
        public int milisekend;
        public int pozytionX;
        public int pozytionY;
        public bool capslock;
        public bool numLockk;
        public bool shift;
        public bool Ctrl;
        public bool PAlt;
        public string focus;
    }

    public class Code
    {
        public int code;
        public bool bigLiter;
        public bool numLock;
        public bool PAlt;
        public int HowMeny = 1;
        public int milisekend;
        public string focus;
    }
}
