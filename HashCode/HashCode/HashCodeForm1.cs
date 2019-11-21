using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

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
        //Frame title 1 (in bold)
        PaymentDetails.Text = "Payment Details";

            EnableDisableButtons();
        }
        private void Hash_Code_Click(object sender, EventArgs e)
        {
        //Frame title 2 (in bold)
        Hash_Code.Text = "Hash Code";
        }
        //Payment Details
        private void PaymentDetails_Click(object sender, EventArgs e)
        {

        }
        //About Box
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("       Hash Code Tester 1.0: \n\n               Written by:\n\n           Richard Hawkins", "About");
        }
        //New/Clear All button
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
            HashCodeGenerator hashCodeGenerator = new HashCodeGenerator(txtOriginatorSortCode.Text, txtRecipientSortCode.Text, txtPaymentValue.Text, 
            txtRandomNumber.Text, txtRandomString.Text);

            string output = "" + hashCodeGenerator.GetSHA256();

            txtGeneratedHash.Text = output;

            MessageBox.Show("Hash Code Generated!", "Hash Code Tester", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Compare Button
        private void Compare_Click(object sender, EventArgs e)
        {
            //check if fields are populated correctly
            if (!AllFieldsValid())
            {
                return;
            }
            //All fields valid, time to check if they match
            if (CheckSuccessful())
            {
                
                MessageBox.Show("Hash Codes match!", "Well done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hash Codes do not match!", "Please try again!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
        private bool AllFieldsValid()
        {
            //Build a collection of all the fields you want to validate
            var fields = new (TextBox, string, int)[]
            {
                (txtRandomString, "BACS Random String", 0),
                (txtOriginatorSortCode, "Originator Sort Code", 6),
                (txtRecipientSortCode, "Recipient Sort Code", 6),
                (txtPaymentValue, "Payment Value", 0),
                (txtRandomNumber, "Random Number", 4),
                (txtGeneratedHash, "Hash Code", 0)
            };
            foreach (var field in fields)
            {
                //If any field isn't valid then return false
                if (!FieldValid(field.Item1, field.Item2, field.Item3))
                {
                    return false;
                }
            }
            //All checks passed
            return true;
        }
        private bool FieldValid(TextBox field, string fieldName, int fieldLength = 0)
        {
            //First a check if it's populated at all
            if (field.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to " + fieldName);
                return false;
            }
            //Now check if a specific field length is required that this condition is met
            if (fieldLength > 0)
            {
                if (field.Text.Trim().Length != fieldLength)
                {
                    MessageBox.Show("The " + fieldName + " must be " + fieldLength.ToString() + " digits in length!");
                    return false;
                }
            }
            //All checks passed
            return true;
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
        //Allow the Enter key to move to the next textbox
        private void BACSRandomString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
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
            //7 spaces before the text, to center text.
            DialogResult dialog = MessageBox.Show("       Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void txtPaymentValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //OnlyAllowNumericChars(ref e, new List<char>("."));

            char ch = e.KeyChar;

            if (ch == 45 && ch == 46 && txtPaymentValue.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 46)
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
            //Verify that the pressed key isn't a non-numeric digit
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
            //Pressing the Clear All button + 5 spaces to center text
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

            switch (tb.Name)
            {
                case "txtRandomString":
                    popupText = "Copy & Paste the BACS hash code from your payroll product";
                    break;

                case "txtOriginatorSortCode":
                    popupText = "Enter the Employers Bank Sort Code";
                    break;

                case "txtRecipientSortCode":
                    popupText = "Enter the Employees Bank Sort Code";
                    break;

                case "txtPaymentValue":
                    popupText = "Enter the Employees NET pay";
                    break;

                case "txtRandomNumber":
                    popupText = "Enter the Hash Code";
                    break;

                case "txtGeneratedHash":
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
        private void GeneratedHash_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
        }
        private void txtRandomNumber_TextChanged(object sender, EventArgs e)
        {
            EnableDisableButtons();
            txtRandomNumber.CharacterCasing = CharacterCasing.Upper;
        }
        private void EnableDisableButtons()
        {
            bool enableButtons = true;

            if (!TextBoxPopulated(txtOriginatorSortCode)) enableButtons = false;
            if (!TextBoxPopulated(txtRecipientSortCode)) enableButtons = false;
            if (!TextBoxPopulated(txtPaymentValue)) enableButtons = false;
            if (!TextBoxPopulated(txtRandomNumber)) enableButtons = false;

            Generate.Enabled = enableButtons;

            if (!TextBoxPopulated(txtOriginatorSortCode)) enableButtons = false;
            if (!TextBoxPopulated(txtRecipientSortCode)) enableButtons = false;
            if (!TextBoxPopulated(txtPaymentValue)) enableButtons = false;
            if (!TextBoxPopulated(txtRandomNumber)) enableButtons = false;
            if (!TextBoxPopulated(txtGeneratedHash)) enableButtons = false;

            Compare.Enabled = enableButtons;
        }
        private bool TextBoxPopulated(TextBox textBox)
        {
            if (textBox.Text.Trim() == "")
            {
                return false;
            }
            return true;
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe", @"C:\Users\rhawkins\source\repos\HashCode\Help\HelpFile.pdf");
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pressing the Clear All button + 5 spaces to center text
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
    }
}