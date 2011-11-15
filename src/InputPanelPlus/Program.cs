using System;
using System.Windows.Forms;
using micautLib;

namespace InputPanelPlus
{
    class Program
    {
        static MathInputControl _mipControl;

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _mipControl = new MathInputControlClass();
            _mipControl.EnableExtendedButtons(true);
            _mipControl.EnableAutoGrow(true);
            _mipControl.Close += Application.ExitThread;
            _mipControl.Insert += OnInsert;
            _mipControl.SetCaptionText("Copy Formula to Clipboard");
            _mipControl.Show();

            Application.Run();
        }

        static void OnInsert(string xml)
        {
            var prompt = new FormatPrompt();
            prompt.CenterOn(_mipControl.Position().Center());
            prompt.FormatSelected += fmt => OnFormatSelected(fmt, xml);
            prompt.ShowDialog();
        }

        static void OnFormatSelected(Format format, string xml)
        {
            try
            {
                var text = xml;
                if (format == Format.Latex)
                    text = Util.MathMlToLatex(xml);
                Clipboard.SetData(DataFormats.Text, text);
            }
            catch (Exception e)
            {
                string message = "Could not grab text input:\r\n" + e.Message;
                MessageBox.Show(message);
            }
        }
    }
}