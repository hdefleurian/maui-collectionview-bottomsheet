using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Plugin.Maui.BottomSheet.Navigation;

using Sample.BottomSheet.CollectionView.ViewModels.BottomSheet;

namespace Sample.BottomSheet.CollectionView.ViewModels
{
    public partial class MainPageViewModel(IBottomSheetNavigationService bottomSheetNavigationService) : ObservableObject, INavigationAware
    {
        [ObservableProperty]
        public partial int Counter { get; private set; } = 0;

        [ObservableProperty]
        public partial string CounterText { get; private set; } = "Click me";

        public void OnNavigatedFrom(IBottomSheetNavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(IBottomSheetNavigationParameters parameters)
        {
        }

        [RelayCommand]
        private void Count()
        {
            Counter++;
            CounterText = Counter == 1 ? $"Clicked {Counter} time" : $"Clicked {Counter} times";
        }

        [RelayCommand]
        private async Task OpenBottomSheet()
        {
            await bottomSheetNavigationService.NavigateToAsync<SampleBottomSheetViewModel>("sample");
        }
    }
}
