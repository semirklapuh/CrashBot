using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrashBot.Model;
using CrashBot.Model.Requests;
using CrashBot.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrashBot.WebApi.Controllers
{
    public class ErrorLogController : BaseCRUDController<Model.ErrorLog, Model.Requests.ErrorLogSearchRequest, Model.Requests.ErrorLogUpsertRequest, Model.Requests.ErrorLogUpsertRequest>
    {
        public ErrorLogController(ICRUDService<ErrorLog, ErrorLogSearchRequest, ErrorLogUpsertRequest, ErrorLogUpsertRequest> service) : base(service)
        {
        }
    }
}