using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marende.Web
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validationLabel.Visible = false;
        }

        protected void okButton_Click(object sender, EventArgs e)
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

        private DTO.Enums.TipKruhType determineTip()
        {
            DTO.Enums.TipKruhType kruh;
            if (!Enum.TryParse(tipDropDownList.SelectedValue, out kruh))
            {
                throw new Exception("Could not determine Tip kruha!");
            }
            return kruh;
        }

        private DTO.Enums.VelicinaType determineVelicina()
        {
            DTO.Enums.VelicinaType velicina;
            if (!Enum.TryParse(velicinaDropDownList.SelectedValue, out velicina))
            {
                throw new Exception("Could not determine Velicina kruha!");
            }
            return velicina;
        }

        private DTO.Enums.SendvicOsnovnoType determineOsnovno()
        {
            DTO.Enums.SendvicOsnovnoType osnovno;
            if (!Enum.TryParse(osnovnoMaliDropDownList.SelectedValue, out osnovno))
            {
                if (!Enum.TryParse(osnovnoSrednjiDropDownList.SelectedValue, out osnovno))
                {
                    if (!Enum.TryParse(osnovnoVelikiDropDownList.SelectedValue, out osnovno))
                    {
                        throw new Exception("Could not determine Sastav Osnovno!");
                    }
                }
            }

            return osnovno;
        }

        protected void recalculateTotalCijena(object sender, EventArgs e)
        {
            if (tipDropDownList.SelectedValue == String.Empty) return;
            if (tipDropDownList.SelectedValue != DTO.Enums.TipKruhType.Sendvic.ToString())
            {
                velicinaDropDownList.Visible = false;
                velicinaDropDownList.SelectedValue = DTO.Enums.VelicinaType.Mali.ToString();
            }
            else
            {
                velicinaDropDownList.Visible = true;
                if (velicinaDropDownList.SelectedValue == String.Empty) return;
            }

            if (velicinaDropDownList.SelectedValue == DTO.Enums.VelicinaType.Mali.ToString())
            {
                osnovnoMaliDropDownList.Visible = true;
                osnovnoSrednjiDropDownList.Visible = false;
                osnovnoVelikiDropDownList.Visible = false;
                if (osnovnoMaliDropDownList.SelectedValue == String.Empty) return;
            }
            if (velicinaDropDownList.SelectedValue == DTO.Enums.VelicinaType.Srednji.ToString())
            {
                osnovnoMaliDropDownList.Visible = false;
                osnovnoSrednjiDropDownList.Visible = true;
                osnovnoVelikiDropDownList.Visible = false;
                if (osnovnoSrednjiDropDownList.SelectedValue == String.Empty) return;
            }
            if (velicinaDropDownList.SelectedValue == DTO.Enums.VelicinaType.Veliki.ToString())
            {
                osnovnoVelikiDropDownList.Visible = true;
                osnovnoSrednjiDropDownList.Visible = false;
                osnovnoMaliDropDownList.Visible = false;
                if (osnovnoVelikiDropDownList.SelectedValue == String.Empty) return;
            }

            
            try
            {
                var order = buildOrder();
                totalLabel.Text = Domain.OstaliCijenaManager.CalculateRizzoCijena(order).ToString("C");
            }
            catch (Exception ex)
            {
                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
            }

        }

        private DTO.OrderDto buildOrder()
        {
            var order = new DTO.OrderDto();

            order.TipKruh = determineTip();
            if (order.TipKruh != DTO.Enums.TipKruhType.Sendvic)
                order.VelicinaSendvic = DTO.Enums.VelicinaType.Mali;
            else
                order.VelicinaSendvic = determineVelicina();
            order.SastavSendvicOsnovno = determineOsnovno();

            order.Ime = imeTextBox.Text;
            order.Prezime = prezimeTextBox.Text;
            order.Kecap = kecapCheckBox.Checked;
            order.Majoneza = majonezaCheckBox.Checked;
            order.Tartar = tartarCheckBox.Checked;
            order.Sir = sirCheckBox.Checked;
            order.MladiSir = mladiSirCheckBox.Checked;
            order.Jaja = jajaCheckBox.Checked;
            order.Kupus = kupusCheckBox.Checked;
            order.Salata = salataCheckBox.Checked;
            order.Pome = pomeCheckBox.Checked;
            order.Rukola = rukolaCheckBox.Checked;
            order.Krastavci = krastavciCheckBox.Checked;
            order.SvjeziKrastavci = svjeziKrastavciCheckBox.Checked;
            order.Kapula = kapulaCheckBox.Checked;
            order.Kukuruz = kukuruzCheckBox.Checked;
            order.Paprika = paprikaCheckBox.Checked;
            order.Napomena = napomenaTextBox.Text;
            order.DatumUnosa = DateTime.Now;

            return order;
        }
    }
}