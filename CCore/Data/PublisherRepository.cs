using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace CCore.Data
{
    public class PublisherRepository : IRepository<ComicPublisher>
    {
        private List <ComicPublisher> publishers;

        public PublisherRepository()
        {
            this.publishers = new List<ComicPublisher>();
            this.CreateDemoData();
        }

        private void CreateDemoData()
        {
            ComicPublisher p = new ComicPublisher();
            p.PublisherName = "Marvel Comics";
            this.publishers.Add(p);

            p = new ComicPublisher();
            p.PublisherName = "DC Comics";
            this.publishers.Add(p);

            p = new ComicPublisher();
            p.PublisherName = "Image Comics";
            this.publishers.Add(p);

            p = new ComicPublisher();
            p.PublisherName = "Dark Horse Comics";
            this.publishers.Add(p);
        }

        public List<ComicPublisher> GetAll()
        {
            return this.publishers;
        }

        public void Save()
        {
        }

        public bool Add(ComicPublisher item)
        {
            this.publishers.Add(item);
            return true;
        }
    }
}
