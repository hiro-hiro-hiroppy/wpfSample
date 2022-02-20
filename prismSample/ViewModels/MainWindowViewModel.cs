using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using prismSample.Views;
using System;

namespace prismSample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;
        private bool _showAEnabled = false;
        public bool ShowAEnabled
        {
            get { return _showAEnabled; }
            set { SetProperty(ref _showAEnabled, value); }
        }

        private string _title = "PrismSample";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _systemDateLabel = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        public string SystemDateLabel
        {
            get { return _systemDateLabel; }
            set { SetProperty(ref _systemDateLabel, value); }
        }

        /// <summary>
        /// 日時更新ボタン
        /// </summary>
        public DelegateCommand SystemDateUpdateButton { get; }

        private void SystemDateUpdateButtonExecute()
        {
            ShowAEnabled = true;
            SystemDateLabel = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        /// <summary>
        /// ViewA表示ボタン
        /// </summary>
        public DelegateCommand ShowViewAButton { get; set; }

        private void ShowViewAButtonExecute()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(ViewA));
        }

        /// <summary>
        /// ViewB表示ボタン
        /// </summary>
        public DelegateCommand ShowViewBButton { get; set; }

        private void ShowViewBButtonExecute()
        {
            var p = new NavigationParameters();
            p.Add(nameof(ViewBViewModel.MyLabel), SystemDateLabel);
            _regionManager.RequestNavigate("ContentRegion", nameof(ViewB), p);
        }

        /// <summary>
        /// ViewC表示ボタン
        /// </summary>
        public DelegateCommand ShowViewCButton { get; set; }

        private void ShowViewCButtonExecute()
        {
            //_dialogService.ShowDialog(nameof(ViewC), null, null);

            var p = new DialogParameters();
            p.Add(nameof(ViewCViewModel.ViewCTextBox), SystemDateLabel);
            _dialogService.ShowDialog(nameof(ViewC), p, ViewCClose);
        }

        private void ViewCClose(IDialogResult dialogResult)
        {
            if(dialogResult.Result == ButtonResult.OK)
            {
                SystemDateLabel = dialogResult.Parameters.GetValue<string>(nameof(ViewCViewModel.ViewCTextBox));
            }
        }

        /// <summary>
        /// ViewD表示ボタン
        /// </summary>
        public DelegateCommand ShowViewDButton { get; set; }

        private void ShowViewDButtonExecute()
        {
            _regionManager.RequestNavigate("ContentRegion", nameof(ViewD));
        }

        public MainWindowViewModel(IRegionManager regionManager, IDialogService dialogService)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;
            SystemDateUpdateButton = new DelegateCommand(SystemDateUpdateButtonExecute);
            //ShowViewAButton = new DelegateCommand(ShowViewAButtonExecute);
            ShowViewAButton = new DelegateCommand(ShowViewAButtonExecute).ObservesCanExecute(() => ShowAEnabled);
            
            ShowViewBButton = new DelegateCommand(ShowViewBButtonExecute);
            ShowViewCButton = new DelegateCommand(ShowViewCButtonExecute);
            ShowViewDButton = new DelegateCommand(ShowViewDButtonExecute);
        }
    }
}
