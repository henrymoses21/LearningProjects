using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DiceRolling.Models;
using Microsoft.Xaml.Behaviors.Core;

namespace DiceRolling.ViewModel
{

    public class DieFaceViewModel : ViewModelBase
    {
        private readonly DieModel _dieModel = new DieModel();
        private bool _isNumeric;

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


        public bool IsNumeric
        {
            get => _isNumeric;
            set
            {
                _isNumeric = value;
                OnPropertyChanged(nameof(IsNumeric));
            }
        }


        public int RollValue => _dieModel.Value;


        public bool Dot00Visibility => !IsNumeric && new [] {4, 5, 6}.Contains(RollValue);

        public bool Dot10Visibility => !IsNumeric && new [] {6}.Contains(RollValue);

        public bool Dot11Visibility => !IsNumeric &&  new [] {3, 5}.Contains(RollValue);

        public bool Dot12Visibility => !IsNumeric &&  new [] {6}.Contains(RollValue);

        public bool Dot02Visibility => !IsNumeric &&  new [] {2, 3, 4, 5, 6}.Contains(RollValue);

        public bool Dot20Visibility => !IsNumeric && new [] {2, 3, 4, 5, 6}.Contains(RollValue);
        
        public bool Dot22Visibility => !IsNumeric && new [] {1, 4, 5, 6}.Contains(RollValue);
    }
}
