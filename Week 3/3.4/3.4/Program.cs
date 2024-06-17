namespace _3._4
{

  // Abstract base class for all beverages
abstract class Beverage
        {
            public string Name { get; set; }
            public int Quantity { get; set; }

            // Abstract method to be overridden by derived classes
            public abstract string GetDescription();
        }

        // Concrete class representing Coffee
        class Coffee : Beverage
        {
            public Coffee(string name, int quantity)
            {
                Name = name;
                Quantity = quantity;
            }

            public override string GetDescription()
            {
                return $"Coffee: {Name} ({Quantity} cups)";
            }
         

namespace CoffeeApp
    {
        public partial class Form
        {
            private List<Coffee> coffeeList = new List<Coffee>();
            private object dataGridView1;

            public MainForm() => InitializeComponent();

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }

            private void MainForm_Load(object sender, EventArgs e)
            {
                // Initialize the coffee list (you can add more items)
                coffeeList.Add(new Coffee("Espresso", 2));
                coffeeList.Add(new Coffee("Americano", 3));

                // Bind the coffee list to a DataGridView
                dataGridView1.DataSource = coffeeList;
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                // Add a new coffee item
                coffeeList.Add(new Coffee("Latte", 1));
                dataGridView1.Refresh();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                // Remove the selected coffee item
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var selectedCoffee = (Coffee)dataGridView1.SelectedRows[0].DataBoundItem;
                    coffeeList.Remove(selectedCoffee);
                    dataGridView1.Refresh();
                }
            }
        }
    }
}