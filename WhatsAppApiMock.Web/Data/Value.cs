namespace WhatsAppApiMock.Web.Data;

public partial class Value
{
	public string? MessagingProduct { get; set; }
	public Metadata? Metadata { get; set; }
	public Contact[]? Contacts { get; set; }
	public Message[] Messages { get; set; }
}
