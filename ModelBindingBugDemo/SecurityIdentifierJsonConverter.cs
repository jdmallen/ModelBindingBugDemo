using System;
using System.Security.Principal;
using Newtonsoft.Json;

namespace ModelBindingBugDemo
{
	public class SecurityIdentifierJsonConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var sid = (SecurityIdentifier)value;
			serializer.Serialize(writer, sid != null ? sid.Value : value);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var readerValue = reader.Value?.ToString();
			SecurityIdentifier sid = null;
			if (!string.IsNullOrWhiteSpace(readerValue))
			{
				sid = new SecurityIdentifier(readerValue);
			}
			return sid ?? new JsonSerializer().Deserialize(reader, objectType);
		}

		public override bool CanConvert(Type objectType) => objectType == typeof(SecurityIdentifier);
	}
}
