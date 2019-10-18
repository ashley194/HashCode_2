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
using System.Globalization;

namespace HashCode
{
    public partial class HashCodeForm1 : Form
    {
        bool toolTipShown;
        public HashCodeForm1()
        {
            InitializeComponent();
        }
        private void HashCodeForm1_Load(object sender, EventArgs e)
        {
            //Frame title 1
            PaymentDetails.Text = "Payment Details";

            EnableDisableButtons();
        }
        private void Enter_Click(object sender, EventArgs e)
        {

        }
        private void Hash_Code_Click(object sender, EventArgs e)
        {
            //Frame title 2
            Hash_Code.Text = "Hash Code";
        }
        private void Advice_Click(object sender, EventArgs e)
        {
            
        }
        //Payment Details
        private void PaymentDetails_Click(object sender, EventArgs e)
        {

        }
        //About Box
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hash Code Tester 1.0: \n\nWritten by:\n\nRichard Hawkins", "About");
        }
        private bool Proceed(string msgText, string msgCaption)
        {
            if (MessageBox.Show(msgText, msgCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) != DialogResult.Yes)
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
        private void Generate_Click(object sender, EventArgs e)
        {
            HashCodeGenerator hashCodeGenerator = new HashCodeGenerator(txtOriginatorSortCode.Text, txtRecipientSortCode.Text, txtPaymentValue.Text, txtRandomString.Text);

            string output = "" + hashCodeGenerator.GetSHA256();

            txtGeneratedHash.Text = output;
        }
        //Compare Button
        private void Compare_Click(object sender, EventArgs e)
        {
            if (!CheckSuccessful())
            {
                MessageBox.Show("Correctly enter the required fields!", "Please try Again", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            if (CheckSuccessful())
            {
                MessageBox.Show("Hash do not Codes match!", "Please try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hash Codes match!", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        //Check if both Hash Codes agree
        private bool CheckSuccessful()
        {
            if (txtRandomString.Text == txtGeneratedHash.Text)

                return true;

            else

                return false;
        }
        //Clear All button
        private void txtClearAll_Click(object sender, EventArgs e)
         {
            txtRandomString.Text = string.Empty;
            txtOriginatorSortCode.Text = string.Empty;
            txtRecipientSortCode.Text = string.Empty;
            txtPaymentValue.Text = string.Empty;
            txtRandomNumber.Text = string.Empty;
            txtGeneratedHash.Text = string.Empty;
        }
        //BACSRandomString textBox
        private void BACSRandomString_Click(object sender, EventArgs e)
         {
            BACSRandomString.Text = "BACS Random String";
         }
        //Originator textBox
        private void Originator_Click(object sender, EventArgs e)
        {
            Originator.Text = "Originator Sort Code";
        }
        //Recipient textBox
        private void Recipient_Click(object sender, EventArgs e)
        {
            Recipient.Text = "Recipient Sort Code";
        }
        //PaymentValue textBox
        private void PaymentValue_Click(object sender, EventArgs e)
        {
            PaymentValue.Text = "Payment Value";
        }
        //MenuStrip > Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        //Clicking the close icon (top right)
        private void HashCodeForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //7 spaces before the text, to center text on message.
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
        private void ClearAll_Click(object sender, EventArgs e)
        {
            //Pressing the Clear All button + 5 spaces
            DialogResult dialogResult = MessageBox.Show("     Clear All?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            txtRandomString.Text = string.Empty;
            txtOriginatorSortCode.Text = string.Empty;
            txtRecipientSortCode.Text = string.Empty;
            txtPaymentValue.Text = string.Empty;
            txtRandomNumber.Text = string.Empty;
            txtGeneratedHash.Text = string.Empty;
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

                case "txtRandomNumber":
                    popupText = "Enter the Hash Code";
                    break;

                case "GeneratedHash":
                    popupText = "Copy & Paste the 'BACS Hash Code' to Compare or click Generate";
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

        private void txtRandomNumber_MouseMove(object sender, MouseEventArgs e)
        {
            ShowAToolTip(sender);
        }
        private void GeneratedHash_MouseMove(object sender, MouseEventArgs e)
        {
            ShowAToolTip(sender);
        }
        private void txtRandomNumber_MouseLeave(object sender, MouseEventArgs e)
        {
            HideAToolTip(sender);
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
        private void GeneratedHash_MouseLeave(object sender, EventArgs e)
        {
            HideAToolTip(sender);
        }
        private void txtRandomString_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }
        private void TxtOriginatorSortCode_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }
        private void TxtRecipientSortCode_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }
        private void TxtPaymentValue_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }
        private void TxtRandomNumber_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }
        private void EnableDisableButtons()
        {
            bool enableButtons = true;

            if (!TextBoxPopulated(txtRandomString))         enableButtons = false;
            if (!TextBoxPopulated(txtOriginatorSortCode))   enableButtons = false;
            if (!TextBoxPopulated(txtRecipientSortCode))    enableButtons = false;
            if (!TextBoxPopulated(txtPaymentValue))         enableButtons = false;
            //if (!TextBoxPopulated(txtRandomNumber))         enableButtons = false;

            Generate.Enabled = enableButtons;
        }
        private bool TextBoxPopulated(TextBox textBox)
        {
            if (textBox.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        private void GeneratedHash_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtRandomNumber_TextChanged(object sender, EventArgs e)
        {
            txtRandomNumber.CharacterCasing = CharacterCasing.Upper;
        }
    }
}