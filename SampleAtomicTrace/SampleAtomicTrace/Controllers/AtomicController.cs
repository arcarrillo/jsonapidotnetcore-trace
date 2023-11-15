using JsonApiDotNetCore.AtomicOperations;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Controllers.Annotations;
using JsonApiDotNetCore.Middleware;
using JsonApiDotNetCore.Resources;
using Microsoft.AspNetCore.Mvc;

namespace SampleAtomicTrace.Controllers
{
    [Route("/api/atomic"), DisableRoutingConvention]
    public class AtomicController : BaseJsonApiOperationsController
    {

        public AtomicController(IJsonApiOptions options, IResourceGraph resourceGraph, ILoggerFactory loggerFactory, IOperationsProcessor processor, IJsonApiRequest request, ITargetedFields targetedFields)
        : base(options, resourceGraph, loggerFactory, processor, request, targetedFields)
        {
        }

        [HttpPost]
        public async Task<IActionResult> PostOperationsAsync([FromBody] IList<OperationContainer> operations, CancellationToken cancellationToken)
        {
            return await base.PostOperationsAsync(operations, cancellationToken);
        }
    }
}
