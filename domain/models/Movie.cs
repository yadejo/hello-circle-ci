using System;

namespace MovApi.Domain.Models
{
    public class Movie
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }

        public int Rating { get; private set;}

        public Movie(Guid id, string title, int rating) {
            this.Id = id;
            this.Title = title;
            SetRating(rating);
        }

        public Movie(string title, int rating):this(Guid.NewGuid(), title, rating) {}

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
