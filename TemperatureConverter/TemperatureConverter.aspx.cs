using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TemperatureConverter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (this.IsPostBack == false)
        {
            // The HtmlSelect control accepts text or ListItem objects.
            Temperature.Items.Add(new ListItem("Celsius"));
            Temperature.Items.Add(new ListItem("Kelvin"));
            
        }
    }

    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        decimal oldTemp;
        
        bool success = Decimal.TryParse(Fahr.Value, out oldTemp);
        if (success)
        {
            // Retrieve the selected ListItem object by its index number.
            
            ListItem item = Temperature.Items[Temperature.SelectedIndex];
            decimal newTemp= 0M;

            switch (Temperature.SelectedIndex)
            {
                case 0:
                    newTemp = ((oldTemp - 32) / (9 / 5));
                    break;
                case 1:
                    newTemp = ((oldTemp - 32) * (5 / 9)) + 273.15M;
                    break;
                default:
                    break;
            }

            

            Result.InnerText = oldTemp.ToString() + " Fahrenheit = ";
            Result.InnerText += newTemp.ToString() + " " + item.Text;

          
        }
    }

}