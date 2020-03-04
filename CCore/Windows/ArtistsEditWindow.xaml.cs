using CCore.Data;
using System.Windows;

namespace CCore.Windows
{
    public partial class ArtistsEditWindow : Window
    {
        private Artist artist;

        public ArtistsEditWindow(WindowOpenMode openMode, Artist artist)
        {
            InitializeComponent();
            this.artist = artist;
            this.UpdateView(openMode);
        }

        private void UpdateView(WindowOpenMode openMode)
        {
            if (openMode == WindowOpenMode.EditData)
            {
                this.guidTextBlock.Text = this.artist.Id.ToString();
                this.artistNameTextBox.Text = this.artist.ArtistName;
            }
            else if (openMode == WindowOpenMode.NewData)
            {
                this.guidTextBlock.Text = this.artist.Id.ToString();
            }
        }

        private void UpdateModel()
        {
            this.artist.ArtistName = this.artistNameTextBox.Text.Trim();
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
