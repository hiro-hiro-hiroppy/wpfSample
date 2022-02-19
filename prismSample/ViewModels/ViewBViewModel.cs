using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prismSample.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _myLabel = string.Empty;
        public string MyLabel
        {
            get { return _myLabel; }
            set { SetProperty(ref _myLabel, value); }
        }

        public ViewBViewModel()
        {

        }
    }
}
