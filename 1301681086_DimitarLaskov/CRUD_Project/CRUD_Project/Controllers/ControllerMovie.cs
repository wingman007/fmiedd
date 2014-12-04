﻿using CRUD_Project.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Project.Controllers
{
    class ControllerMovie
    {
        DataClasses1DataContext db;
   
        public ControllerMovie()
        {
            db = new DataClasses1DataContext();
        }

        public void AddMovie(Movy movie)
        {
            db.Movies.InsertOnSubmit(movie);
            db.SubmitChanges();          
        }

        public void EditMovie(Movy movie)
        {      
            var movieUpdate = from m in db.Movies
                                where m.Id == movie.Id
                                select m;

            Movy movieTemp = movieUpdate.FirstOrDefault();

            movieTemp.Title = movie.Title;
            movieTemp.Category = movie.Category + 1;
            movieTemp.Director = movie.Director;
            movieTemp.Cast = movie.Cast;
            movieTemp.Country = movie.Country;
            movieTemp.Year = movie.Year;
            movieTemp.Description = movie.Description;

            db.SubmitChanges();
        }

        public void DeleteMovie(int id)
        {
            var movieToDelete = (from m in db.Movies
                                    where m.Id == id
                                    select m).FirstOrDefault();

            if (movieToDelete != null)
            {
                db.Movies.DeleteOnSubmit(movieToDelete);
                db.SubmitChanges();
            }
            
        }

        private List<ModelMovie> GetMoviesFromDatabase()
        {
            var movies = from m in db.Movies
                            select new ModelMovie
                            {
                                Id = m.Id,
                                Title = m.Title,
                                Category = (from c in db.Categories
                                                where m.Category == c.Id
                                                select c.CategoryName).First(),
                                Year = m.Year,
                                Director = m.Director,
                                Username = (from u in db.Users
                                        where m.UserId == u.Id
                                        select u.Username).First()
                            };

            return movies.ToList();
        }

        public void LoadMoviesToListView(ListView listView1)
        {
            int count = 0;
            foreach (var item in GetMoviesFromDatabase())
            {
                listView1.Items.Add(item.Id.ToString());
                listView1.Items[count].SubItems.Add(item.Title);
                listView1.Items[count].SubItems.Add(item.Category);
                listView1.Items[count].SubItems.Add(item.Year.ToString());
                listView1.Items[count].SubItems.Add(item.Director);
                listView1.Items[count].SubItems.Add(item.Username);
                count++;
            }
        }

        public ModelMovie GetOneMovie(int id)
        {
            var movie = from m in db.Movies
                        where m.Id == id
                        select new ModelMovie
                        {
                            Title = m.Title,
                            Director = m.Director,
                            Cast = m.Cast,
                            Country = m.Country,
                            Year = m.Year,
                            Description = m.Description,
                            Category = m.Category.ToString()
                        };

            return movie.FirstOrDefault();
        }

        public List<Movy> GetByCondition(string text, string category, int year)
        {
            List<Movy> movies;

            if (category == "All Genres..")
            {
                movies = (from m in db.Movies
                            where m.Title.Contains(text) &&                          
                            m.Year == year
                            select m).ToList();
            }
            else
            {
                movies = (from m in db.Movies
                              where m.Title.Contains(text) &&
                              m.Category1.CategoryName == category &&
                              m.Year == year
                              select m).ToList();
            }
          
            return movies;
        }
    }
}
