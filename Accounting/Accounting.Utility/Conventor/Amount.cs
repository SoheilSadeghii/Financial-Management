using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Utility.Conventor
{
    public static class Amount
    {
        public static void ToRial(this NumericUpDown numericUpDown)
        {
            // Temporarily store the current value
            decimal value = numericUpDown.Value;

            // Set the thousands separator format
            numericUpDown.ThousandsSeparator = true;

            // Update the value to trigger the formatting
            numericUpDown.Value = value;
        }
    }
}
