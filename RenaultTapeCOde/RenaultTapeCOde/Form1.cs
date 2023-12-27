using System.Text.RegularExpressions;

namespace RenaultTapeCOde
{

    public partial class Form1 : Form
    {
        private Size screenSize;

        Regex _filterRegexPatternChar = new Regex(@"^[a-zA-Z]*$");
        Regex _filterRegexPatternNum = new Regex(@"^[0-9]*$");

        public Form1()
        {

            InitializeComponent();
            screenSize = new Size(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height);
           // MessageBox.Show(screenSize.Width.ToString() + ",," + screenSize.Height.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Left = screenSize.Width / 2 - txt1.Size.Width / 2 - 99;
            txt1.Top = screenSize.Height / 2 - txt1.Size.Height / 2;
            txt2.Left = screenSize.Width / 2 - txt2.Size.Width / 2 - 33;
            txt2.Top = screenSize.Height / 2 - txt2.Size.Height / 2;
            txt3.Left = screenSize.Width / 2 - txt3.Size.Width / 2 + 33;
            txt3.Top = screenSize.Height / 2 - txt3.Size.Height / 2;
            txt4.Left = screenSize.Width / 2 - txt4.Size.Width / 2 + 99;
            txt4.Top = screenSize.Height / 2 - txt4.Size.Height / 2;
            btnGO.Left = screenSize.Width / 2 - btnGO.Size.Width / 2;
            btnGO.Top = screenSize.Height / 2 + btnGO.Size.Height / 2;

            txt1.Focus();

        }

        public static string Hesapla(char a, int b, int c, int d)
        {
            int sol = (a - 'A') * 10 + b;
            int sag = ((sol + c * 10 + d) * 7) % 100;
            return ((259 % Math.Abs(sol)) % 100).ToString().PadLeft(2, '0') + (sag % 10) + (sag / 10).ToString();
        }

        private void btnGO_Click(object sender, EventArgs e)

        {
            if(txt1.Text !="" && txt2.Text !=""&&txt3.Text!=""&&txt4.Text!= "")
            {
                string i = Hesapla(txt1.Text.ElementAt(0), int.Parse(txt2.Text), int.Parse(txt3.Text), int.Parse(txt4.Text));
                MessageBox.Show("Girilen: " + txt1.Text.ElementAt(0) + txt2.Text + txt3.Text + txt4.Text + "\n" + "Çözülen: " + i);
                txt1.Text = string.Empty; txt2.Text = string.Empty;
                txt3.Text = string.Empty; txt4.Text = string.Empty;
                txt1.Focus();
            }

        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt1.Text))
            {
                if (!_filterRegexPatternChar.IsMatch(txt1.Text)) txt1.Text = string.Empty;
                else if (txt1.Text.Length == 1)
                {
                    txt2.Focus();
                }
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt2.Text))
            {
                if (!_filterRegexPatternNum.IsMatch(txt2.Text)) txt2.Text = string.Empty;
                else if (txt2.Text.Length == 1)
                {
                    txt3.Focus();
                }
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt3.Text))
            {
                if (!_filterRegexPatternNum.IsMatch(txt3.Text)) txt3.Text = string.Empty;
                else if (txt3.Text.Length == 1)
                {
                    txt4.Focus();
                }
            }
            
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt4.Text))
            {
                if (!_filterRegexPatternNum.IsMatch(txt4.Text)) txt4.Text = string.Empty;
                else if (txt4.Text.Length == 1)
                {
                    btnGO.Focus();
                }
            }
            
        }

      
    }
}
