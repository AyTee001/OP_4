using OxyPlot;

namespace OP_4.Extensions
{
    public static class ConfigureDraggablePlotExtension
    {
        public static void ConfigureDraggablePlot(this PlotController controller)
        {
            controller.BindMouseDown(OxyMouseButton.Left, PlotCommands.PanAt);
            controller.BindMouseDown(OxyMouseButton.Right, PlotCommands.ZoomRectangle);
            controller.UnbindMouseDown(OxyMouseButton.Left, OxyModifierKeys.Control);
            controller.BindMouseDown(OxyMouseButton.Left, OxyModifierKeys.Control, PlotCommands.ZoomRectangle);

        }
    }
}
