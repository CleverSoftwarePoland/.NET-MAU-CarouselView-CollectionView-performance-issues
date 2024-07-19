using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MApp.Perf.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title;

        private SampleViewWithTileViewModel _sampleViewWithTile;

        private SampleViewWithItemsCollectionViewModel _sampleViewWithItemsCollectionViewModel;

        private ObservableCollection<ObservableObject> _collection;

        public ObservableCollection<ObservableObject> Collection
        {
            get
            {
                if (_collection == null)
                {
                    _collection = new ObservableCollection<ObservableObject>();
                    _collection.Add(_sampleViewWithTile);
                    _collection.Add(_sampleViewWithItemsCollectionViewModel);
                }

                return _collection;
            }
        }


        public MainViewModel()
        {
            _sampleViewWithTile = new SampleViewWithTileViewModel();
            _sampleViewWithItemsCollectionViewModel = new SampleViewWithItemsCollectionViewModel();
        }


    }
}
