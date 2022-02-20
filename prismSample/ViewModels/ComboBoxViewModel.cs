using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prismSample.ViewModels
{
    public sealed class ComboBoxViewModel
    {
        public int Value { get; }
        public string DisplayValue { get; }

        public ComboBoxViewModel(int value, string displayValue)
        {
            Value = value;
            DisplayValue = displayValue;
        }
    }
}
