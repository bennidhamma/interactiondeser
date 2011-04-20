using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace interactiondeser
{
	public class Runner
	{
		public static void Main (string[] args)
		{
			//for writing to console.
			JsonTextWriter jsonTw = new JsonTextWriter (Console.Out) { Formatting = Formatting.Indented };
			JsonSerializer jsonSer = new JsonSerializer ();
			
			var uri = "http://stream.datasift.net/baa1765434e30c0efd676455429c078f";
			using (var client = new WebClient())
			using (var reader = new StreamReader(client.OpenRead(uri), Encoding.UTF8, true))
			{
				while (true)
				{
					//read one full json object off the stack
					var jr = new JsonTextReader (reader);
					JObject token = (JObject)JToken.ReadFrom (jr);
					if (token["interaction"] != null)
					{
						var interaction = JsonConvert.DeserializeObject (token.ToString ());
						jsonSer.Serialize (jsonTw, interaction);
						Console.WriteLine ();
					}
				}						
			}	
		}
	}
}