using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using DiceRolling.Enums;


namespace DiceRolling.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class DieFaceView : UserControl
    {
        public static DependencyProperty RollCommandProperty =
            DependencyProperty.Register("RollCommand", typeof(ICommand), typeof(DieFaceView));


        public DieFaceView()
        {
            InitializeComponent();
        }

        public ICommand RollCommand
        {
            get => (ICommand)GetValue(RollCommandProperty);
            set => SetValue(RollCommandProperty, value);
        }

    }
}
