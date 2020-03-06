using System;

namespace CCore.Data
{
    public class ComicSeries
    {
        public Guid Id { get; set; }
        public string SeriesTitle { get; set; }
        public bool IsLimitedSeries { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ComicPublisher SeriesPublisher { get; set; }
    }
}
