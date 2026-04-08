using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using Plugin.Maui.BottomSheet.Navigation;

using Sample.BottomSheet.CollectionView.ViewModels.Item;

namespace Sample.BottomSheet.CollectionView.ViewModels.BottomSheet
{
    public partial class SampleBottomSheetViewModel : ObservableObject, INavigationAware
    {
        [ObservableProperty]
        private ItemViewModel? _selectedItem;

        public ObservableCollection<ItemGroupViewModel> Groups { get; } = [];

        /// <summary>
        /// Called when navigating away from this view model.
        /// </summary>
        /// <param name="parameters">The navigation parameters used during the operation.</param>
        public void OnNavigatedFrom(IBottomSheetNavigationParameters parameters)
        {
        }

        /// <summary>
        /// Called when this view model has been navigated to.
        /// </summary>
        /// <param name="parameters">The navigation parameters.</param>
        public void OnNavigatedTo(IBottomSheetNavigationParameters parameters)
        {
            var group = new ItemGroupViewModel("Section 1")
            {
                new ItemViewModel("Item 1", false),
                new ItemViewModel("Item 2", false),
                new ItemViewModel("Item 3", true)
            };
            Groups.Add(group);

            SelectedItem = group.FirstOrDefault(x => x.IsSelected);
        }
    }
}
