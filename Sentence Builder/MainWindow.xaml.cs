//Author - Vaneesh Jha
//Author - Gideon Oteng
//Author - Prabh Singh

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

namespace Sentence_Builder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void The_Click(object sender, RoutedEventArgs e)
        {
            string TheWord = (string)The.Content;
            SentenceLabel.Content += TheWord;
        }

        private void That_Click(object sender, RoutedEventArgs e)
        {
            string ThatWord = (string)That.Content;
            SentenceLabel.Content += ThatWord ;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SentenceLabel.Content = "";
        }

        private void A_Click(object sender, RoutedEventArgs e)
        {
            string AWord = (string)A.Content;
            SentenceLabel.Content += AWord;
        }

        private void An_Click(object sender, RoutedEventArgs e)
        {
            string AnWord = (string)An.Content;
            SentenceLabel.Content += AnWord;
        }

        private void Man_Click(object sender, RoutedEventArgs e)
        {
            string ManWord = (string)Man.Content;
            SentenceLabel.Content += ManWord;
        }

        private void Woman_Click(object sender, RoutedEventArgs e)
        {
            string WomanWord = (string)Woman.Content;
            SentenceLabel.Content += WomanWord;
        }

        private void Dog_Click(object sender, RoutedEventArgs e)
        {
            string DogWord = (string)Dog.Content;
            SentenceLabel.Content += DogWord;
        }

        private void Cat_Click(object sender, RoutedEventArgs e)
        {
            string CatWord = (string)Cat.Content;
            SentenceLabel.Content += CatWord;
        }

        private void Car_Click(object sender, RoutedEventArgs e)
        {
            string CarWord = (string)Car.Content;
            SentenceLabel.Content += CarWord;
        }

        private void Bicycle_Click(object sender, RoutedEventArgs e)
        {
            string BicycleWord = (string)Bicycle.Content;
            SentenceLabel.Content += BicycleWord;
        }

        private void Beautiful_Click(object sender, RoutedEventArgs e)
        {
            string BeautifulWord = (string)Beautiful.Content;
            SentenceLabel.Content += BeautifulWord;
        }

        private void Big_Click(object sender, RoutedEventArgs e)
        {
            string BigWord = (string)Big.Content;
            SentenceLabel.Content += BigWord;
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            string SmallWord = (string)Small.Content;
            SentenceLabel.Content += SmallWord;
        }

        private void Strange_Click(object sender, RoutedEventArgs e)
        {
            string StrangeWord = (string)Strange.Content;
            SentenceLabel.Content += StrangeWord;
        }

        private void Looked_at_Click(object sender, RoutedEventArgs e)
        {
            string Looked_atWord = (string)Looked_at.Content;
            SentenceLabel.Content += Looked_atWord;
        }

        private void Rode_Click(object sender, RoutedEventArgs e)
        {
            string RodeWord = (string)Rode.Content;
            SentenceLabel.Content += RodeWord;
        }

        private void Spoke_to_Click(object sender, RoutedEventArgs e)
        {
            string Spoke_to_Word = (string)Spoke_to.Content;
            SentenceLabel.Content += Spoke_to_Word;
        }

        private void laughed_at_Click(object sender, RoutedEventArgs e)
        {
            string Laughed_at_Word = (string)Laughed_at.Content;
            SentenceLabel.Content += Laughed_at_Word;
        }

        private void Drove_Click(object sender, RoutedEventArgs e)
        {
            string DroveWord = (string)Drove.Content;
            SentenceLabel.Content += DroveWord;
        }

        private void Space_Click(object sender, RoutedEventArgs e)
        {
            SentenceLabel.Content += " ";
        }

        private void Period_Click(object sender, RoutedEventArgs e)
        {
            SentenceLabel.Content += ".";
        }

        private void Question_mark_Click(object sender, RoutedEventArgs e)
        {
            SentenceLabel.Content += "?";
        }

        private void Exclamation_Click(object sender, RoutedEventArgs e)
        {
            SentenceLabel.Content += "!";
        }

        private void Comma_Click(object sender, RoutedEventArgs e)
        {
            SentenceLabel.Content += ",";
        }
    }
}
