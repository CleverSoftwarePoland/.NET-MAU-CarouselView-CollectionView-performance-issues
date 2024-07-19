using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MApp.Perf.ViewModels
{
    public partial class SampleViewWithTileViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title;

        public SampleViewWithTileViewModel()
        {
            _title = "Sample Binding Title View";
        }
    }
}
