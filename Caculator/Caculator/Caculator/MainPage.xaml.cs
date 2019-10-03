using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Caculator
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer

    public partial class MainPage : ContentPage
    {
        string ResultTemp;
        int flagPoint = 0;
        string Operator;
        public MainPage()
        {
            InitializeComponent();
            ResultTemp = Result.Text;
        }
        private void Cmd7_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "7";
            }
            if (Operator == "+")
            {

            }
            Result.Text = ResultTemp;
        }

        private void Cmd8_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "8";
            }

            Result.Text = ResultTemp;
        }

        private void Cmd9_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "9";
            }

            Result.Text = ResultTemp;
        }

        private void Cmd4_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "4";
            }

            Result.Text = ResultTemp;
        }

        private void Cmd5_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "5";
            }

            Result.Text = ResultTemp;
        }

        private void Cmd6_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "6";
            }

            Result.Text = ResultTemp;
        }

        private void Cmd1_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "1";
            }

            Result.Text = ResultTemp;
        }

        private void Cmd2_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "2";
            }

            Result.Text = ResultTemp;
        }

        private void Cmd3_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "3";
            }

            Result.Text = ResultTemp;
        }

        private void Cmd0_Clicked(object sender, EventArgs e)
        {
            if (Result.Text == "0")
            {
                ResultTemp = "";
            }
            if (ResultTemp.Length < 13)
            {
                ResultTemp += "0";
            }

            Result.Text = ResultTemp;
        }

        private void CmdPoint_Clicked(object sender, EventArgs e)
        {
            if (flagPoint == 0)
            {
                ResultTemp += ".";
                flagPoint = 1;
            }
            Result.Text = ResultTemp;
        }

        private void CmdC_Clicked(object sender, EventArgs e)
        {
            ResultTemp = "0";
            Result.Text = "0";
            flagPoint = 0;
        }

        private void CmdX_Clicked(object sender, EventArgs e)
        {
            Operator = "*";
        }

        private void CmdSub_Clicked(object sender, EventArgs e)
        {
            Operator = "-";
        }

        private void CmdAdd_Clicked(object sender, EventArgs e)
        {
            Operator = "+";
            Result.Text = "";
        }
    }
}
