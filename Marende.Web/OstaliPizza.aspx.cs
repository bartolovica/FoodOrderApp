using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Marende.DTO.Enums;

namespace Marende.Web
{
    public partial class OstaliPizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validationLabel.Visible = false;
        }

        protected void okPizzaButton_Click(object sender, EventArgs e)
        {
            if (imeTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Molim unisite ime da narudžba može biti odrađena";
                validationLabel.Visible = true;
                return;
            }
            if (prezimeTextBox.Text.Trim().Length == 0)
            {
                validationLabel.Text = "Molim unisite prezime da narudžba može biti odrađena";
                validationLabel.Visible = true;
                return;
            }

            try
            {
                var order = buildOrder();
                Domain.OrderManager.CreateOrder(order);
                Response.Redirect("Finished.aspx");
            }
            catch (Exception ex)
            {
                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
                return;
            }
        }

        private DTO.OrderDto buildOrder()
        {
            var order = new DTO.OrderDto();

            order.TipKruh = TipKruhType.Nista;
            order.VelicinaSendvic = VelicinaType.Mali;
            order.SastavSendvicOsnovno = SendvicOsnovnoType.Pizza;

            order.Ime = imeTextBox.Text;
            order.Prezime = prezimeTextBox.Text;
            order.Kecap = kecapCheckBox.Checked;
            order.Majoneza = majonezaCheckBox.Checked;
            order.Tartar = false;
            order.Sir = false;
            order.MladiSir = false;
            order.Jaja = false;
            order.Kupus = false;
            order.Salata = false;
            order.Pome = false;
            order.Rukola = false;
            order.Krastavci = false;
            order.SvjeziKrastavci = false;
            order.Kapula = false;
            order.Kukuruz = false;
            order.Paprika = false;
            order.Napomena = napomenaTextBox.Text;
            order.DatumUnosa = DateTime.Now;

            return order;
        }
    }
}