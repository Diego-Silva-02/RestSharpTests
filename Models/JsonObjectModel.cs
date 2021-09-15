namespace RestSharpTests.Models
{
    class JsonObjectModel
    {
        public int UserId { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }

        public JsonObjectModel(int userId, string body, string title)
        {
            UserId = userId;
            Body = body;
            Title = title;
        }
    }
}
