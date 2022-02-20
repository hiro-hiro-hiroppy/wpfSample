using Moq;
using Prism.Services.Dialogs;
using prismSample.Services;
using prismSample.ViewModels;
using System;
using Xunit;

namespace prismSampleTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dialogServiceMock = new Mock<IDialogService>();
            var messageServiceMock = new Mock<IMessageService>();
            var vm = new ViewCViewModel(dialogServiceMock.Object, messageServiceMock.Object);
            vm.OKButton.Execute();
        }
    }
}
