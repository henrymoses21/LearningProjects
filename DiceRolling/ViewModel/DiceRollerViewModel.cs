using System.Collections.ObjectModel;
using System.Windows.Input;
using DiceRolling.Enums;
using Microsoft.Xaml.Behaviors.Core;

namespace DiceRolling.ViewModel
{
    class DiceRollerViewModel : ViewModelBase
    {

        public DiceRollerViewModel()
        {
            this.NumberOfDice = 64;
        }

        private ObservableCollection<DieFaceViewModel> _dice = new ObservableCollection<DieFaceViewModel>();

        public ObservableCollection<DieFaceViewModel> Dice
        {
            get => _dice;
            set
            {
                if (_dice == value) return;
                _dice = value;
                OnPropertyChanged(nameof(Dice));
            }
        }

        private int _numberOfDice = 0;
        public int NumberOfDice
        {
            get => _numberOfDice;
            set
            {
                if (_numberOfDice == value) return;
                if (value < 1 || value > 1024) return; // note; this should return error, not just fail silently.

                _numberOfDice = value;

                this.Dice.Clear();
                for (var i = 0; i < _numberOfDice; i++)
                {
                    this.Dice.Add(new DieFaceViewModel());
                }


                OnPropertyChanged(nameof(NumberOfDice));
            }
        }

        private DieFaceViewMode _diceViewMode = DieFaceViewMode.Dots;
        public DieFaceViewMode DiceViewMode
        {
            get => _diceViewMode;
            set
            {
                if (_diceViewMode == value) return;
                _diceViewMode = value;
                foreach (var dieFaceModel in this.Dice)
                {
                    dieFaceModel.DieViewMode = value;
                }
                OnPropertyChanged(nameof(DiceViewMode));
            }
        }

        private ICommand _rollAllDiceCommand;
        public ICommand RollAllDiceCommand
        {
            get
            {
                // this construct ensures that _rollAllDiceCommand is only instantiated
                // and set once, and is then reused.
                return _rollAllDiceCommand ?? (
                    _rollAllDiceCommand = new ActionCommand(
                        () =>
                        {
                            foreach (var dieFaceModel in this.Dice)
                            {
                                dieFaceModel.RollCommand.Execute(null);
                            }
                            OnPropertyChanged(nameof(Dice));
                        }));
            }
        }
    }
}
