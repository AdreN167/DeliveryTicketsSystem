using Microsoft.VisualBasic;

namespace ExtraTask
{
    public class Ticket
    {
        public string Number { get; set; }
        public DateAndTime DateOfIssue { get; set; }
        public TicketType Type { get; set; }
        public int Price { get; set; }
    }
}
