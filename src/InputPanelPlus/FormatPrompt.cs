using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputPanelPlus
{
    public partial class FormatPrompt : Form
    {
        public event Action<Format> FormatSelected; 

        public FormatPrompt()
        {
            InitializeComponent();

            buttonLatex.Click += (a, b) => OnFormatSelected(Format.Latex);
            buttonMathML.Click += (a, b) => OnFormatSelected(Format.MathML);
        }

        private void OnFormatSelected(Format format)
        {
            FormatSelected(format);
            Close();
        }
    }
}
