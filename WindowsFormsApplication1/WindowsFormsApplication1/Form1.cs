using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MaterialForm
    {
        // OutcomeBox
        // ThemeDark
        
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.BLACK);
        }

        private void ThemeDark_CheckedChanged(object sender, EventArgs e)
        {
            if (ThemeDark.Checked)
            {
                MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            OutcomeBox.Text += "test" + Environment.NewLine;
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutcomeBox.Text);
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton1.Checked)
                MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Red700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Red700, TextShade.BLACK);
        }



        #region unused
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThemeLight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton2.Checked)
                MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Blue700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Blue700, TextShade.BLACK);
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (materialRadioButton3.Checked)
                MaterialSkinManager.Instance.ColorScheme = new ColorScheme(Primary.Green700, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Green700, TextShade.BLACK);
        }
    }
}
