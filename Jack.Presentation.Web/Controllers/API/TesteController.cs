using System.Collections.Generic;
using System.Web.Http;

namespace Controllers.API
{
    public class TesteController : ApiController
	{

		// GET: api/Teste
		public IEnumerable<string> GetValues()
		{
			return new string[] {
				"value1",
				"value2"
			};
		}

		// GET: api/Teste/5
		public string GetValue(int id)
		{
			return "value";
		}

		// POST: api/Teste
		public void PostValue(	[FromBody()] string value)
		{
		}

		// PUT: api/Teste/5
		public void PutValue(int id, [FromBody()] string value)
		{
		}

		// DELETE: api/Teste/5

		public void DeleteValue(int id)
		{
		}
	}
}