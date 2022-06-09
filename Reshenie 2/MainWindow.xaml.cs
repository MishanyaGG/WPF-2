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

namespace Reshenie_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 win1 = new Window1(); //Обработчики для класса
        Window2 win2 = new Window2();
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Свойство Owner можно присвоить значение только такого окна, которое
        /// уже отображено на экране поэтому мы его прописываем в Win_Loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            win1.Owner = this; //Возвращает или задаёт окно Window. Присваивание свойству Owner некоторого окна w1
                                //значения какого-либо другого окна w0 делает окно w1 подчиненным по отношению w0 и будет отображаться поверх главного
            win2.Owner = this;

            win1.Left = this.Left + this.ActualWidth - 10; //ActualWidth - Возвращает визуализированную ширину данного элемента.
            win1.Top = this.Top + this.ActualHeight - 10;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (win1.IsVisible)
                win1.Close();
            else
                win1.Show(); //Вывод окна для просмотра
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            win2.ShowDialog(); //Вывод диалоговое окно, которое может закрытся при нажатии опр. кнопки
            if (win2.DialogRes)
                win2.button2_Click(null, null);
        }
    }
}
