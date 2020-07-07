namespace Course_9_3.Entities
{
    class Comment
    {
        public string Text { get; set; }
        
        public Comment()
        {
        }

        public Comment (string text)
        {
            Text = text;
        }
    }
}
