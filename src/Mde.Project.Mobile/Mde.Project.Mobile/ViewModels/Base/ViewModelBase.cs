using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mde.Project.Mobile.ViewModels
{
    public class ViewModelBase : BaseViewModel
    {
        public AsyncCommand RefreshCommand { get; }

        public ViewModelBase()
        {
            RefreshCommand = new AsyncCommand(GetData);
        }
        public virtual async Task GetData()
        {
#if DEBUG
            await Task.Delay(1000);
#endif
        }
    }
}
