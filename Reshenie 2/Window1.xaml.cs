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
using System.Windows.Shapes;

namespace Reshenie_2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int count;
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsVisible)
                return;
            e.Cancel = true;
            if (MessageBox.Show("Закрыть подчиненное окно?","Подтверждение", MessageBoxButton.YesNo,MessageBoxImage.Question,MessageBoxResult.No)==MessageBoxResult.Yes)
            Hide();
            Owner.Activate();
        }

        /// <summary>
        /// Определяет значения. В данном случае при открытии кнопки меняется её название.
        /// Можно сказать IsVisible - окно открыто
        /// Owner - владелец
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            (Owner.FindName("button1") as Button).Content = IsVisible ? //Так можно легко писать if (Я В ШОКЕ)
                "Закрыть подчиненное окно" : "Открыть подчиненное окно";
            if (IsVisible)
                textBlock.Text = "Окно открыто в " + (++count) + "-й раз.";
        }
    }
}
