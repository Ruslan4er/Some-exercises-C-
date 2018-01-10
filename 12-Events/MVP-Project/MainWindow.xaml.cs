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

namespace MVP_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

       
        public event EventHandler AddChoice = null;
        public event EventHandler SubChoice = null;
        public event EventHandler MultChoice = null;
        public event EventHandler DivChoice = null;


        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
           ChoiceOpertion().Invoke(sender,e);
        }

        private EventHandler ChoiceOpertion()
        {
            switch (OperationsComboBox.Text)
            {
                case "+":
                    return AddChoice;
                case "-":
                    return SubChoice;
                case "*":
                    return MultChoice;
                case "/":
                    return DivChoice;
                default: return null;
            }
        }

        public int[] Data()
        {
            return new int[] {int.Parse(X1TextBox.Text), int.Parse(X2TextBox.Text)};
        }

        

    }
}
