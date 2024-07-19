using MApp.Perf.ViewModels;

namespace MApp.Perf.Controls
{
    public class TabsDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Tab1Template { get; set; }
        public DataTemplate Tab2Template { get; set; }
        public DataTemplate Tab3Template { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            if (item is SampleViewWithTileViewModel)
                return Tab1Template;

            if (item is SampleViewWithItemsCollectionViewModel)
                return Tab2Template;


            return Tab2Template;
        }
    }
}
