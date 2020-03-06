using CCore.Data;
using System.Windows;

namespace CCore.Windows
{
    public partial class PublisherEditWindow : Window
    {
        private ComicPublisher publisher;

        public PublisherEditWindow(WindowOpenMode openMode, ComicPublisher publisher)
        {
            InitializeComponent();
            this.publisher = publisher;
            this.UpdateView(openMode);
        }

        private void UpdateView(WindowOpenMode openMode)
        {
            if (openMode == WindowOpenMode.EditData)
            {
            this.guidTextBlock.Text = this.publisher.Id.ToString();
            this.publisherNameTextBox.Text = this.publisher.PublisherName;
            }
            else if (openMode == WindowOpenMode.NewData)
            {
                this.guidTextBlock.Text = this.publisher.Id.ToString();
            }
        }

        private void UpdateModel()
        {
            this.publisher.PublisherName = this.publisherNameTextBox.Text.Trim();
        }

        private void OnOkButtonClick(object sender, RoutedEventArgs e)
        {
            this.UpdateModel();
            this.DialogResult = true;
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
