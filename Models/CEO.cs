using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeMadrid.Models
{
    public class CEO
    {
        public string Name { get; set; }
        public PictureBox Image { get; set; }
        public string Birth { get; set; }
        public string Hometown { get; set; }

        public CEO(string name, PictureBox image, string birth, string hometown)
        {
            Name = name;
            Image = image;
            Birth = birth;
            Hometown = hometown;
        }

        public CEO() { } // constructor rỗng phòng trường hợp cần
    }
}

