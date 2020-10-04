using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xephinh
{
    class PtB:PictureBox
    {
        int index = 0;
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        int imageID = 0;
        public int ImageID
        {
            get { return imageID; }
            set { imageID = value; }
        }
        public bool isMath()
        {
            return (index == imageID);
        }
    }
}
