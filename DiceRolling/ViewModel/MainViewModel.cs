using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DiceRolling.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        //Initialize data to get value from Random Object
        int iRnd = new int();
        int iRnd1 = new int();
        int iRnd2 = new int();
        int iRnd3 = new int();

        //Built-in Randon function to generate Random number for dice.
        Random r = new Random();

        // Commands which are bind to the buttons and trigger on button click
        private ICommand _buttonClick;
        private ICommand _exitButton;

        //Image sources for six images of all six sides of dice
        private string _imageSource1;
        private string _imageSource2;
        private string _imageSource3;
        private string _imageSource4;
        private string _imageSource5;
        private string _imageSource6;

        // Bind to the check box to determine checkbox value
        private bool _chkBoxChecked;

        // Bind to image source of all 4 dices to be displayed
        private string _imgDiceShow1;
        private string _imgDiceShow2;
        private string _imgDiceShow3;
        private string _imgDiceShow4;

        // Bind to TextBoxes of all 4 dices to be displayed
        private string _textBox1;
        private string _textBox2;
        private string _textBox3;
        private string _textBox4;

        //Define the visibility of Images and TextBixes which are bind to dices to be displayed
        private Visibility _imgDiceShow1Visibility;
        private Visibility _imgDiceShow2Visibility;
        private Visibility _imgDiceShow3Visibility;
        private Visibility _imgDiceShow4Visibility;

        private Visibility _textBox1Visibility;
        private Visibility _textBox2Visibility;
        private Visibility _textBox3Visibility;
        private Visibility _textBox4Visibility;


        //Constructor
        public MainViewModel(DependencyObject control)
        {
            SetDefaults(); //Set default values
        }

        //Public properties
        #region Public Properties
        public ICommand ButtonClick
        {
            get { return _buttonClick; }
            set
            {
                _buttonClick = value;
                OnPropertyChanged("ButtonClick");
            }
        }
        public ICommand ExitButton
        {
            get { return _exitButton; }
            set
            {
                _exitButton = value;
                OnPropertyChanged("ExitButton");
            }
        }
        public string ImageSource1
        {
            get { return _imageSource1; }
            set
            {
                _imageSource1 = value;
                OnPropertyChanged("ImageSource1");
            }
        }
        public string ImageSource2
        {
            get { return _imageSource2; }
            set
            {
                _imageSource2 = value;
                OnPropertyChanged("ImageSource2");
            }
        }
        public string ImageSource3
        {
            get { return _imageSource3; }
            set
            {
                _imageSource3 = value;
                OnPropertyChanged("ImageSource3");
            }
        }
        public string ImageSource4
        {
            get { return _imageSource4; }
            set
            {
                _imageSource4 = value;
                OnPropertyChanged("ImageSource4");
            }
        }
        public string ImageSource5
        {
            get { return _imageSource5; }
            set
            {
                _imageSource5 = value;
                OnPropertyChanged("ImageSource5");
            }
        }
        public string ImageSource6
        {
            get { return _imageSource6; }
            set
            {
                _imageSource6 = value;
                OnPropertyChanged("ImageSource6");
            }
        }
        public bool ChkBoxChecked
        {
            get { return _chkBoxChecked; }
            set
            {
                _chkBoxChecked = value;
                OnPropertyChanged("ChkBoxChecked");

                if (ChkBoxChecked)//If checkBox checked, hide the images and show the TextBoxes to show number value of dice
                {

                    ImgDiceShow1Visibility = Visibility.Hidden;
                    ImgDiceShow2Visibility = Visibility.Hidden;
                    ImgDiceShow3Visibility = Visibility.Hidden;
                    ImgDiceShow4Visibility = Visibility.Hidden;

                    TextBox1Visibility = Visibility.Visible;
                    TextBox2Visibility = Visibility.Visible;
                    TextBox3Visibility = Visibility.Visible;
                    TextBox4Visibility = Visibility.Visible;
                }
                else //If Un-checked, hide the Numbers and show the Images to show value of dice
                {
                    ImgDiceShow1Visibility = Visibility.Visible;
                    ImgDiceShow2Visibility = Visibility.Visible;
                    ImgDiceShow3Visibility = Visibility.Visible;
                    ImgDiceShow4Visibility = Visibility.Visible;

                    TextBox1Visibility = Visibility.Hidden;
                    TextBox2Visibility = Visibility.Hidden;
                    TextBox3Visibility = Visibility.Hidden;
                    TextBox4Visibility = Visibility.Hidden;
                }
            }
        }

        public string ImgDiceShow1
        {
            get { return _imgDiceShow1; }
            set
            {
                _imgDiceShow1 = value;
                OnPropertyChanged("ImgDiceShow1");
            }
        }
        public string ImgDiceShow2
        {
            get { return _imgDiceShow2; }
            set
            {
                _imgDiceShow2 = value;
                OnPropertyChanged("ImgDiceShow2");
            }
        }
        public string ImgDiceShow3
        {
            get { return _imgDiceShow3; }
            set
            {
                _imgDiceShow3 = value;
                OnPropertyChanged("ImgDiceShow3");
            }
        }
        public string ImgDiceShow4
        {
            get { return _imgDiceShow4; }
            set
            {
                _imgDiceShow4 = value;
                OnPropertyChanged("ImgDiceShow4");
            }
        }

        public string TextBox1
        {
            get { return _textBox1; }
            set
            {
                _textBox1 = value;
                OnPropertyChanged("TextBox1");
            }
        }
        public string TextBox2
        {
            get { return _textBox2; }
            set
            {
                _textBox2 = value;
                OnPropertyChanged("TextBox2");
            }
        }
        public string TextBox3
        {
            get { return _textBox3; }
            set
            {
                _textBox3 = value;
                OnPropertyChanged("TextBox3");
            }
        }
        public string TextBox4
        {
            get { return _textBox4; }
            set
            {
                _textBox4 = value;
                OnPropertyChanged("TextBox4");
            }
        }

        public Visibility ImgDiceShow1Visibility
        {
            get { return _imgDiceShow1Visibility; }
            set
            {
                _imgDiceShow1Visibility = value;
                OnPropertyChanged("ImgDiceShow1Visibility");
            }
        }
        public Visibility ImgDiceShow2Visibility
        {
            get { return _imgDiceShow2Visibility; }
            set
            {
                _imgDiceShow2Visibility = value;
                OnPropertyChanged("ImgDiceShow2Visibility");
            }
        }
        public Visibility ImgDiceShow3Visibility
        {
            get { return _imgDiceShow3Visibility; }
            set
            {
                _imgDiceShow3Visibility = value;
                OnPropertyChanged("ImgDiceShow3Visibility");
            }
        }
        public Visibility ImgDiceShow4Visibility
        {
            get { return _imgDiceShow4Visibility; }
            set
            {
                _imgDiceShow4Visibility = value;
                OnPropertyChanged("ImgDiceShow4Visibility");
            }
        }

        public Visibility TextBox1Visibility
        {
            get { return _textBox1Visibility; }
            set
            {
                _textBox1Visibility = value;
                OnPropertyChanged("TextBox1Visibility");
            }
        }
        public Visibility TextBox2Visibility
        {
            get { return _textBox2Visibility; }
            set
            {
                _textBox2Visibility = value;
                OnPropertyChanged("TextBox2Visibility");
            }
        }
        public Visibility TextBox3Visibility
        {
            get { return _textBox3Visibility; }
            set
            {
                _textBox3Visibility = value;
                OnPropertyChanged("TextBox3Visibility");
            }
        }
        public Visibility TextBox4Visibility
        {
            get { return _textBox4Visibility; }
            set
            {
                _textBox4Visibility = value;
                OnPropertyChanged("TextBox4Visibility");
            }
        }
        #endregion

        private void BtnClick(object p = null)//Button click Method of Dice Roll Button
        {
            //set Images source empty
            ImgDiceShow1 = null;
            ImgDiceShow2 = null;
            ImgDiceShow3 = null;
            ImgDiceShow4 = null;

            iRnd = r.Next(0, 6);//get random value from 0-5

            //Compare the Random number for 1st Dice and set the image source and Number value accordingly
            if (iRnd == 0)
            {
                ImgDiceShow1 = ImageSource1;
                TextBox1 = "1";
            }
            else if (iRnd == 1)
            {
                ImgDiceShow1 = ImageSource2;
                TextBox1 = "2";
            }
            else if (iRnd == 2)
            {
                ImgDiceShow1 = ImageSource3;
                TextBox1 = "3";
            }
            else if (iRnd == 3)
            {
                ImgDiceShow1 = ImageSource4;
                TextBox1 = "4";
            }
            else if (iRnd == 4)
            {
                ImgDiceShow1 = ImageSource5;
                TextBox1 = "5";
            }
            else
            {
                ImgDiceShow1 = ImageSource6;
                TextBox1 = "6";
            }

            iRnd1 = r.Next(0, 6);//generate random number for dice 2
            //Compare the Random number for 2nd Dice and set the image source and Number value accordingly
            if (iRnd1 == 0)
            {
                ImgDiceShow2 = ImageSource1;
                TextBox2 = "1";
            }
            else if (iRnd1 == 1)
            {
                ImgDiceShow2 = ImageSource2;
                TextBox2 = "2";
            }
            else if (iRnd1 == 2)
            {
                ImgDiceShow2 = ImageSource3;
                TextBox2 = "3";
            }
            else if (iRnd1 == 3)
            {
                ImgDiceShow2 = ImageSource4;
                TextBox2 = "4";
            }
            else if (iRnd1 == 4)
            {
                ImgDiceShow2 = ImageSource5;
                TextBox2 = "5";
            }
            else
            {
                ImgDiceShow2 = ImageSource6;
                TextBox2 = "6";
            }

            iRnd2 = r.Next(0, 6);//generate random number for dice 3
            //Compare the Random number for 3rd Dice and set the image source and Number value accordingly
            if (iRnd2 == 0)
            {
                ImgDiceShow3 = ImageSource1;
                TextBox3 = "1";
            }
            else if (iRnd2 == 1)
            {
                ImgDiceShow3 = ImageSource2;
                TextBox3 = "2";
            }
            else if (iRnd2 == 2)
            {
                ImgDiceShow3 = ImageSource3;
                TextBox3 = "3";
            }
            else if (iRnd2 == 3)
            {
                ImgDiceShow3 = ImageSource4;
                TextBox3 = "4";
            }
            else if (iRnd2 == 4)
            {
                ImgDiceShow3 = ImageSource5;
                TextBox3 = "5";
            }
            else
            {
                ImgDiceShow3 = ImageSource6;
                TextBox3 = "6";
            }

            iRnd3 = r.Next(0, 6);//generate random number for dice 4
            //Compare the Random number for 4th Dice and set the image source and Number value accordingly
            if (iRnd3 == 0)
            {
                ImgDiceShow4 = ImageSource1;
                TextBox4 = "1";
            }
            else if (iRnd3 == 1)
            {
                ImgDiceShow4 = ImageSource2;
                TextBox4 = "2";
            }
            else if (iRnd3 == 2)
            {
                ImgDiceShow4 = ImageSource3;
                TextBox4 = "3";
            }
            else if (iRnd3 == 3)
            {
                ImgDiceShow4 = ImageSource4;
                TextBox4 = "4";
            }
            else if (iRnd3 == 4)
            {
                ImgDiceShow4 = ImageSource5;
                TextBox4 = "5";
            }
            else
            {
                ImgDiceShow4 = ImageSource6;
                TextBox4 = "6";
            }
        }

        //Button click of Exit Button
        private void BtnExitClick(object p = null)
        {
            System.Environment.Exit(0);//Exit the Application
        }

        //Set Default Vaules
        private void SetDefaults()
        {
            //Set the image sources from directory
            ImageSource1 = @"Images/1.jpg";
            ImageSource2 = @"Images/2.jpg";
            ImageSource3 = @"Images/3.jpg";
            ImageSource4 = @"Images/4.jpg";
            ImageSource5 = @"Images/5.jpg";
            ImageSource6 = @"Images/6.jpg";

            //set button click event handlers
            ButtonClick = new CommandHandler(new Action<object>(BtnClick));
            ExitButton = new CommandHandler(new Action<object>(BtnExitClick));

            // Set default visibility of image values to hidden and show the Number values
            ImgDiceShow1Visibility = Visibility.Visible;
            ImgDiceShow2Visibility = Visibility.Visible;
            ImgDiceShow3Visibility = Visibility.Visible;
            ImgDiceShow4Visibility = Visibility.Visible;

            TextBox1Visibility = Visibility.Hidden;
            TextBox2Visibility = Visibility.Hidden;
            TextBox3Visibility = Visibility.Hidden;
            TextBox4Visibility = Visibility.Hidden;
        }
    }
}
