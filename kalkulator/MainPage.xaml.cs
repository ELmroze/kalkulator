namespace kalkulator
{
    public partial class MainPage : ContentPage
    {
        string a, usuwanie;
        float c, b, d;
        char znak;
        public MainPage()
        {
            InitializeComponent();
        }

        private void CE(object sender, EventArgs e)
        {
            a = "";
            b = 0;
            wynik.Text = "";
        }

        private void back_delete(object sender, EventArgs e)
        {
            usuwanie = wynik.Text;
            wynik.Text = usuwanie.Remove(wynik.Text.Length-1,1);
        }

        private void dzielenie(object sender, EventArgs e)
        {
            a = wynik.Text;
            wynik.Text = "";
            znak = '/';
        }

        private void modulo(object sender, EventArgs e)
        {
            a = wynik.Text;
            wynik.Text = "";
            znak = '%';
        }

        private void pierwiastek(object sender, EventArgs e)
        {
            c = (float)Math.Sqrt(float.Parse(wynik.Text));
            wynik.Text = c.ToString();
            a = wynik.Text;
        }

        private void potega(object sender, EventArgs e)
        {
            c = (float)Math.Pow(float.Parse(wynik.Text), 2);
            wynik.Text = c.ToString();
            a = wynik.Text;
        }

        private void mnozenie(object sender, EventArgs e)
        {
            a = wynik.Text;
            wynik.Text = "";
            znak = '*';
        }

        private void liczba(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            wynik.Text += button.Text;
        }

        private void odejjmowanie(object sender, EventArgs e)
        {
            a = wynik.Text;
            wynik.Text = "";
            znak = '-';
        }

        private void dodawanie(object sender, EventArgs e)
        {
            a = wynik.Text;
            wynik.Text = "";
            znak = '+';
        }

        private void zmianaZnaku(object sender, EventArgs e)
        {
            c = float.Parse(wynik.Text);
            c = c * -1;
            wynik.Text = c.ToString();
        }

        private void rownaSie(object sender, EventArgs e)
        {
            switch (znak)
            {
                case '+':
                    b = float.Parse(a);
                    d = float.Parse(wynik.Text);
                    c = b + d;
                    wynik.Text = c.ToString();
                    break;
                case '-':
                    b = float.Parse(a);
                    d = float.Parse(wynik.Text);
                    c = b - d;
                    wynik.Text = c.ToString();
                    break;
                case '*':
                    b = float.Parse(a);
                    d = float.Parse(wynik.Text);
                    c = b * d;
                    wynik.Text = c.ToString();
                    break;
                case '/':
                    b = float.Parse(a);
                    d = float.Parse(wynik.Text);
                    c = b / d;
                    wynik.Text = c.ToString();
                    break;
                case '%':
                    b = float.Parse(a);
                    d = float.Parse(wynik.Text);
                    c = (b * d) / 100;
                    wynik.Text = c.ToString();
                    break;
            }
        }
    }

}
