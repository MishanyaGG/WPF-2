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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        bool dialogRes;

        /// <summary>
        /// Если окно было закрыто по нажатию кнопки "ОК", то свойство true, если окно закрыто по нажатию кнопки "Отмена" - false
        /// Это своство проверяется в главном окне после возврата из метода ShowDialog
        /// </summary>
        public bool DialogRes
        {
            get { return dialogRes; }
        }
        public Window2()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide(); //Метод Hide - говорит о том, что окно не закрывается, а удаляется
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
                dialogRes = false;
            textBox1.Focus(); //Диалоговое окно всегда отображается в одном и том же начальном состоянии
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            dialogRes = true;
            Close();
        }

        public void button2_Click(object sender, RoutedEventArgs e)
        {
            Owner.Title = textBox1.Text;
            Owner.OwnedWindows[0].Title = textBox2.Text;
        }
    }
}
