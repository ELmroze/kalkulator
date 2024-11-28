namespace kalkulator;

public partial class NewPage1 : ContentPage
{
	float a=0, b;
	public NewPage1()
	{
		InitializeComponent();
        ZPLN.IsChecked = true;
        DoDolary.IsChecked = true;

    }

    private void waluty(object sender, CheckedChangedEventArgs e)
    {
        if (ZPLN == null || ZDolary == null || ZEURO == null || DoDolary == null || DoEURO == null|| DoPLN == null)
            return;
        if (ZPLN.IsChecked==true && DoDolary.IsChecked == true)
        {
            b=a* 0.25f;
        }
        if (ZPLN.IsChecked && DoEURO.IsChecked)
        {
            b = a * 0.23f;
        }
        if (ZDolary.IsChecked && DoPLN.IsChecked)
        {
            b = a * 4.08f;
        }
        if (ZDolary.IsChecked && DoEURO.IsChecked)
        {
            b = a * 0.95f;
        }
        if (ZEURO.IsChecked && DoDolary.IsChecked)
        {
            b = a * 1.06f;
        }
        if (ZEURO.IsChecked && DoPLN.IsChecked)
        {
            b = a * 4.31f;
        }
        walut2.Text = b.ToString();
        
    }

    private void pieniadze(object sender, ValueChangedEventArgs e)
    {
		a = (float)e.NewValue;
        walut1.Text=a.ToString();
    }
}