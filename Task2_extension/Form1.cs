using System;
using System.Globalization;
using System.Windows.Forms;

namespace Task2_extension
{
    public partial class FormExtension : Form
    {
        private DateTime _inputDate;

        public FormExtension()
        {
            InitializeComponent();
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            richTextBox_output.Text = "";
            try
            {
                _inputDate = Convert.ToDateTime(textBox_Input.Text);
            }
            catch (Exception ex)
            {
                var errorMessage = ex.Message + Environment.NewLine + Environment.NewLine
                                   + ex.StackTrace + Environment.NewLine + Environment.NewLine
                                   + ex.Source + Environment.NewLine
                                   + ex.Data;
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK);
            }
            richTextBox_output.Text = _inputDate.DateTimeToWords();
        }
    }

    internal static class MyExtension
    {
        public static string DateTimeToWords(this DateTime inpt)
        {
            var lastDigit = inpt.DayOfYear % 10;
            var result = "";
            //тут не стал точно придерживаться правил английского - по факту 11 - elevenTH и несколько других случаев, рассмотрел, что
            //заканчивается на 1 - по аналогии с firST
            //заканчивается на 2 - по аналогии с secoND
            // на 3 - как thiRD
            // всё остальное - th
            if (lastDigit == 0 || lastDigit > 3)
                result = "Converted Date: " + inpt.ToString("D", new CultureInfo("en-US")) + " - " + inpt.DayOfYear +
                         "th day of year";
            else
                switch (lastDigit)
                {
                    case 1:
                        result = "Converted Date: " + inpt.ToString("D", new CultureInfo("en-US")) + " - " +
                                 inpt.DayOfYear + "st day of year";
                        break;
                    case 2:
                        result = "Converted Date: " + inpt.ToString("D", new CultureInfo("en-US")) + " - " +
                                 inpt.DayOfYear + "nd day of year";
                        break;
                    case 3:
                        result = "Converted Date: " + inpt.ToString("D", new CultureInfo("en-US")) + " - " +
                                 inpt.DayOfYear + "rd day of year";
                        break;
                }

            return result;
        }
    }
}