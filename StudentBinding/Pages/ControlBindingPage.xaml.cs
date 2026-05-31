namespace StudentBinding.Pages;

public partial class ControlBindingPage : ContentPage
{
    public ControlBindingPage()
    {
        InitializeComponent();
    }

    private void OpacityChangeOnClick(object sender, EventArgs e)
    {
        if (botImg.Opacity > 0)
        {
            botImg.Opacity = 0;
        }
        else
        {
            botImg.Opacity = 1;
        }
    }
}
