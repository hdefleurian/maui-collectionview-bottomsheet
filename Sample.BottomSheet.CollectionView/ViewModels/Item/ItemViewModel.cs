using CommunityToolkit.Mvvm.ComponentModel;

namespace Sample.BottomSheet.CollectionView.ViewModels.Item
{
    public partial class ItemViewModel(string title, bool isSelected) : ObservableObject
    {
        [ObservableProperty]
        public partial string Title { get; set; } = title;

        [ObservableProperty]
        public partial bool IsSelected { get; set; } = isSelected;
    }
}
