using Newtonsoft.Json.Linq;
using System;

namespace JsonCompare
{
	public class DefaultItemMatch : ItemMatch
	{
		public DefaultItemMatch(Func<JToken, object> objectHash) : base(objectHash)
		{
		}
	}
}
