namespace MonkeyFinder.ViewModel;

[QueryProperty(nameof(Monkey), "Monkeys")]
public partial class MonkeyDetailsViewModel : BaseViewModel
{

    public MonkeyDetailsViewModel()
    {

    }

    [ObservableProperty]
    Monkey monkey;
}
