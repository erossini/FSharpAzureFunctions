namespace FunctionApp1

open System
open Microsoft.Azure.WebJobs
open Microsoft.Azure.WebJobs.Host
open System;
open System.IO;
open System.Threading.Tasks;
open Microsoft.AspNetCore.Mvc;
open Microsoft.Azure.WebJobs;
open Microsoft.Azure.WebJobs.Extensions.Http;
open Microsoft.AspNetCore.Http;
open Microsoft.Extensions.Logging;

module GetOrganizations =
    [<FunctionName("GetOrganizations")>]
    let Run ([<HttpTrigger(AuthorizationLevel.Function, [|"get"|])>] req: HttpRequest) (log: ILogger) = 
        async {
            return "some result"
        }
        |> Async.StartAsTask