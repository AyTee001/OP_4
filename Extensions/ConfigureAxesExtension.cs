using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_4.Extensions
{
    public static class ConfigureAxesExtension
    {
        public static void ConfigureAxes(this PlotModel model)
        {
            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                PositionAtZeroCrossing = true,
                AxislineColor = OxyColors.Black
            };

            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                PositionAtZeroCrossing = true,
                AxislineColor = OxyColors.Black
            };

            var verticalLine = new LineAnnotation
            {
                Type = LineAnnotationType.Vertical,
                LineStyle = LineStyle.Solid,
                X = 0,
                Color = OxyColors.Black,
                StrokeThickness = 1,
                Text = "X"
            };

            var horizontalLine = new LineAnnotation
            {
                Type = LineAnnotationType.Horizontal,
                LineStyle = LineStyle.Solid,
                Y = 0,
                Color = OxyColors.Black,
                StrokeThickness = 1,
                Text = "Y"
            };

            model.Axes.Add(xAxis);
            model.Axes.Add(yAxis);

            model.Annotations.Add(verticalLine);
            model.Annotations.Add(horizontalLine);
        }

    }
}
