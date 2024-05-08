namespace CafeApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> prices = new Dictionary<string, double>()
        {
            {"Coffee - $2.50", 2.50},
            {"Tea - $2.00", 2.00},
            {"Cake - $3.50", 3.50},
            // Add more items to the menu as needed
        };

        private Dictionary<string, int> order = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            foreach (var item in prices.Keys)
            {
                comboBoxItems.Items.Add(item);
            }
        }


        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBoxItems.SelectedItem.ToString();
            int quantity = (int)numericUpDownQuantity.Value;

            if (order.ContainsKey(selectedItem))
            {
                order[selectedItem] += quantity;
            }
            else
            {
                order.Add(selectedItem, quantity);
            }

            MessageBox.Show("Item added to order.");
        }

        private void btnDisplayReceipt_Click(object sender, EventArgs e)
        {
            double total = 0.0;
            string receipt = "Receipt:\n";

            foreach (var item in order)
            {
                double itemTotal = prices[item.Key] * item.Value;
                total += itemTotal;
                receipt += $"{item.Key} x{item.Value}: ${prices[item.Key]} each, Total: ${itemTotal}\n";
            }

            receipt += $"Total: ${total}";

            MessageBox.Show(receipt);
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
