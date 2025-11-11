using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMe
{
    class Utilities
    {
        public static void MessageBoxWarning(string content)
        {
            MessageBox.Show(content,"Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MessageBoxError(string content)
        {
            MessageBox.Show(content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MessageBoxInfor(string content)
        {
            MessageBox.Show(content, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
