using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace freeWPFtime
{

    public partial class MainWindow : Window
    {
        private Random _random;
        private int _targetNumber;
        private int count;

        public MainWindow()
        {
           InitializeComponent();
            _random = new Random();
            _targetNumber = _random.Next(1,101);
            count = 3;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            test.Text = _targetNumber.ToString();
            
            if (count != 0)
            {
                count--;
                countGuess_txt.Text = count.ToString();
                if (Convert.ToInt32(GuessInput.Text) > _targetNumber)
                {
                    ResultText.Text = "عدد کوچک تر وارد کن";

                }
                else if (Convert.ToInt32(GuessInput.Text) < _targetNumber)
                {
                    ResultText.Text = "عدد بزرگ تر وارد کن";


                }
                else
                {
                    ResultText.Text = "شما برنده شدید!";
                }
            }
            else
            {
                ResultText.Text = "شما باختید!";
                send_btn.IsEnabled = false;
            }

            /*if (Convert.ToInt32(GuessInput.Text) < _targetNumber)
            {
                ResultText.Text = "عدد بزرگ تر وارد کن";
               
            }

            if (Convert.ToInt32(GuessInput.Text) == _targetNumber)
            {
                ResultText.Text = "شما برنده شدید!";

            }*/
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int lowerBound = (_targetNumber / 10) * 10 + 1;
            int upperBound = lowerBound + 9;
            ResultText.Text = $"عدد مخفی بین {lowerBound} تا {upperBound} است.";
        }
    }

}