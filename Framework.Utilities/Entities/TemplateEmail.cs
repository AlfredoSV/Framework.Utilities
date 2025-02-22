namespace Framework.Utilities.Entities
{
    public class TemplateEmail
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _body;

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        private DateTime _createdAt;

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value; }
        }


        private TemplateEmail(Guid id, string name, string body, DateTime createdAt)
        {
            _id = id;
            _name = name;
            _body = body;
            _createdAt = createdAt;
        }

        public static TemplateEmail Create(Guid id, string name, string body, DateTime createdAt)
        {
            return new TemplateEmail(id,name,body,createdAt);
        }
       
    }
}
