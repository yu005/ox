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


        private void checkWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                MessageBox.Show(button1.Text, "Winner is...");
            }
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


    }
}