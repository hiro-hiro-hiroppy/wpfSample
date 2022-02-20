﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prismSample.ViewModels
{
    public class MessageBoxViewViewModel : BindableBase, IDialogAware
    {
        public MessageBoxViewViewModel()
        {
            OKButton = new DelegateCommand(OKButtonExecute);
        }

        public string Title => "";

        public event Action<IDialogResult> RequestClose;

        private string _message = string.Empty;
        public string Message
        {
            get { return _message;  }
            set { SetProperty(ref _message, value);  }
        }

        public DelegateCommand OKButton { get; set; }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            Message = parameters.GetValue<string>(nameof(Message));
        }

        private void OKButtonExecute()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
        }
    }
}
