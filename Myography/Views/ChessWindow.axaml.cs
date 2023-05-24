using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Myography.Views;

public partial class ChessWindow : Window
{
    public ChessWindow()
    {
        InitializeComponent();
    }
    public ChessWindow(string resolution, double distance)
    {
        InitializeComponent();

        // создаем главное содержимое окна - Canvas
        var canvas = new Canvas();
        canvas.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
        canvas.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;

        // задаем размеры и цвет фона Canvas
        canvas.Width = 512;
        canvas.Height = 512;

        Ellipse myCircle = new Ellipse(); // создание нового элемента Ellipse (круг)
        myCircle.Width = 50; // задаем ширину
        myCircle.Height = 50; // задаем высоту
        myCircle.Fill = Brushes.Red; // задаем цвет заливки

        Canvas.SetLeft(myCircle, 55); // задаем расположение по горизонтали
        Canvas.SetTop(myCircle, 55); // задаем расположение по вертикали

        canvas.Children.Add(myCircle); // добавляем круг на элемент Canvas

        // создаем 64x64 прямоугольника, представляющих клетки шахматной доски
        for (int x = 0; x < 96; x++)
        {
            for (int y = 0; y < 128; y++)
            {
                var rectangle = new Rectangle();
                rectangle.Width = canvas.Width / 8;
                rectangle.Height = canvas.Height / 8;
                rectangle.Fill = (x + y) % 2 == 0 ? Brushes.White : Brushes.Black;
                Canvas.SetTop(rectangle, y * rectangle.Height);
                Canvas.SetLeft(rectangle, x * rectangle.Width);
                canvas.Children.Add(rectangle);
            }
        }

        Content = canvas;
    }
}