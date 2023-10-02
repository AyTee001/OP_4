using System;
using System.Windows;

namespace OP_4.Helpers
{
    public static class ErrorMessageGenerator
    {
        public static void GenerateErrorMessage(Exception ex)
        {
            MessageBox.Show("Critical error: " + ex.Message);
        }
    }
}
