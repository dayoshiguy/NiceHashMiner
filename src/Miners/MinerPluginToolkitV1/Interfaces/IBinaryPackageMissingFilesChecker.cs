﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerPluginToolkitV1.Interfaces
{
    public interface IBinaryPackageMissingFilesChecker
    {
        IEnumerable<string> CheckBinaryPackageMissingFiles();
    }
}