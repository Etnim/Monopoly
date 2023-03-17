using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace Monopoly
{
    
    public partial class WelcomeWindow : Window
    {
        int playerCounter = 0;

        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void StartBut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Hide();
        }

        private void ExitBut_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            
            switch (playerCounter)
            {
                case 0:
                    PlayerName1.Content = NamesInput.Text;
                    break;
                case 1:
                    PlayerName2.Content = NamesInput.Text;
                    break;
                case 2:
                    PlayerName3.Content = NamesInput.Text;
                    break;
                case 3:
                    PlayerName4.Content = NamesInput.Text;
                    playerCounter = -1;
                    break;
            }
            playerCounter++;
            NamesInput.Text = "Print name...";
            
        }

        private void NamesInput_TextChanged(object sender, TextChangedEventArgs e)
        {
     
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void NamesInput_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NamesInput.Text = "";
        }

        /*
private void ButtonClick(object sender, RoutedEventArgs e)
{
}

private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
{

}

private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
{

}


private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
{
   player1.Name = Player1.Text;
}

private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
{
   player2.Name= Player2.Text;
}

private void Player3_TextChanged(object sender, TextChangedEventArgs e)
{
   player3.Name = Player3.Text;
}

private void MoneyToWin_TextChanged(object sender, TextChangedEventArgs e)
{
   try {
       WinMoney = Convert.ToInt32(MoneyToWin.Text.ToString());
   }
   catch {
       WinMoney = 1000;
   }
}

private void AddPlayer_Click(object sender, RoutedEventArgs e)
{

}

private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
{

}
*/
    }
}

