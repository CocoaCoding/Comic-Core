using System;

namespace CCore.Data
{
    public class ComicPublisher
    {
        public Guid Id { get; set; }

        public string PublisherName { get; set; }

        public ComicPublisher()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
