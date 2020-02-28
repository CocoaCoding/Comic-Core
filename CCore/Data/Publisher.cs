using System;

namespace CCore.Data
{
    public class Publisher
    {
        public Guid Id { get; set; }

        public string PublisherName { get; set; }

        public Publisher()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
