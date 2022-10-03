namespace MyResume;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        CollectionViewSkills.ItemsSource = new List<SkillItem>
        {
            new SkillItem{Image="aspnet.png"},
            new SkillItem{Image="csharpsvgrepocom.png"},
            new SkillItem{Image="reactsvgrepocom.png"},
            new SkillItem{Image="jssvgrepocom.png"},
            new SkillItem{Image="pysvgrepocom.png"},
            new SkillItem{Image="moresvgrepocom.png"}
        };
    }

    class SkillItem
    {
        public string Image { get; set; }
    }
	 

	private async void GitHubButton_Clicked(object sender, EventArgs e)
	{
        try
        {
            Uri uri = new Uri("https://github.com/MetiKh2?tab=repositories");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
        }
    }

    private async void EmailButton_Clicked(object sender, EventArgs e)
    {
        await Clipboard.Default.SetTextAsync("meti.kh4@gmail.com");
        await DisplayAlert("پیغام", "ایمیل کپی شد", "حله");
    }

    private async void PhoneButton_Clicked(object sender, EventArgs e)
    {
        await Clipboard.Default.SetTextAsync("09101541969");
        await DisplayAlert("پیغام", "شماره تلفن کپی شد", "حله");

    }
}

