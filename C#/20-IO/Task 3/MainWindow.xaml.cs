using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
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

namespace Task_3
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


        private void ChoseColorButton_Click(object sender, RoutedEventArgs e)
        {
            var userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            var userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.Create, userStorage);
            var writer = new StreamWriter(userStream);

            writer.Write(TestColorPicker.SelectedColorText);
            writer.Close();
            userStream.Close();

            MessageBox.Show(string.Format("Цвет '{0}' \nсохранён в изолировано хранилище ", TestColorPicker.SelectedColorText));
        }

        private void TestColorPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            ColorLabel.Content = TestColorPicker.SelectedColorText;

            var bc = new BrushConverter();
            ColorLabel.Background = (Brush)bc.ConvertFromString(TestColorPicker.SelectedColor.ToString());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            var userStream = new IsolatedStorageFileStream("UserSettings.set", FileMode.OpenOrCreate, userStorage);
            var reader = new StreamReader(userStream);

            string color = reader.ReadToEnd();
            reader.Close();
            userStream.Close();

            var bc = new BrushConverter();
            if (!string.IsNullOrEmpty(color))
            {
                ColorLabel.Background = (Brush) bc.ConvertFromString(color);
            }
        }




    }
}
