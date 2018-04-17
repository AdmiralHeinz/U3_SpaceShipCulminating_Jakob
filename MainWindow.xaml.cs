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

namespace U2_CulminatingSpaceship_Jakob
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Spaceship one = new Spaceship();
        Spaceship two = new Spaceship();
        public MainWindow()
        {
            InitializeComponent();
            cnvs.Children.Add(one.spaceship);
            cnvs.Children.Add(two.spaceship);




        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            ///MessageBox.Show("Clicked " +  e.Key.ToString());
            if (e.Key == Key.Up)
            {
                one.Fly();
            }
            if (e.Key == Key.Left)
            {
                one.TurnLeft();
            }
            if (e.Key == Key.Right)
            {
                one.TurnRight();
            }
            if (e.Key == Key.W)
            {
                two.Fly();
            }
            if (e.Key == Key.A)
            {
                two.TurnLeft();
            }
            if (e.Key == Key.D)
            {
                two.TurnRight();
            }



        }

       
    }
}
