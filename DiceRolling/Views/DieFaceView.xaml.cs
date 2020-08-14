using System.Windows;
using System.Windows.Controls;
using DiceRolling.ViewModel;

namespace DiceRolling.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class DieFaceView : UserControl
    {
        public static DependencyProperty IsNumericProperty =
            DependencyProperty.Register("IsNumeric", typeof(bool), typeof(DieFaceView));

        public static DependencyProperty IsDotsProperty =
            DependencyProperty.Register("IsDots", typeof(bool), typeof(DieFaceView));
        
        public DieFaceView()
        {
            InitializeComponent();
        }

        public bool IsNumeric
        {
            get => (bool)GetValue(IsNumericProperty);
            set => SetValue(IsNumericProperty, value);
        }

        public bool IsDots
        {
            get => (bool)GetValue(IsDotsProperty);
            set => SetValue(IsDotsProperty, value);
        }

    }
}
