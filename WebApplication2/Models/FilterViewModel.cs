using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using WebApplication2.coursework;

namespace WebApplication2.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<Genre> genres, int? genre, string name)
        {
            genres.Insert(0, new Genre { GenreName = "All", Id = 0 });
            Genres = new SelectList(genres, "Id", "GenreName", genre);
            SelectedGenre = genre;
            SelectedName = name;
        }

        public SelectList Genres { get; private set; }
        public int? SelectedGenre { get; private set; }
        public string SelectedName { get; private set; }
    }
}