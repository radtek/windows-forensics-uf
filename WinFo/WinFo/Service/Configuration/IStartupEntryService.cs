﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFo.Model.Configuration;

namespace WinFo.Service.Configuration
{
    public interface IStartupEntryService
    {
        List<StartupEntry> GetStartupEntries();
    }
}
