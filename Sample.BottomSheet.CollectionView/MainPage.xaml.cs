using Sample.BottomSheet.CollectionView.ViewModels;

namespace Sample.BottomSheet.CollectionView
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
