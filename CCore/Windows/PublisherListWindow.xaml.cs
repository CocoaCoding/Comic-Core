using CCore.Data;
using System;
using System.Collections.Generic;
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

        public PublisherListWindow(PublisherRepository publisherRepository)
        {
            InitializeComponent();
            this.publisherRepository = publisherRepository;
        }
    }
}
