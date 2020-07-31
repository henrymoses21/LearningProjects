using DiceRolling.ViewModel;
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

namespace DiceRolling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int iRnd = new int();
        int iRnd1 = new int();
        int iRnd2 = new int();
        int iRnd3 = new int();
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.DataContext = new MainViewModel(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //imgDiceShow1.Source = null;
            //imgDiceShow2.Source = null;
            //imgDiceShow3.Source = null;
            //imgDiceShow4.Source = null;

            //iRnd = r.Next(0, 6);

            //if (iRnd == 0)
            //{
            //    imgDiceShow1.Source = imgDice1.Source;
            //    txtDiceShow1.Text = "1";
            //}
            //else if (iRnd == 1)
            //{
            //    imgDiceShow1.Source = imgDice2.Source;
            //    txtDiceShow1.Text = "2";
            //}
            //else if (iRnd == 2)
            //{
            //    imgDiceShow1.Source = imgDice3.Source;
            //    txtDiceShow1.Text = "3";
            //}
            //else if (iRnd == 3)
            //{
            //    imgDiceShow1.Source = imgDice4.Source;
            //    txtDiceShow1.Text = "4";
            //}
            //else if (iRnd == 4)
            //{
            //    imgDiceShow1.Source = imgDice5.Source;
            //    txtDiceShow1.Text = "5";
            //}
            //else
            //{
            //    imgDiceShow1.Source = imgDice6.Source;
            //    txtDiceShow1.Text = "6";
            //}

            //iRnd1 = r.Next(0, 6);

            //if (iRnd1 == 0)
            //{
            //    imgDiceShow2.Source = imgDice1.Source;
            //    txtDiceShow2.Text = "1";
            //}
            //else if (iRnd1 == 1)
            //{
            //    imgDiceShow2.Source = imgDice2.Source;
            //    txtDiceShow2.Text = "2";
            //}
            //else if (iRnd1 == 2)
            //{
            //    imgDiceShow2.Source = imgDice3.Source;
            //    txtDiceShow2.Text = "3";
            //}
            //else if (iRnd1 == 3)
            //{
            //    imgDiceShow2.Source = imgDice4.Source;
            //    txtDiceShow2.Text = "4";
            //}
            //else if (iRnd1 == 4)
            //{
            //    imgDiceShow2.Source = imgDice5.Source;
            //    txtDiceShow2.Text = "5";
            //}
            //else
            //{
            //    imgDiceShow2.Source = imgDice6.Source;
            //    txtDiceShow2.Text = "6";
            //}

            //iRnd2 = r.Next(0, 6);

            //if (iRnd2 == 0)
            //{
            //    imgDiceShow3.Source = imgDice1.Source;
            //    txtDiceShow3.Text = "1";
            //}
            //else if (iRnd2 == 1)
            //{
            //    imgDiceShow3.Source = imgDice2.Source;
            //    txtDiceShow3.Text = "2";
            //}
            //else if (iRnd2 == 2)
            //{
            //    imgDiceShow3.Source = imgDice3.Source;
            //    txtDiceShow3.Text = "3";
            //}
            //else if (iRnd2 == 3)
            //{
            //    imgDiceShow3.Source = imgDice4.Source;
            //    txtDiceShow3.Text = "4";
            //}
            //else if (iRnd2 == 4)
            //{
            //    imgDiceShow3.Source = imgDice5.Source;
            //    txtDiceShow3.Text = "5";
            //}
            //else
            //{
            //    imgDiceShow3.Source = imgDice6.Source;
            //    txtDiceShow3.Text = "6";
            //}

            //iRnd3 = r.Next(0, 6);

            //if (iRnd3 == 0)
            //{
            //    imgDiceShow4.Source = imgDice1.Source;
            //    txtDiceShow4.Text = "1";
            //}
            //else if (iRnd3 == 1)
            //{
            //    imgDiceShow4.Source = imgDice2.Source;
            //    txtDiceShow4.Text = "2";
            //}
            //else if (iRnd3 == 2)
            //{
            //    imgDiceShow4.Source = imgDice3.Source;
            //    txtDiceShow4.Text = "3";
            //}
            //else if (iRnd3 == 3)
            //{
            //    imgDiceShow4.Source = imgDice4.Source;
            //    txtDiceShow4.Text = "4";
            //}
            //else if (iRnd3 == 4)
            //{
            //    imgDiceShow4.Source = imgDice5.Source;
            //    txtDiceShow4.Text = "5";
            //}
            //else
            //{
            //    imgDiceShow4.Source = imgDice6.Source;
            //    txtDiceShow4.Text = "6";
            //}
        }

        //private void ShowNumbers_Checked(object sender, RoutedEventArgs e)
        //{
        //    if (ShowNumbers.IsChecked == true)
        //    {
        //        imgDiceShow1.Visibility = Visibility.Hidden;
        //        imgDiceShow2.Visibility = Visibility.Hidden;
        //        imgDiceShow3.Visibility = Visibility.Hidden;
        //        imgDiceShow4.Visibility = Visibility.Hidden;

        //        txtDiceShow1.Visibility = Visibility.Visible;
        //        txtDiceShow2.Visibility = Visibility.Visible;
        //        txtDiceShow3.Visibility = Visibility.Visible;
        //        txtDiceShow4.Visibility = Visibility.Visible;
        //    }
        //    else
        //    {
        //        imgDiceShow1.Visibility = Visibility.Visible;
        //        imgDiceShow2.Visibility = Visibility.Visible;
        //        imgDiceShow3.Visibility = Visibility.Visible;
        //        imgDiceShow4.Visibility = Visibility.Visible;

        //        txtDiceShow1.Visibility = Visibility.Hidden;
        //        txtDiceShow2.Visibility = Visibility.Hidden;
        //        txtDiceShow3.Visibility = Visibility.Hidden;
        //        txtDiceShow4.Visibility = Visibility.Hidden;
        //    }
        //}
    }
}
