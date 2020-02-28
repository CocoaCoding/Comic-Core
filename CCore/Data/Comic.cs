using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class Comic
    {
        public string Series { get; set; }
        public string Issue { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public double CoverPrice { get; set; }
        public List<String> Artists { get; set; }
        public string Publisher { get; set; }
    }
}
