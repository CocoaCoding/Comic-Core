using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class ComicRepository : IRepository<Comic>
    {
        ObservableCollection<Comic> comics;

        public ComicRepository()
        {
            comics = new ObservableCollection<Comic>();
            this.CreateDemoData();
        }

        private void CreateDemoData()
        {
            Comic comic = new Comic();
            comic.Series = "The Amazing Spider-Man";
            comic.Issue = "123";
           // comic.Publisher = "Marvel";
            comic.Title = "One more day";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);

            comic = new Comic();
            comic.Series = "Immortal Hulk";
            comic.Issue = "23";
            //comic.Publisher = "Marvel";
            comic.Title = "Smash";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);

            comic = new Comic();
            comic.Series = "Invincible Iron Man";
            comic.Issue = "399";
           // comic.Publisher = "Marvel";
            comic.Title = "Daybreak";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);

            comic = new Comic();
            comic.Series = "Action Comics";
            comic.Issue = "999";
            //comic.Publisher = "DC";
            comic.Title = "Krypton";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);

            comic = new Comic();
            comic.Series = "Spawn";
            comic.Issue = "1";
            //comic.Publisher = "Image";
            comic.Title = "Here we go again";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);
        }

        public ObservableCollection<Comic> GetAll()
        {
            return this.comics;
        }

        public bool Add(Comic item)
        {
            this.comics.Add(item);
            return true;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
