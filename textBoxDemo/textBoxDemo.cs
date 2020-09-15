using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : textBoxDemo.cs
* Author      : Kabrina Brady
* Created     : 8/28/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work
* Description : The program lets the user enter his/her name in a TextBox, and when the user clicks "Read Input",
*               whatever they typed in the "Enter your name" textbox is printed in the textbox below
*               Input:  The user's name (what the user enters in the "Enter your name" field), and button clicks and access keys
*               Output: The user's name (the program prints whatever was entered in the "Enter your name" field)
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or unmodified. I have not given other fellow student(s) access to my program.         
***************************************************************/

namespace textBoxDemo
{
    public partial class textBoxDemoForm : Form
    {
        public textBoxDemoForm()
        {
            InitializeComponent();
        }

        //textBoxDemoForm form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //lblInput label
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        //txtOutput TextBox
        private void TxtOutput_TextChanged(object sender, EventArgs e)
        {
            
        }

        //btnExit button
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //On click, assigns txtOutput.Text to txtEnterName.Text and displays output in txtOutput.Text
        private void BtnReadInput_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtEnterName.Text;
        }

        //Label "You entered"
        private void LblOutput_Click(object sender, EventArgs e)
        {

        }

        //txtEnterName TextBox
        private void TxtEnterName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
