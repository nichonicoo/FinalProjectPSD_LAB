using FinalProjectPSD_LAB.Model;
using FinalProjectPSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProjectPSD_LAB.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Login_Button_Click(object sender, EventArgs e)
        {
            string username = txt_name.Text;
            string userpassword = txt_password.Text;

            User user = UserRepository.FindByName(username);

            if (username != null && user.UserPassword == userpassword)
            {
                Response.Redirect("ViewMakeup.aspx");
            }
            else
            {
                lbl_error.Text = "Invalid Credentials";
            }
        }
        protected void Register_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}