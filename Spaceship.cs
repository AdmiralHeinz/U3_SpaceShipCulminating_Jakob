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
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace U2_CulminatingSpaceship_Jakob
{
    class Spaceship
    {
        public int pos_x= 0;
        public int pos_y = 0;
        
        public int angle = 0;
        public Rectangle spaceship;

        public Spaceship()
        {
            spaceship = new Rectangle();
            BitmapImage bitmapImage = new BitmapImage(new Uri("C:\\Users\\jakob\\Downloads\\X-Wing 1.jpg"));
            ImageBrush img = new ImageBrush(bitmapImage);
            spaceship.Fill = img;
            spaceship.Height = 150;
            spaceship.Width = 150;
            showValue();
        }
        public void showValue()
        {
            Console.WriteLine("x: " + pos_x.ToString() + ", y: " + pos_y.ToString());
        }
        
        public void reduce_angle()
        {
            Console.WriteLine(angle);
            if (350 < (Math.Abs(angle)))
            {
                angle = 0;
                //MessageBox.Show("reset angle");
            }

        }

        public void Fly()
        {
            reduce_angle();
            double move_x = 5 * Math.Cos(angle * (Math.PI / 180));
            double move_y = 5 * Math.Sin(angle * (Math.PI / 180));

            if (angle < 90)
            {
                pos_x -= (int)move_x;
                pos_y -= (int)move_y;
            }

            if (angle < 180 && angle > 90)
            {
                pos_x += (int)move_x;
                pos_y -= (int)move_y;
            }

            if (angle > 180 && angle > 270)
            {
                pos_x += (int)move_x;
                pos_y += (int)move_y;
            }

            if (angle > 180 && angle > 270)
            {
                pos_x -= (int)move_x;
                pos_y -= (int)move_y;
            }

                TranslateTransform fwd = new TranslateTransform(pos_x, pos_y);
            this.spaceship.RenderTransform = fwd;
        }

        public void TurnLeft()
        {
            reduce_angle(); 
            angle -= 10;
            spaceship.RenderTransformOrigin = new Point(0.5,0.5);
            TranslateTransform fwd = new TranslateTransform(pos_x, pos_y);
            TransformGroup transformGroup = new TransformGroup();
            transformGroup.Children.Add(new RotateTransform(angle));
            transformGroup.Children.Add(fwd);
            spaceship.RenderTransform = transformGroup;


        }

        public void TurnRight()
        {
            reduce_angle();
            angle += 10;
            spaceship.RenderTransformOrigin = new Point(0.5, 0.5);
            TranslateTransform fwd = new TranslateTransform(pos_x, pos_y);
            TransformGroup transformGroup = new TransformGroup();
            transformGroup.Children.Add(new RotateTransform(angle));
            transformGroup.Children.Add(fwd);
            spaceship.RenderTransform = transformGroup;
        }

        public void check_collision()
        {


        }





    }
}
