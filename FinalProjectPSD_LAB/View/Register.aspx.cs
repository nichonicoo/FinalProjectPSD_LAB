using FinalProjectPSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD_LAB.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_Button_Click(object sender, EventArgs e)
        {
            if (UserRepository.FindByName(txt_name.Text) == null)
            {
                string name = txt_name.Text;
                string email = txt_email.Text;
                string gender = radio_gender.SelectedValue;
                string dob = txt_dob.Text;
                string password = txt_password.Text;
                string role = "Customer";
                UserRepository.CreateUser(name, email, gender, dob, password, role); 
            }
        }
        protected void Login_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}