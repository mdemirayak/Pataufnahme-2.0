using System.Windows;
using System.Windows.Controls;

namespace Pataufnahme.WPF.Components
{
    public partial class VipComp : UserControl
    {
        public VipComp()
        {
            InitializeComponent();
        }

        private void BemerkungsCheck_Checked(object sender, RoutedEventArgs e)
        {
            BermerkungsBox.IsEnabled = true;
            BermerkungsBox.Opacity = 1.0;
            BermerkungsBox.Text = string.Empty; // Optional: Clear the placeholder text when enabled
        }

        private void BemerkungsCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            BermerkungsBox.IsEnabled = false;
            BermerkungsBox.Opacity = 0.15;
            BermerkungsBox.Text = "hallo"; // Optional: Set placeholder text when disabled
        }

        private void PatientenCheck_Checked(object sender, RoutedEventArgs e)
        {
            PatientenBox.IsEnabled = true;
            PatientenBox.Opacity = 1.0;
            PatientenBox.Text = string.Empty; // Optional: Clear the placeholder text when enabled
        }

        private void PatientenCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            PatientenBox.IsEnabled = false;
            PatientenBox.Opacity = 0.15;
            PatientenBox.Text = "hallo"; // Optional: Set placeholder text when disabled
        }
    }
}

