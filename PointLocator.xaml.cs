using OP_4.Extensions;
using OxyPlot;
using System.Windows;
using OP_4.Models;

namespace OP_4
{
    /// <summary>
    /// Interaction logic for PointLocator.xaml
    /// </summary>
    public partial class PointLocator : Window
    {
        public MainViewModel ViewModel { get; set; }

        public PointLocator()
        {
            ViewModel = new MainViewModel();

            InitializeComponent();

            DataContext = ViewModel;

            ConfigurePlotController();
        }

        private void PointToPlot_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(xCoordTextBox.Text, out double x) && double.TryParse(yCoordTextBox.Text, out double y))
            {
                ShowQuadrantMessage(x, y);
                (DataContext as MainViewModel)?.AddPoint(x, y);
            }
            else
            {
                MessageBox.Show("Please enter valid numeric coordinates.");
            }
        }

        private void ClearPlot_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel)?.ClearPlot();
        }

        private static void ShowQuadrantMessage(double x, double y)
        {
            if (x > 0 && y > 0)
            {
                MessageBox.Show("Point is in the first quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                MessageBox.Show("Point is in the second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                MessageBox.Show("Point is in the third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                MessageBox.Show("Point is in the fourth quadrant.");
            }
            else if (x == 0 && y != 0)
            {
                MessageBox.Show("Point lies on the y-axis.");
            }
            else if (x != 0 && y == 0)
            {
                MessageBox.Show("Point lies on the x-axis.");
            }
            else
            {
                MessageBox.Show("Point is at the origin.");
            }

        }

        private void ConfigurePlotController()
        {
            var controller = new PlotController();
            controller.ConfigureDraggablePlot();
            plotView.Controller = controller;
        }
    }
}
