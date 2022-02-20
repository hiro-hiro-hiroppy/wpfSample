using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using prismSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace prismSample.ViewModels
{
    public class ViewBViewModel : BindableBase, IConfirmNavigationRequest
    {
        IMessageService _messageService;

        private string _myLabel = string.Empty;
        public string MyLabel
        {
            get { return _myLabel; }
            set { SetProperty(ref _myLabel, value); }
        }

        public ViewBViewModel() : this(new MessageService())
        {

        }

        public ViewBViewModel(IMessageService messageService)
        {
            _messageService = messageService;
        }

        /// <summary>
        /// ナビゲーションが移ってきた時に実行される
        /// パラメータを受け取りたい場合は、ここでnavigationContextより取得できる
        /// </summary>
        /// <param name="navigationContext"></param>
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
            MyLabel = navigationContext.Parameters.GetValue<string>(nameof(MyLabel));
        }

        /// <summary>
        /// インスタンスを使いまわすかどうか、使いまわすときはTrue
        /// ナビゲーション方式で画面を表示したり非表示にしたりする場合に
        /// 前回の値を覚えておく必要がある場合はTrue、毎回新しく生まれてほしい場合はFalse
        /// </summary>
        /// <param name="navigationContext"></param>
        /// <returns></returns>
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
            return false;
        }

        /// <summary>
        /// ナビゲーションが他に移る時に実行される
        /// 終了処理がある場合などはここに記述する
        /// </summary>
        /// <param name="navigationContext"></param>
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            if(_messageService.Question("保存せずとじますか？") == System.Windows.MessageBoxResult.OK)
            {
                continuationCallback(true);
            }
        }
    }
}
