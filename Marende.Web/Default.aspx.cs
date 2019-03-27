using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marende.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataValidationLabel.Visible = false;
        }

        protected void rizzoButton_Click(object sender, EventArgs e)
        {
            try
            {
                sendvicRizzoButton.Visible = true;
                salataButton.Visible = true;
                sendvicButton.Visible = false;
                pizzaButton.Visible = false;
            }
            catch (Exception ex)
            {
                dataValidationLabel.Text = ex.Message;
                dataValidationLabel.Visible = true;
            }
        }

        protected void ostaliButton_Click(object sender, EventArgs e)
        {
            try
            {
                sendvicButton.Visible = true;
                pizzaButton.Visible = true;
                sendvicRizzoButton.Visible = false;
                salataButton.Visible = false;
            }
            catch (Exception ex)
            {
                dataValidationLabel.Text = ex.Message;
                dataValidationLabel.Visible = true;
            }
        }

        protected void rizzoIzbor_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("RizzoOrders.aspx");
            }
            catch (Exception ex)
            {
                dataValidationLabel.Text = ex.Message;
                dataValidationLabel.Visible = true;
            }
        }

        protected void ostaliIzbor_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("Orders.aspx");
            }
            catch (Exception ex)
            {
                dataValidationLabel.Text = ex.Message;
                dataValidationLabel.Visible = true;
            }
        }

        protected void rizzoSalataIzbor_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("RizzoSalata.aspx");
            }
            catch (Exception ex)
            {
                dataValidationLabel.Text = ex.Message;
                dataValidationLabel.Visible = true;
            }
        }

        protected void ostaliPizzaIzbor_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("OstaliPizza.aspx");
            }
            catch (Exception ex)
            {
                dataValidationLabel.Text = ex.Message;
                dataValidationLabel.Visible = true;
            }
        }

    }
}