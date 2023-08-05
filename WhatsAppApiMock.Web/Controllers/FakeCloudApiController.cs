using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;
using WhatsAppApiMock.Web.Data;

namespace WhatsAppApiMock.Web.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FakeCloudApiController : ControllerBase
	{
		private readonly Channel<IncomingPayload> _channel;

		public FakeCloudApiController(Channel<IncomingPayload> channel)
		{
			_channel = channel;
		}

		[HttpPost]
		public async Task<IActionResult> Messages([FromBody] IncomingPayload payload)
		{
			await _channel.Writer.WriteAsync(payload);
			return Ok();
		}
	}
}
