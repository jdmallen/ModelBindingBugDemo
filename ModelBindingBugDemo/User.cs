using System.Security.Principal;
using Newtonsoft.Json;

namespace ModelBindingBugDemo
{
    public class User
	{
		[JsonConverter(typeof(SecurityIdentifierJsonConverter))]
		public SecurityIdentifier UserSid { get; set; }
    }
}
