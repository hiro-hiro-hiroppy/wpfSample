using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using prismSample.Services;
using prismSample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace prismSample.ViewModels
{
    public class ViewCViewModel : BindableBase, IDialogAware
    {
        private IDialogService _dialogService;
        private IMessageService _messageService;
        private string _viewCTextBox = "XXX";
        
        public event Action<IDialogResult> RequestClose;

        public string ViewCTextBox
        {
            get { return _viewCTextBox;  }
            set { SetProperty(ref _viewCTextBox, value); }
        }

        public string Title => "ViewCのタイトル";

        /// <summary>
        /// OKボタン
        /// </summary>
        public DelegateCommand OKButton { get; }

        private void OKButtonExecute()
        {
            //MessageBox.Show("Saveします");

            //var message = new DialogParameters();
            //message.Add(nameof(MessageBoxViewViewModel.Message), "Saveします");
            //_dialogService.ShowDialog(nameof(MessageBoxView), message, null);
            
            if(_messageService.Question("保存しますか？") == MessageBoxResult.OK)
            {
                _messageService.ShowDialog("Saveしました。");
            }

            var p = new DialogParameters();
            p.Add(nameof(ViewCTextBox), ViewCTextBox);
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK, p));
        }

        public ViewCViewModel(IDialogService dialogService) : this(dialogService, new MessageService())
        {

        }

        public ViewCViewModel(IDialogService dialogService, IMessageService messageService)
        {
            _dialogService = dialogService;
            _messageService = messageService;
            OKButton = new DelegateCommand(OKButtonExecute);
        }

        /// <summary>
        /// この画面を閉じることができるか
        /// </summary>
        /// <returns></returns>
        public bool CanCloseDialog()
        {
            return true;
        }

        /// <summary>
        /// 閉じるときに動作する
        /// </summary>
        public void OnDialogClosed()
        {
        }

        /// <summary>
        /// 画面が開くときに動作する
        /// パラメータを受け取る場合はここで受け取る
        /// </summary>
        /// <param name="parameters"></param>
        public void OnDialogOpened(IDialogParameters parameters)
        {
            ViewCTextBox = parameters.GetValue<string>(nameof(ViewCTextBox));
        }
    }
}
