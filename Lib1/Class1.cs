using System;
using System.Windows.Forms;
using System.Drawing;


//class1
//class2
//class1
//class2
namespace Lib1
{
    public class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            // Здесь можно настроить свойства по умолчанию
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = new Font("Arial", 12);
        }
    }

    public class CustomButton : Button
    {
        public CustomButton()
        {
            // Здесь можно настроить свойства по умолчанию
            this.Text = "uажмите меня";
            this.BackColor = Color.FromArgb(175, 238, 238);
        }
    }

    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            // Здесь можно настроить свойства по умолчанию
            this.Font = new Font("Arial", 10);
            this.AutoSize = true;
            this.ForeColor = Color.DarkBlue;
        }
    }

    public class CustomListBox : ListBox
    {
        public CustomListBox()
        {
            // Здесь можно настроить свойства по умолчанию
            this.SelectionMode = SelectionMode.MultiExtended;
        }
    }
}
