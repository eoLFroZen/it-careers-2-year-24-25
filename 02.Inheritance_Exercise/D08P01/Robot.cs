namespace D08P01
{
    public class Robot : IIdentifiable
    {
        private string model;

        public Robot(string id, string model)
        {
            Id = id;
            this.model = model;
        }

        public string Id { get; private set; }
    }
}
