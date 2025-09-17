namespace TipCalculator;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        Title = "Tip Calculator";
    }

    private void Multiply_OnClicked(object sender, EventArgs e)
    {
        double dblFifteen, dblTwenty, dblTwentyFive;
        Double.TryParse(txtFifteenPercent.Text, out dblFifteen);
        Double.TryParse(txtTwentyPercent.Text, out dblTwenty);
        Double.TryParse(txtTwentyFivePercent.Text, out dblTwentyFive);

        lblDisplay.Text = dblFifteen("bill amount").ToString();
        lblDisplay.Text = dblTwenty("bill amount").ToString();
    }

  
}