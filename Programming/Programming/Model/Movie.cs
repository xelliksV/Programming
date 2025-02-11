using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Movie
    {
        private String name;
        private int duration;
        private int yearOfRelease;
        private Genre genre;
        private double rating;

        public Movie()
        {
        }

        public Movie(string name, int duration, int yearOfRelease, Model.Genre genre, double rating)
        {
            setName(name);
            setDuration(duration);
            setYearOfRelease(yearOfRelease);
            setGenre(genre);
            setRating(rating);
        }

        public String getName()
        {
            return name;
        }
        public int getYearOfRelease()
        {
            return yearOfRelease;
        }
        public int getDuration()
        {
            return duration;
        }
        public Model.Genre getGenre()
        {
            return genre;
        }
        public double getRating()
        {
            return rating;
        }
        public void setRating(double rating)
        {
            if (Validator.assertValueInRange(rating, 0, 10))
            {
                this.rating = rating;
            }
        }
        public void setGenre(Model.Genre genre)
        {
            this.genre = genre;
        }
        public void setDuration(int duration)
        {
            if(Validator.assertOnPositiveValue(duration))
            {
                this.duration = duration;
            }
        }
        public void setYearOfRelease(int yearOfRelease)
        {
            if (Validator.assertValueInRange(yearOfRelease, 1899, 2026))
            {
                this.yearOfRelease = yearOfRelease;
            }
        }
        public void setName(String name)
        {
            this.name = name;
        }
    }
}
