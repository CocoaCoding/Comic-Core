using System.Collections.ObjectModel;
using System.Linq;

namespace CCore.Data
{
    public class PublisherRepository : IRepository<Publisher>
    {
        private ObservableCollection <Publisher> publishers;

        public PublisherRepository()
        {
            this.publishers = new ObservableCollection<Publisher>();
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

        public ObservableCollection<Publisher> GetAll()
        {
            return this.publishers;
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
