using CCore.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CCore.Windows
{
    public partial class PublisherListWindow : Window
    {
        private PublisherRepository publisherRepository;
        private ObservableCollection<ComicPublisher> publisherCollection;

        public PublisherListWindow(PublisherRepository publisherRepository)
        {
            InitializeComponent();
            this.publisherRepository = publisherRepository;
            publisherCollection = new ObservableCollection<ComicPublisher>();
            foreach (var item in this.publisherRepository.GetAll())
            {
                publisherCollection.Add(item);
            }
            this.mainListView.ItemsSource = publisherCollection;
        }

        private void OnNewButtonClick(object sender, RoutedEventArgs e)
        {
            ComicPublisher publisher = new ComicPublisher();
            PublisherEditWindow publisherEditWindow = new PublisherEditWindow(WindowOpenMode.NewData, publisher);
            publisherEditWindow.ShowDialog();
            if (publisherEditWindow.DialogResult.HasValue && publisherEditWindow.DialogResult.Value)
            {
                this.publisherCollection.Add(publisher);
                this.publisherRepository.Add(publisher);
                this.publisherRepository.Save();
            }
        }

        private void OnEditButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
