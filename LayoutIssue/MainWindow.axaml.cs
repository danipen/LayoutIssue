using Avalonia.Controls;

namespace LayoutIssue
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CanResize = false;

            this.SizeToContent = SizeToContent.WidthAndHeight;

            mCheckbox2.Click += MCheckbox2_Click;
        }

        private void MCheckbox2_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            mContentPanel.IsVisible = mCheckbox2.IsChecked.Value;
        }
    }
}