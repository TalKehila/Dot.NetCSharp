using System.Windows;
using System.Windows.Controls;

namespace WpfMemoryLeak
{
    public partial class OtherWindow : Window
    {
        public OtherWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 1e6; i++)
            {
                var btn = new Button { Content = i.ToString() };
                lvButtons.Items.Add(btn);
            }
        }
    }
}