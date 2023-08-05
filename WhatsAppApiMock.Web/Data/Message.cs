namespace WhatsAppApiMock.Web.Data;

public partial class Message
{
	public string? From { get; set; }
	public string Id { get; set; }
	public long? Timestamp { get; set; }
	public Text? Text { get; set; }
	public string? Type { get; set; }
}
