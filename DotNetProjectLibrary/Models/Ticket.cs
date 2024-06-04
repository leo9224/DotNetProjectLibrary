namespace DotNetProjectLibrary.Models
{
    public class Ticket
    {
        public int id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public required string site_name { get; set; }
        public required string room_name { get; set; }
        public required string computer_name {  get; set; }
        public required string email {  get; set; }
        public required string message {  get; set; }
    }
}
