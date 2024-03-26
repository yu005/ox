using System.Windows.Forms;

namespace ox 
{
    public partial class Form1 : Form
    {
        string playermMarker = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //避免下第二次
            Button button = (Button)sender;
            button.Text = playermMarker;
            playermMarker = playermMarker == "X" ? "O" : "X";
            label2.Text = playermMarker;
            //
            checkWinner();
        }

        private void checkWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text == playermMarker)
            {
                MessageBox.Show(button1.Text, "Winner is...");
                return;
            }
            else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text == playermMarker)
            {
                MessageBox.Show(button4.Text, "Winner is...");
                return;
            }
            else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text == playermMarker)
            {
                MessageBox.Show(button7.Text, "Winner is...");
                return;
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text == playermMarker)
            {
                MessageBox.Show(button1.Text, "Winner is...");
                return;
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text == playermMarker)
            {
                MessageBox.Show(button3.Text, "Winner is...");
                return;
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text == playermMarker)
            {
                MessageBox.Show(button2.Text, "Winner is...");
                return;
            }
            else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text == playermMarker)
            {
                MessageBox.Show(button1.Text, "Winner is...");
                return;
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text == playermMarker)
            {
                MessageBox.Show(button3.Text, "Winner is...");
                return;

            }
            
        }
        //private void SomeEventTrigger_Click(object sender, EventArgs e)
        //{
        //    checkWinner();
        //}





    }
}