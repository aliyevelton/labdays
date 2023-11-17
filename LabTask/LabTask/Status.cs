namespace LabTask
{
    public class Status
    {
        private static int _id = 0;
        public int Id { get; }
        public string Title { get; set; }
        public string Content {  get; set; }
        public DateTime SharedTime { get; set; }
        public Status(string title, string content) 
        {
            Id = ++_id;
            Title = title;
            Content = content;
            SharedTime = DateTime.Now;
        }
        public string GetStatusInfo()
        {
            return $"Title: {Title} - Content: {Content} - Shared {(DateTime.Now - SharedTime).Milliseconds} milliseconds ago";
        }
        public override string ToString()
        {
            return $"Title: {Title} - Content: {Content} - Shared {(DateTime.Now - SharedTime).Milliseconds} milliseconds ago";
        }
    }
}
