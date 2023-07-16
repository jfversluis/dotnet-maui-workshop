namespace MonkeyFinder.ViewModel;

[QueryProperty(nameof(Monkey), "Monkeye")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{

    public MonkeyDetailsViewModel()
    {

    }

    [ObservableProperty]
    Monkey monkey;
}
