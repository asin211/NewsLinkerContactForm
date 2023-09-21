using Microsoft.VisualBasic;

namespace NewsLinkerContactForm
{
    public partial class Form1 : Form
    {
        // Customer Class
        class Customer
        {
            public int CustomerID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string MeansOfContact { get; set; }
        }

        // List to add new customers
        private List<Customer> customers = new List<Customer>();
        private int customerCounter = 1; // Counter for Customer Id's
        private Label[] contactLabels;

        public Form1()
        {
            InitializeComponent();

            // Check if there are no items in the ListView
            if (listBox1.Items.Count == 0)
            {
                // Add the empty item to the ListView
                listBox1.Items.Add("No Customers");
            }

            // Initialize the contactLabels array
            contactLabels = new Label[] { phoneSupportMessage, emailSupportMessage };
        }

        private void emailRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            emailTextBox.Enabled = emailRadioButton.Checked;
            phoneTextBox.Enabled = !emailTextBox.Enabled;
            contactLabels[0].Visible = !emailTextBox.Enabled;
            contactLabels[1].Visible = emailTextBox.Enabled;
        }

        private void phoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            phoneTextBox.Enabled = phoneRadioButton.Checked;
            emailTextBox.Enabled = !phoneTextBox.Enabled;
            contactLabels[1].Visible = !phoneTextBox.Enabled;
            contactLabels[0].Visible = phoneTextBox.Enabled;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Create a new Customer object
            Customer customer = new Customer
            {
                CustomerID = customerCounter++,
                Name = nameTextBox.Text,
                Address = addressTextBox.Text,
                Email = emailTextBox.Text,
                PhoneNumber = phoneTextBox.Text,
                MeansOfContact = emailRadioButton.Checked ? "Email" : "Phone"
            };

            // Add the customer to the list
            customers.Add(customer);

            // Clear the form
            ResetForm();

            MessageBox.Show("Customer information submitted.");
            show_Customers();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            phoneTextBox.Clear();
            emailRadioButton.Checked = false;
            phoneRadioButton.Checked = false;
            emailRadioButton_CheckedChanged(null, null); // Manually trigger the event handler
            contactLabels[1].Visible = false;
            contactLabels[0].Visible = false;
            phoneTextBox.Enabled = true;
            emailTextBox.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void show_Customers()
        {
            // Display all customer information in the ListBox
            listBox1.Items.Clear();
            foreach (var customer in customers)
            {
                listBox1.Items.Add($"Customer ID: {customer.CustomerID}, Name: {customer.Name}, Address: {customer.Address}, Email: {customer.Email}, Phone: {customer.PhoneNumber}, Preferred Contact: {customer.MeansOfContact}");
            }
        }
    }
}