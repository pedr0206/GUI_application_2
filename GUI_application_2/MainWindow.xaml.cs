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

namespace GUI_application_2
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           string Box1;

            Box1 = textBox.Text;
            textBox.Text = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = Box1;

            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            string Box2;

            Box2 = textBox3.Text;
            textBox3.Text = textBox2.Text;
            textBox2.Text = textBox1.Text;
            textBox1.Text = textBox.Text;
            textBox.Text = Box2;
        }
    }
}
