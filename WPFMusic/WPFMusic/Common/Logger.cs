﻿using log4net;
using LogHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public static class Logger
{
    public static ILog Log
    {
        get => LogHelper.LogHelper.Log(LogHelperType.Default);
    }
}