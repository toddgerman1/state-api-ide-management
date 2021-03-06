using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;
using LCU.State.API.NapkinIDE.NapkinIDE.IdeManagement.State;

namespace LCU.State.API.NapkinIDE.NapkinIDE.IdeManagement.Host
{
    public class Negotiate
    {
        [FunctionName("negotiate")]
        public static SignalRConnectionInfo Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", "options")] HttpRequest req,
            [SignalRConnectionInfo(HubName = IDEManagementState.HUB_NAME, UserId = "{headers.x-ms-client-principal-id}")] SignalRConnectionInfo connectionInfo)
        {
            return connectionInfo;
        }
    }
}
