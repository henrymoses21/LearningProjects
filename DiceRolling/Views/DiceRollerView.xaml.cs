using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DiceRolling.Enums;

namespace DiceRolling.Views
{
    /// <summary>
    /// Interaction logic for DiceRollerView.xaml
    /// </summary>
    public partial class DiceRollerView : UserControl
    {
        public static DependencyProperty ViewModeProperty =
            DependencyProperty.Register("ViewMode", typeof(DieFaceViewMode), typeof(DiceRollerView));
        public DiceRollerView()
        {
            InitializeComponent();
        }
        public DieFaceViewMode ViewMode
        {
            get => (DieFaceViewMode)GetValue(ViewModeProperty);
            set => SetValue(ViewModeProperty, value);
        }

    }
}
