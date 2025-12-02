namespace TipCalculator;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        Title = "Tip Calculator";
    }

    private bool TryGetBillAmount(out double billAmount)
    {
        return double.TryParse(txtBillAmount.Text, out billAmount);
    }

    private void Fifteen_OnClicked(object sender, EventArgs e)
    {
        if (TryGetBillAmount(out double bill))
        {
            lblDisplay.Text = $"15% Tip: {(bill * 0.15):C}";
        }
        else
        {
            lblDisplay.Text = "Please enter a valid bill amount.";
        }
    }

    private void Twenty_OnClicked(object sender, EventArgs e)
    {
        if (TryGetBillAmount(out double bill))
        {
            lblDisplay.Text = $"20% Tip: {(bill * 0.20):C}";
        }
        else
        {
            lblDisplay.Text = "Please enter a valid bill amount.";
        }
    }

    private void TwentyFive_OnClicked(object sender, EventArgs e)
    {
        if (TryGetBillAmount(out double bill))
        {
            lblDisplay.Text = $"25% Tip: {(bill * 0.25):C}";
        }
        else
        {
            lblDisplay.Text = "Please enter a valid bill amount.";
        }
    }
}