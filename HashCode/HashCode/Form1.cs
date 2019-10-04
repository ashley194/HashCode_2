using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace HashCode
{
    public partial class Form1 : Form
    {
        bool toolTipShown;
        private object decimalValue;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Frame 1 Title
            label1.Text = "Payment Details";
        }
        private void Enter_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {
            //Frame 2 Title
            label6.Text = "Hash Code";
        }
        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        //Payment Details
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //About Box
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hash Code Tester 1.0: \nWritten by: Richard Hawkins", "About");
        }
        private bool Proceed(string msgText, string msgCaption)
        {
            if(MessageBox.Show(msgText, msgCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) != DialogResult.Yes)
            {
                return false;
            }

            if (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return false;
            }

            return true;
        }

        //Generate Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (Proceed("Have you completed all fields above?", "Generate"))
            {
                //carry out action
            }
        }

         //Compare Button
        private void button2_Click(object sender, EventArgs e)
        {
            if(Proceed("Have you completed all fields above?", "Compare"))
            {
                //carry out action
            }
        }
         private void txtClearAll_Click(object sender, EventArgs e)
         {
            txtRandomString.Text = "";
            txtOriginatorSortCode.Text = "";
            txtRecipientSortCode.Text = "";
            txtPaymentValue.Text = "";
            textBox5.Text = "";
         }

          //Label2 Title
         private void label2_Click(object sender, EventArgs e)
         {
            label2.Text = "BACS Random String";
         }

        //Label3 Title
        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "Originator Sort Code";
        }

        //Label4 Title
        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = "Recipient Sort Code";
        }

        //Label5 Title
        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "Payment Value";
        }

        //MenuStrip > Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Clicking the close icon (top right)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //7 spaces before the text, to conter text on message.
            DialogResult dialog = MessageBox.Show("       Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)              
            {
                e.Cancel = true;
            }
        }
        private void txtPaymentValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //OnlyAllowNumericChars(ref e, new List<char>("."));

            char ch = e.KeyChar;

            if (ch == 46 && txtPaymentValue.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        //Only Allow Numeric Characters
        private void txtRecipientSortCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyAllowNumericChars(ref e);
        }

        //Only Allow Numeric Characters
        private void txtOriginatorSortCode_KeyPress(object sender, KeyPressEventArgs e)
        {
              OnlyAllowNumericChars(ref e);
        }
        //Only Allow Numeric Characters
        private void OnlyAllowNumericChars(ref KeyPressEventArgs e, List<char> extraAllowedCharacters = null)
        {
            // Verify that the pressed key isn't a non-numeric digit
            if (extraAllowedCharacters != null)
            {
                if (extraAllowedCharacters.Contains(e.KeyChar))
                {
                    return;
                }
            }
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

            //Pressing the Clear All button + 5 spaces
            DialogResult dialogResult = MessageBox.Show("     Clear All?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            txtRandomString.Text = "";
            txtOriginatorSortCode.Text = "";
            txtRecipientSortCode.Text = "";
            txtPaymentValue.Text = "";
            textBox5.Text = "";
        }
        private bool ValidControlForToolTip(object sender)
        {
            if (sender is TextBox) return true;

            return false;
        }
        private void HideAToolTip(object sender)
        {
            //Only want to hover on textboxes for now
            if (!ValidControlForToolTip(sender)) return;

            //Only continue if tooltip already shown
            if (!toolTipShown) return;

            TextBox tb = (TextBox)sender;

            toolTip1.Hide(tb);

            toolTip1 = null;

            toolTipShown = false;

        }
        private void ShowAToolTip(object sender)
        {
            //Only want to hover on textboxes for now
            if (!ValidControlForToolTip(sender)) return;

            //Only continue if tooltip not already shown
            if (toolTipShown) return;

            TextBox tb = (TextBox)sender;

            string popupText;

            switch(tb.Name)
            {
                case "txtRandomString":
                    popupText = "Copy & Paste the BACS hash code for your payroll product";
                    break;

                case "txtEmployersSortCode":
                    popupText = "Enter the Employers Bank Sort Code";
                    break;

                case "txtEmployeesSortCode":
                    popupText = "Enter the Employees Bank Sort Code";
                    break;

                case "txtPaymentValue":
                    popupText = "Enter the Employees NET pay";
                    break;

                case "textBox5":
                    popupText = "Copy & Paste the BACS hash code to Compare or click Generate";
                    break;

                default:
                    popupText = "";
                    break;
            }

            //Exit if no text to show
            if (popupText == "") return;

            toolTip1 = new ToolTip();

            toolTip1.Show(popupText, tb);

            toolTipShown = true;
        }
        private void txtRandomString_MouseMove(object sender, MouseEventArgs e)
        {
            ShowAToolTip(sender);
        }
        private void txtRecipientSortCode_MouseMove(object sender, MouseEventArgs e)
        {
            ShowAToolTip(sender);
        }
        private void txtOriginatorSortCode_MouseMove(object sender, MouseEventArgs e)
        {
            ShowAToolTip(sender);
        }
        private void txtPaymentValue_MouseMove(object sender, MouseEventArgs e)
        {
            ShowAToolTip(sender);
        }
        private void textBox5_MouseMove(object sender, MouseEventArgs e)
        {
            ShowAToolTip(sender);
        }
        private void txtPaymentValue_MouseLeave(object sender, EventArgs e)
        {
            HideAToolTip(sender);
        }
        private void txtRandomString_MouseLeave(object sender, EventArgs e)
        {
            HideAToolTip(sender);
        }
        private void txtOriginatorSortCode_MouseLeave(object sender, EventArgs e)
        {
            HideAToolTip(sender);
        }
        private void txtRecipientSortCode_MouseLeave(object sender, EventArgs e)
        {
            HideAToolTip(sender);
        }
        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            HideAToolTip(sender);
        }
        private void txtRandomString_TextChanged(object sender, EventArgs e)
        {
            txtRandomString.ForeColor = Color.Fuchsia;
        }
        private void TxtOriginatorSortCode_TextChanged(object sender, EventArgs e)
        {
            txtOriginatorSortCode.ForeColor = Color.Red;
        }
        private void TxtRecipientSortCode_TextChanged(object sender, EventArgs e)
        {
            txtRecipientSortCode.ForeColor = Color.Blue;
        }
        private void TxtPaymentValue_TextChanged(object sender, EventArgs e)
        {
            txtPaymentValue.ForeColor = Color.Green;
        }
    }
}
public  class SHA256
{
    //int OriginatorSortCode = 112233;
    //int RecipientSortCode = 445566;
    //Double PaymentValue = 3000.01;

   
}

    




}




