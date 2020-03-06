using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class ComicIssue
    {
        public Guid Id { get; set; }
        public string Series { get; set; }
        public string Issue { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public double CoverPrice { get; set; }
        public ICollection<ComicArtist> Artists { get; set; }
        public ComicPublisher Publisher { get; set; }
    }
}
