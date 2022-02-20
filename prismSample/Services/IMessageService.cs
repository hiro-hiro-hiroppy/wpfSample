using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace prismSample.Services
{
    public interface IMessageService
    {
        void ShowDialog(string message);
        MessageBoxResult Question(string message);
    }
}
