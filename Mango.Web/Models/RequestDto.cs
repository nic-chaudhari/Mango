using static Mango.Web.Utility.SD;
using System.Security.AccessControl;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public string? Data { get; set; }
        public string AccessToken { get; set; } 
    }
}
