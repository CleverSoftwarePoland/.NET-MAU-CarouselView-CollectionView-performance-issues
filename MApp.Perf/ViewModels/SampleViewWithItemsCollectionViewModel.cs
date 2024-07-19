using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace MApp.Perf.ViewModels
{
    public partial class DateSampleInfo : ObservableObject
    {
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _alias;

        [ObservableProperty]
        private string _image;
    }

    public partial class SampleViewWithItemsCollectionViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<DateSampleInfo> _collection;

        public SampleViewWithItemsCollectionViewModel()
        {
            _collection = new ObservableCollection<DateSampleInfo>();

            for (int i = 0; i < 20; i++)
            {
                _collection.Add(new DateSampleInfo { Name = string.Format("{0} {1}", "ABC", i.ToString()), Alias = string.Format("{0} {1}", "BCD", i.ToString()) });

            }
        }
    }
}
