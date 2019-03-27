using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Office.Interop.Excel;
using System.IO;
using Marende.DTO;

namespace Marende.Web
{
    public partial class OrdersManagment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            validationLabel.Visible = false;
            var orders = getDataSet();

            ordersGridView.DataSource = orders;
            ordersGridView.DataBind();
        }

        protected void excelButton_Click(object sender, EventArgs e)
        {

            try
            {
                exportToExcel();
                Response.Redirect("DownloadFile.aspx");
            }
            catch (Exception ex)
            {
                validationLabel.Text = ex.Message;
                validationLabel.Visible = true;
            }
            
        }

        protected List<DTO.OrderDto> getDataSet()
        {
            return Domain.OrderManager.GetOrders();
        }

        protected void exportToExcel()
        {
            var datum = DateTime.Now.Date;
            //TextWriter writer = new StreamWriter(@"C:\Users\vlado.juric\Downloads\Marende\Marende.csv");
            TextWriter writer = new StreamWriter(@"C:\inetpub\wwwroot\ADPMarende\ADPMarendeCSV\Marende.csv");
            string dbText = "";
            int i = 1;
            DTO.OrderDto temp = new OrderDto();
            writer.WriteLine(datum + ";");
            var orders = getDataSet();
            
            foreach (var order in orders)
            {
                dbText = i + "; ";
                dbText += order.Ime + " ";
                dbText += order.Prezime + ";";
                dbText += order.TipKruh + ";";
                dbText += order.VelicinaSendvic + ";";
                dbText += order.SastavSendvicOsnovno + ";";

                foreach (var prop in temp.GetType().GetProperties())
                {
                    var propVal = GetPropValue(order, prop.Name);
                    if (propVal != null && propVal.GetType() == typeof(bool) && Convert.ToBoolean(propVal))
                    {
                        dbText += prop.Name + ", ";
                    }
                }

                dbText += ";";
                dbText += order.Napomena.ToUpper();
                writer.WriteLine(dbText);
                i++;
            }
            writer.Close();
        }

        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}