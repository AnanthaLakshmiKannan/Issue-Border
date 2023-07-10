namespace BorderIssue;

public partial class MainPage : ContentPage
{
    MainPageViewModel vm = new MainPageViewModel();
    public MainPage()
	{
		InitializeComponent();
        BindingContext = vm;
    }
   

    private void autoSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

        if (e.CurrentSelection[0] is InformationListItem item)
        {
            item.Isvisible = !item.Isvisible;
        }
    }


}


