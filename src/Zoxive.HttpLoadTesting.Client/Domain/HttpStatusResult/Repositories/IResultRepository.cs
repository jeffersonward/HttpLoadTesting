﻿using System.Threading.Tasks;
using Zoxive.HttpLoadTesting.Client.Framework.Model;
using Zoxive.HttpLoadTesting.Client.Pages;
using Zoxive.HttpLoadTesting.Framework.Model;

namespace Zoxive.HttpLoadTesting.Client.Domain.HttpStatusResult.Repositories
{
    public interface IResultRepository
    {
        Task<HttpStatusResultStatistics> GetStatistics(Filters filters);

        Task<HttpStatusResultDistincts> GetDistincts(Filters filters);
    }
}