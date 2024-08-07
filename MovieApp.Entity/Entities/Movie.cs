using MovieApp.Core.Entities;

namespace MovieApp.Entity.Entities
{
    public class Movie : EntityBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public int Time { get; set; }
        public int Rate { get; set; }

        public ICollection<WatchHistory> WatchHistories { get; set; }
    }
}