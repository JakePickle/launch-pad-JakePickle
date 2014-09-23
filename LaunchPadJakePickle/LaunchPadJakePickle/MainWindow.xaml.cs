using System.Windows;

namespace LaunchPadJakePickle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    using ViewModels;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }
    }
}
