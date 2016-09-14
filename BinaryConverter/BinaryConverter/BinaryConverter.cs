using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverter
{
    public partial class BinaryConvterForm : Form
    {
        public BinaryConvterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// validates the form ensuring only digits 1 or 0 are fed to converter
        /// </summary>
        private void ValidateBin()
        {
            //access text box and verify that all chars are digits and 0 or 1
            var text = binBox.Text;
            var isDigits = text.All(char.IsDigit);
            var flag = text.All(c => c == '0' || c == '1');

            //test if text box is empty
            if (binBox.Text.Length == 0)
            {
                binInputError.Clear();
                convertToBin.Enabled = false;
                errMsg.Visible = false;
                return;
            }
            //if all chars are correct return clear error and enable button
            if (isDigits && flag)
            {
                binInputError.Clear();
                convertToBin.Enabled = true;
                errMsg.Visible = false;
                return;
            }
            //set error and disable button
            binInputError.SetError(binBox, "only int values 1 and 0 are allowed");
            errMsg.Text = @"only int values 1 and 0 are allowed";
            errMsg.Visible = true;
            convertToBin.Enabled = false;
            return;
        }

        //on text change run validiation
        //TODO: setup validation to make sure no garbage in
        private void binBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBin();
        }

        //Convert binary into int
        private void convertToBin_Click(object sender, EventArgs e)
        {
            //realInt holds toltal bin is input from text box
            var bin = Convert.ToInt32(binBox.Text);
            var realInt = 0;
            //for all digits mult by power of 2 and add to total inc bin
            for (var i = 0; i < binBox.Text.Length;i++)
            {
                realInt = realInt + (bin % 10 * (Convert.ToInt32(Math.Pow(2, i))));
                bin = bin/10;
            }
            binResult.Text = Convert.ToString(realInt);
        }
    }
}
