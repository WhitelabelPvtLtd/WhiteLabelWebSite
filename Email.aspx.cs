using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Model_Email : System.Web.UI.Page
{
    EmailService es = new EmailService();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    [WebMethod]
    public static string callEmail(string sub, string body)
    {
        EmailService es = new EmailService();
        var result = es.SendEmail(sub, body);
        return result;
    }
}