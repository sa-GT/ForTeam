using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForEmpoyee.Alooosh
{
    public partial class aliff : System.Web.UI.Page
    {
       
             // الحدث عند الضغط على زر "Register"
        protected void register1_Click(object sender, EventArgs e)
        {
            // إعادة التوجيه إلى صفحة التسجيل (مثال: WebForm1.aspx)
            Response.Redirect("WebForm1.aspx");
        }

        // الحدث عند الضغط على زر "Login"
        protected void login1_Click(object sender, EventArgs e)
        {
            // إعادة التوجيه إلى صفحة تسجيل الدخول (مثال: Login.aspx)
            Response.Redirect("Login.aspx");
        }
    }
}
    
