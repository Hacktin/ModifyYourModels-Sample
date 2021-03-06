﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Services.Abstract
{
    public interface IWorkItemService
    {
        Task<dynamic> StartWorkItem(StartWorkItemInput input,string rootPath);

        string CreateToLSendingLog(RestClient client,RestRequest request);

        Task<dynamic> GenerateSignedUrl(string outputFileName);

    } 
}
