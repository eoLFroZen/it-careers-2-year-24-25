namespace D08P02
{
    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string id, string model)
        {
            Id = id;
            this.model = model;
        }

        public string Id { get; }
    }
}
