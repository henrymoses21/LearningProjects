using System.Linq;
using System.Windows.Input;
using DiceRolling.Enums;
using DiceRolling.Models;
using Microsoft.Xaml.Behaviors.Core;


namespace DiceRolling.ViewModel
{
    public class DieFaceViewModel : ViewModelBase
    {
        private readonly DieModel _dieModel = new DieModel();
        private DieFaceViewMode _dieViewMode = DieFaceViewMode.Dots;

        public ICommand RollCommand { get; }

        public DieFaceViewModel()
        {
            
            RollCommand = new ActionCommand(s =>
            {
                _dieModel.Roll();
                OnPropertyChanged(nameof(RollValue));
                OnPropertyChanged(nameof(Dot00Visibility));
                OnPropertyChanged(nameof(Dot02Visibility));
                OnPropertyChanged(nameof(Dot10Visibility));
                OnPropertyChanged(nameof(Dot11Visibility));
                OnPropertyChanged(nameof(Dot12Visibility));
                OnPropertyChanged(nameof(Dot20Visibility));
                OnPropertyChanged(nameof(Dot22Visibility));
            });
        }

        public DieFaceViewMode DieViewMode
        {
            get => _dieViewMode;
            set
            {
                _dieViewMode = value;
                OnPropertyChanged(nameof(DieViewMode));
            }
        }


        public int RollValue => _dieModel.Value;

        // NB. We can get rid of all of these properties with a ValueConverter.
        public bool Dot00Visibility => new [] {4, 5, 6}.Contains(RollValue);

        public bool Dot10Visibility => new [] {6}.Contains(RollValue);

        public bool Dot11Visibility => new [] {1, 3, 5}.Contains(RollValue);

        public bool Dot12Visibility => new [] {6}.Contains(RollValue);

        public bool Dot02Visibility => new [] {2, 3, 4, 5, 6}.Contains(RollValue);

        public bool Dot20Visibility => new [] {2, 3, 4, 5, 6}.Contains(RollValue);
        
        public bool Dot22Visibility => new [] {4, 5, 6}.Contains(RollValue);
    }
}
