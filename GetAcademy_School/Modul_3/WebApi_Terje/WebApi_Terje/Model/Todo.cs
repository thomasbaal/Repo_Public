namespace WebApi_Terje.Model
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime? Done { get; set; }

        public Todo()
        {

        }
        public Todo(string text) // Sender ikke inn DateTime done her da vi sender dette inn senere.
        {
            Id = Guid.NewGuid();
            Text = text;
        }



    }
}
