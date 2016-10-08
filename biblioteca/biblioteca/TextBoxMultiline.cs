using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public class TextBoxMultiline : TextBox
    {
        public override bool Multiline
        {
            get
            {
                return base.Multiline;
            }

            set
            {
                if (value == true)
                {
                    base.Height = base.Height * 2;
                }
                else if(value == false)
                {
                    base.Height = base.Height / 2;
                }
                base.Multiline = value;
            }
        }
    }
}
