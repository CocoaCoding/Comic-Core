﻿using CCore.Data;
using CCore.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CCore
{
    public partial class MainWindow : RibbonWindow
    {
        ComicRepository comicRepository = new ComicRepository();
        PublisherRepository publisherRepository = new PublisherRepository();
        SeriesRepository seriesRepository = new SeriesRepository();
        ArtistRepository artistRepository = new ArtistRepository();

        public MainWindow()
        {
            //using (var context = new ComicContext())
            //{
            //    //var pub = new ComicPublisher() { PublisherName = "Marvel" };
            //    //context.Publishers.Add(pub);
            //    //context.SaveChanges();

            //    //var a = context.Publishers;
            //    //Debug.WriteLine(a.First().PublisherName);
            //}

            InitializeComponent();
            mainListView.ItemsSource = this.comicRepository.GetAll();
        }

        private void OnPublishersMenuItemClick(object sender, RoutedEventArgs e)
        {
            PublisherListWindow publisherListWindow = new PublisherListWindow(this.publisherRepository);
            publisherListWindow.ShowDialog();
        }

        private void OnSeriesMenuItemClick(object sender, RoutedEventArgs e)
        {
            SeriesListWindow seriesListWindow = new SeriesListWindow(this.seriesRepository);
            seriesListWindow.ShowDialog();
        }

        private void OnArtistsMenuItemClick(object sender, RoutedEventArgs e)
        {
            ArtistsListWindow artistsListWindow = new ArtistsListWindow(this.artistRepository);
            artistsListWindow.ShowDialog();
        }
    }
}
