using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace biblioteca
{
    public class TextBoxColoreado : TextBox
    {
        public new bool ReadOnly
        {
            get
            {
                return base.ReadOnly;
            }

            set
            {
                if (value == true)
                {
                    base.BackColor = Color.FromKnownColor(KnownColor.Red);
                }
                else if (value == false)
                {
                    base.BackColor = Color.FromKnownColor(KnownColor.Window);
                }
                base.ReadOnly = value;
            }
        }

    }
}
