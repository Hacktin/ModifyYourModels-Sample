﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Services.Adapters.Abstract
{
    public interface IActivityServiceAdapter
    {
        Task<dynamic> CreateActivity(JObject activitySpecs);

        Task<List<string>> GetDefinedActivities();
    }
}
