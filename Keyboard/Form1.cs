using System.Text;

namespace Keyboard
{
    public partial class Form1 : Form
    {
        bool flag = false, Caps = false;

        public Form1()
        {
            InitializeComponent();
        }

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
        }
    }
}