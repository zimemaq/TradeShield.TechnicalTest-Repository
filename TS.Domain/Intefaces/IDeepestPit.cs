﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Domain
{
    public interface IDeepestPit
    {
        int GetPitDepth(int[] points);
    }
}
