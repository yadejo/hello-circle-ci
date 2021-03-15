using System;

namespace Movies.Domain.Models
{
    public class Movie
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }

        public int Rating { get; private set;}
        public string PosterUri { get; set; }

        public Movie(Guid id, string title, int rating, string posterUri) {
            this.Id = id;
            this.Title = title;
            SetRating(rating);
            this.PosterUri = posterUri;
        }

        public Movie(string title, int rating, string posterUri):this(Guid.NewGuid(), title, rating, posterUri) {}

        public void SetRating(int rating) {
            if(ValidateRating(rating)) {
                this.Rating = rating;
            }
        }

        private bool ValidateRating(int rating) {
            if(rating < 0 || rating > 10) {
                throw new InvalidRatingException();
            }

            return true;
        }
    }
}
