using System.Collections.ObjectModel;

namespace Sample.BottomSheet.CollectionView.ViewModels.Item
{
    public partial class ItemGroupViewModel(string groupName) : ObservableCollection<ItemViewModel>
    {
        public string GroupName { get; } = groupName;
    }
}
