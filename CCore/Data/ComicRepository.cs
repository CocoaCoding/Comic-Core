using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class ComicRepository : IRepository<ComicIssue>
    {
        List<ComicIssue> comics;

        public ComicRepository()
        {
            comics = new List<ComicIssue>();
            this.CreateDemoData();
        }

        private void CreateDemoData()
        {
            ComicIssue comic = new ComicIssue();
            comic.Series = "The Amazing Spider-Man";
            comic.Issue = "123";
           // comic.Publisher = "Marvel";
            comic.Title = "One more day";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);

            comic = new ComicIssue();
            comic.Series = "Immortal Hulk";
            comic.Issue = "23";
            //comic.Publisher = "Marvel";
            comic.Title = "Smash";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);

            comic = new ComicIssue();
            comic.Series = "Invincible Iron Man";
            comic.Issue = "399";
           // comic.Publisher = "Marvel";
            comic.Title = "Daybreak";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);

            comic = new ComicIssue();
            comic.Series = "Action Comics";
            comic.Issue = "999";
            //comic.Publisher = "DC";
            comic.Title = "Krypton";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);

            comic = new ComicIssue();
            comic.Series = "Spawn";
            comic.Issue = "1";
            //comic.Publisher = "Image";
            comic.Title = "Here we go again";
            comic.PublishedDate = DateTime.Now;
            this.comics.Add(comic);
        }

        public List<ComicIssue> GetAll()
        {
            return this.comics;
        }

        public bool Add(ComicIssue item)
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
