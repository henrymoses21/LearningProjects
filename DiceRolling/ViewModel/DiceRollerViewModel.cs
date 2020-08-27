using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DiceRolling.Enums;
using Microsoft.Xaml.Behaviors.Core;

namespace DiceRolling.ViewModel
{
    class DiceRollerViewModel : ViewModelBase
    {
        private DieFaceViewMode _diceViewMode = DieFaceViewMode.Dots;
        // ARTODO: replace these with an Observable Collection of DieFaceViewModel.
        private DieFaceViewModel _die1 = new DieFaceViewModel();
        private DieFaceViewModel _die2 = new DieFaceViewModel();
        private DieFaceViewModel _die3 = new DieFaceViewModel();
        private DieFaceViewModel _die4 = new DieFaceViewModel();

        public DieFaceViewMode DiceViewMode
        {
            get => _diceViewMode;
            set
            {
                _diceViewMode = value;
                _die1.DieViewMode = value;
                _die2.DieViewMode = value;
                _die3.DieViewMode = value;
                _die4.DieViewMode = value;
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
                            _die1.RollCommand.Execute(null);
                            _die2.RollCommand.Execute(null);
                            _die3.RollCommand.Execute(null);
                            _die4.RollCommand.Execute(null);
                        }));
            }
        }


        public DieFaceViewModel Die1
        {
            get => _die1;
            set
            {
                _die1 = value;
                OnPropertyChanged(nameof(Die1));
            }
        }

        public DieFaceViewModel Die2
        {
            get => _die2;
            set
            {
                _die2 = value;
                OnPropertyChanged(nameof(Die2));
            }
        }

        public DieFaceViewModel Die3
        {
            get => _die3;
            set
            {
                _die3 = value;
                OnPropertyChanged(nameof(Die3));
            }
        }

        public DieFaceViewModel Die4
        {
            get => _die4;
            set
            {
                _die4 = value;
                OnPropertyChanged(nameof(Die4));
            }
        }


    }
}
