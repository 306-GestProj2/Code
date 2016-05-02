using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolBoxETML_Dessin
{
    public partial class Text : Form
    {
        public Text()
        {
            InitializeComponent();
        }
        public string ReturnText()
        {
            return richTextBox1.Text;
        }
    }
}
