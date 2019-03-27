using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Exception = System.Exception;

namespace Marende.Web
{
    public partial class DownloadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validationLabel.Visible = false;
        }

        protected void downloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Clear();
                //Response.ContentType = "application/octet-stream";
                Response.AddHeader("Content-Disposition", "attachment; filename=Marende.csv;");
                Response.ContentType = "application/x-unknown";
                //Response.TransmitFile(Server.MapPath("C:/Users/vlado.juric/Downloads/Marende/Marende.csv"));
                Response.TransmitFile(Server.MapPath("~/ADPMarendeCSV/Marende.csv"));
                Response.End();
            }
            catch (Exception ex)
            {
                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
            }
        }
    }
}