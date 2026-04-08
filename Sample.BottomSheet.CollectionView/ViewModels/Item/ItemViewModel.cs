using CommunityToolkit.Mvvm.ComponentModel;

namespace Sample.BottomSheet.CollectionView.ViewModels.Item
{
    public partial class ItemViewModel(int id, string title, bool isSelected) : ObservableObject
    {
        public int Id { get; } = id;

        [ObservableProperty]
        public partial string Title { get; set; } = title;

        [ObservableProperty]
        public partial bool IsSelected { get; set; } = isSelected;
    }
}
