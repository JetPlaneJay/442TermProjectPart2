using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MIS442_TermOutline_JTabares
{
    public partial class ContactDisplay : System.Web.UI.Page
    {
        private CustomerList contacts;
        protected void Page_Load(object sender, EventArgs e)
        {
            contacts = CustomerList.GetCustomers();
            if (!IsPostBack)
                DisplayContacts();
        }
        private void DisplayContacts()
        {
            lstBoxCustomers.Items.Clear();
            Customer customer;
            for (int i = 0; i < contacts.Count; i++)
            {
                customer = contacts[i];
                lstBoxCustomers.Items.Add(customer.ContactDisplay());
            }
        }
        protected void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstBoxCustomers.SelectedIndex > -1 && contacts.Count > 0)
            {
                contacts.RemoveAt(lstBoxCustomers.SelectedIndex);
                DisplayContacts();
            }
        }

        protected void btnEmpty_Click(object sender, EventArgs e)
        {

            contacts.Clear();
            lstBoxCustomers.Items.Clear();
        }
    }
}