using System;
using System.Collections.Generic;
using System.Text;

namespace HT.IRS.Hardware.Protocol.APIs
{
    public static class Tasks
    {
        public const ushort Plan = 3001;
        public const ushort Run = 3002;
        public const ushort Pause = 3003;
        public const ushort Resume = 3004;
        public const ushort Cancel = 3005;
        public const ushort Complete = 3006;
    }
}
