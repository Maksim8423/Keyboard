using System.Text;

namespace Keyboard
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        bool flag = false, Caps = false;

=======
        
>>>>>>> bb9c3dc0d3ae9ddba25cdc057c192a20d445a0bb
        public Form1()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        public void Input(object sender, EventArgs e)
        {

            if (sender is Button button)
            {
                if (sender == SpaceButton)
                {
                    this.Field.Text += " ";
                    return;
                }
                if (sender == BackspaceButton)
                {
                    if(this.Field.Text.Length == 0)
                    {
                        return;
                    }
                    
                    this.Field.Text = this.Field.Text.Remove(this.Field.Text.Length - 1);
                    return;
                }
                if (sender == EnterButton)
                {
                    this.RichField.Text += this.Field.Text + "\n";
                    this.Field.Text = null;
                    return;
                }
                if (sender == Upper || sender == Upper2)
                {
                    flag = true;
                    return;
                }

                if (sender == CapsLock)
                {
                    if (Caps)
                    {

                        Caps = false;
                        Console.WriteLine("Caps is Off");

                        return;
                    }

                    Caps = true;
                    Console.WriteLine("Caps is On");

                    return;
                }

                if (flag || Caps)
                {
                    this.Field.Text += button.Text.ToUpper();
                    flag = false;
                    return;
                }

                this.Field.Text += button.Text;

            }
=======
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Field.Text = "q";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void Field_TextChanged(object sender, EventArgs e)
        {
            
>>>>>>> bb9c3dc0d3ae9ddba25cdc057c192a20d445a0bb
        }
    }
}