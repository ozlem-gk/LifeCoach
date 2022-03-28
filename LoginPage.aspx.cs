using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LifeCoach
{
    public partial class LoginPage : System.Web.UI.Page
    {
        TextBox textBoxmail;
        TextBox textBoxpass;
        Button btn;
        DropDownList drp;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox textBoxmail =(TextBox) exampleInputEmail;
            TextBox textBoxpass = (TextBox) exampleInputPassword;
            Button btn = (Button) ButonGiris;
            DropDownList drp = DropDownList1;




        }

        protected void ButonGiris_Click(object sender, EventArgs e)
        {
            
            if (DropDownList1.SelectedValue == "Kullanıcı")
            {
                Response.Redirect("/Default.aspx");
            }
            else if(DropDownList1.SelectedValue == "Diyetisyen")
            {
                Response.Redirect("/DietitianPage.aspx");
            }

        }
    }
}