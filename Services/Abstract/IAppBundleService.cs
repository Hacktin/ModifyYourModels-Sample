﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Services.Abstract
{
    public interface IAppBundleService
    {
        Task<dynamic> CreateAppBundle(JObject appBundle,string LocalBundlesFolder);

        string[] GetLocalBundles(string LocalBundlesFolder);

    }
}
