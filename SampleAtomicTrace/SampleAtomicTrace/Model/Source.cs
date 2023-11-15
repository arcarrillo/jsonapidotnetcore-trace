using JsonApiDotNetCore.Resources;
using JsonApiDotNetCore.Resources.Annotations;
using System.Text.Json.Serialization;

namespace SampleAtomicTrace.Model
{
    [Resource(PublicName = "sources", GenerateControllerEndpoints = JsonApiDotNetCore.Controllers.JsonApiEndpoints.None)]
    public class Source : Identifiable<int>
    {
        /// <summary>
        /// Id of source
        /// </summary>
        [Attr(PublicName = "name")]
        public string? Name { get; set; }
    }
}
