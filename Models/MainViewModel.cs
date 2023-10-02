using OP_4.Extensions;
using OP_4.Helpers;
using OxyPlot;
using OxyPlot.Series;
using System;

namespace OP_4.Models
{
    public class MainViewModel
    {
        public PlotModel ScatterPlotModel { get; private set; }

        private readonly ScatterSeries _series;

        public MainViewModel()
        {
            ScatterPlotModel = new PlotModel { Title = "Plot" };

            var series = new ScatterSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerFill = OxyColors.Coral

            };
            _series = series;

            ScatterPlotModel.Series.Add(series);

            ScatterPlotModel.ConfigureAxes();
        }

        public void AddPoint(double x, double y)
        {
            try
            {
                _series.Points.Add(new ScatterPoint(x, y));
                ScatterPlotModel.InvalidatePlot(true);
            }
            catch (Exception ex)
            {
                ErrorMessageGenerator.GenerateErrorMessage(ex);
            }

        }

        public void ClearPlot()
        {
            try
            {
                _series.Points.Clear();
                ScatterPlotModel.InvalidatePlot(true);
            }
            catch (Exception ex)
            {
                ErrorMessageGenerator.GenerateErrorMessage(ex);
            }
        }

    }
}
