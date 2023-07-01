namespace DotnetServiceRunner.Pages;

public partial class About : ContentPage
{
  public About()
  {
    InitializeComponent();
  }

  private void LearnMore_Clicked(object sender, EventArgs e)
  {
    DisplayAlert("Alert", "Button clicked!", "Ok");
  }
}