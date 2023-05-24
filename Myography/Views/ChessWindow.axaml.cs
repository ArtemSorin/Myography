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

        // ������� ������� ���������� ���� - Canvas
        var canvas = new Canvas();
        canvas.VerticalAlignment = Avalonia.Layout.VerticalAlignment.Top;
        canvas.HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Left;

        // ������ ������� � ���� ���� Canvas
        canvas.Width = 512;
        canvas.Height = 512;

        Ellipse myCircle = new Ellipse(); // �������� ������ �������� Ellipse (����)
        myCircle.Width = 50; // ������ ������
        myCircle.Height = 50; // ������ ������
        myCircle.Fill = Brushes.Red; // ������ ���� �������

        Canvas.SetLeft(myCircle, 55); // ������ ������������ �� �����������
        Canvas.SetTop(myCircle, 55); // ������ ������������ �� ���������

        canvas.Children.Add(myCircle); // ��������� ���� �� ������� Canvas

        // ������� 64x64 ��������������, �������������� ������ ��������� �����
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