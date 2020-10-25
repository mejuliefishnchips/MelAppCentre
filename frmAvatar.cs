//****************************************************************
// Programmer: Melinda Fischer
// CIT Number: CIT245143
// Date: 25 September 2020
// Software: Microsoft Visual Studio 2019 Community Edition 
// Platform: Microsoft Windows 10 Professional 64-bit 
// Purpose: Assignment2 
// Criteria Shown: Nested Classes
// References: Class notes, stackoverflow, scottlily.com, Microsoft Docs
//**************************************************************** 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelindaFischerAssessment2
{
    public partial class frmAvatar : Form
    {
        private Avatar avatar;
        private Avatar.PersonalInformation personalInfo;
        
        public frmAvatar()
        {
            InitializeComponent();
        }

        private void btnCreateAvatar_Click(object sender, EventArgs e)
        {
            //creating object of the class Avatar
            avatar = new Avatar();

            //creating object of the nested class avatar.PersonalInformation
            personalInfo = new Avatar.PersonalInformation();

            //selecting Avatar
            if (rdbtnDoc.Checked)
                avatar.avatarName = "Doc";
            else if (rdbtnBashful.Checked)
                avatar.avatarName = "Bashful";
            else if (rdbtnGrumpy.Checked)
                avatar.avatarName = "Grumpy";
            else if (rdbtnHappy.Checked)
                avatar.avatarName = "Happy";
            else if (rdbtnSleepy.Checked)
                avatar.avatarName = "Sleepy";
            else if (rdbtnSneezy.Checked)
                avatar.avatarName = "Sneezy";
            else
                avatar.avatarName = "Dopey";

            //validating that all fields have been filled out and age is an integer
            if ((txtName.Text != "") && (txtAge.Text != "") && (Int32.TryParse(txtAge.Text, out var outParse)))
            {
                personalInfo.age = Convert.ToInt32(txtAge.Text);
                personalInfo.name = txtName.Text;

                txtResult.Text = "Success!\nYou are " + avatar.avatarName + ".\nYour name is " + personalInfo.name + " and you are " + personalInfo.age + " years old.";

            }

            else
            {
                //error statement
                txtResult.Text = "Error \nPlease enter in all the fields and use integer for the age field.";
            }
            
        }

        
    }
}
