using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10
{
    public static class AccessMode
    {
        public static bool IsConsultantMode { get; private set; }

        public static void SetConsultantMode(bool isConsultantMode)
        {
            IsConsultantMode = isConsultantMode;
        }
    }
}
