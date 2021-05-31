using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MIS442_TermOutline_JTabares
{
    public partial class CustomerIncidentDisplay : System.Web.UI.Page
    {
        private Incident selectedIncident;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ddlIncidents1.DataBind();
            }
            selectedIncident = GetselectedIncident();
            DisplayIncident();

        }

        private void DisplayIncident()
        {
            lblIncidentID.Text = selectedIncident.IncidentID;
            lblProductCode.Text = selectedIncident.ProductCode;
            lblTechID.Text = selectedIncident.TechID;
            lblName.Text = selectedIncident.Description;
        }

        private Incident GetselectedIncident()
        {
            DataView incidentsTable = (DataView)
                SqlDataSource2.Select(DataSourceSelectArguments.Empty);
            incidentsTable.RowFilter = "IncidentID = " + ddlIncidents.SelectedValue;
            DataRowView row = incidentsTable[0];

            Incident incident = new Incident();
            incident.IncidentID = row["IncidentID"].ToString();
            incident.CustomerID = row["CustomerID"].ToString();
            incident.ProductCode = row["ProductCode"].ToString();
            incident.TechID = row["TechID"].ToString();

            incident.Title = row["Title"].ToString();
            incident.Description = row["Description"].ToString();
            return incident;

        }
    }
}