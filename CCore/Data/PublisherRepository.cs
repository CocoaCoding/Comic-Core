using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class PublisherRepository : IRepository<Publisher>
    {
        private List<Publisher> publishers;

        public PublisherRepository()
        {
            this.publishers = new List<Publisher>();
            this.CreateDemoData();
        }

        private void CreateDemoData()
        {
            Publisher p = new Publisher();
            p.PublisherName = "Marvel Comics";
            this.publishers.Add(p);

            p = new Publisher();
            p.PublisherName = "DC Comics";
            this.publishers.Add(p);

            p = new Publisher();
            p.PublisherName = "Image Comics";
            this.publishers.Add(p);

            p = new Publisher();
            p.PublisherName = "Dark Horse Comics";
            this.publishers.Add(p);
        }

        public List<Publisher> GetAll()
        {
            return new List<Publisher>(this.publishers);
        }

        public void Save()
        {
        }

        public bool Add(Publisher item)
        {
            this.publishers.Add(item);
            return true;
        }
    }
}
