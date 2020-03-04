using System;

namespace CCore.Data
{
    public class Series
    {
        public string SeriesTitle { get; set; }
        public bool IsLimitedSeries { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Publisher SeriesPublisher { get; set; }
    }
}
