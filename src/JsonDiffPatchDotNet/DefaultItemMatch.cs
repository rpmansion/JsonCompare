using Newtonsoft.Json.Linq;
using System;

namespace JsonDiffPatchDotNet;

public class DefaultItemMatch : ItemMatch
{
	public DefaultItemMatch(Func<JToken, object> objectHash) : base(objectHash)
	{
	}
}
