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

namespace magic8ball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        public string message = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int numResponse = rnd.Next(0, 20);
            string[] response = new string[20] {"It is certain",
                                                "It is decidedly so",
                                                "Without a doubt",
                                                "Yes definitely",
                                                "You may rely on it",
                                                "As I see it, yes",
                                                "Most likely",
                                                "Outlook good",
                                                "Yes",
                                                "Signs point to yes",
                                                "Reply hazy, try again",
                                                "Ask again later",
                                                "Better not tell you now",
                                                "Cannot predict now",
                                                "Concentrate and ask again",
                                                "Don't count on it",
                                                "My reply is no",
                                                "My sources say no",
                                                "Outlook not so good",
                                                "Very doubtful"};

            lblBall.Content = response[numResponse];
        }
    }
}