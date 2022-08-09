using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                var fName = FirstNameTextBox.Text.Trim();
                var lName = LastNameTextBox.Text.Trim();
                var mail = EmailTextBox.Text.Trim();
                var date = BirthdayTextBox.Text.Trim();
                var gender = GenderDropDownList.SelectedValue;

                OutputLabel.Text = $"{fName} {lName} your mail is :{mail} you where born on: {date} and you are a unique {gender}.";
            }
            
        }
    }
}