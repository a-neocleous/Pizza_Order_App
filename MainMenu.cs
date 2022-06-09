using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_AndreasNeocleous
{
    public partial class MainMenu : Form
    {
        private SettingsForm settingsForm = new SettingsForm();
        public static double pizza_cost = 0;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void placeorderButton_Click(object sender, EventArgs e)
        {
            string text = timeTextBox.Text.Substring(0, 2);
            string text2 = timeTextBox.Text.Substring(3, 2);
            int timeProvided = Int32.Parse(text);
            int timeProvidedMinutes = Int32.Parse(text2);
            int timeOfDayHours = DateTime.Now.TimeOfDay.Hours;
            int timeOfDayMinutes = DateTime.Now.TimeOfDay.Minutes;

            if (timeProvided >= 24 || timeProvidedMinutes > 60)
            {
                MessageBox.Show("Provide valid time",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else if (timeProvided < timeOfDayHours || (timeProvided == timeOfDayHours && timeProvidedMinutes <= timeOfDayMinutes))
            {
                MessageBox.Show("Provide valid time that is in the future",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("The total for your pizza is €" + pizza_cost + " to be delivered at " + timeTextBox.Text + " are you sure you want to order?",
                                              "",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    MessageBox.Show("Your order will arrive at " + timeTextBox.Text + " and costs €" + pizza_cost,
                                    "",
                                    MessageBoxButtons.OK);
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Your order is cancelled",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
                Close();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.ShowDialog();

            InitializeSizes();
            InitializeToppings();

        }

        private Sizes GetSelectedSize()
        {
            foreach (RadioButton sizeRadioButton in sizeFlowLayoutPanel.Controls)
            {
                if (sizeRadioButton.Checked)
                    return sizeRadioButton.Tag as Sizes;
            }
            return null;
        }

        private List<Toppings> GetSelectedToppings()
        {
            List<Toppings> toppings = new List<Toppings>();

            foreach (CheckBox toppingsCheckBox in toppingsFlowLayoutPanel.Controls)
            {
                if (toppingsCheckBox.Checked)
                {
                    var selectedTopping = toppingsCheckBox.Tag as Toppings;
                    toppings.Add(selectedTopping);
                }
            }

            return toppings;
        }

        private void UpdatePrice()
        {
            pizza_cost = 0;
            var selectedSize = GetSelectedSize();
            var selectedToppings = GetSelectedToppings();


            if (selectedSize != null)
            {
                pizza_cost += selectedSize.Price;

                selectedToppings.Sort(delegate (Toppings t1, Toppings t2) //Sort toppings from High to Low price. 
                {
                    if (t1.Price < t2.Price)
                        return -1;
                    else 
                        return 1;
                 }
                );

                for (int i=0; i<selectedToppings.Count - selectedSize.FreeToppingsNum; i++)//Then not charging the n most expensive, where n: free toppings for selected size
                {
                    var topping = selectedToppings[i];
                    pizza_cost += topping.Price;
                }
            }
            priceLabel.Text= "€ " + pizza_cost.ToString("N2");
        }
        private void InitializeSizes()
        {
            sizeFlowLayoutPanel.Controls.Clear();

            foreach (var entry in settingsForm.Sizes)
            {
                var sizeRadioButton = new RadioButton();

                sizeRadioButton.Text = entry.Name;
                sizeRadioButton.AutoSize = true;
                sizeRadioButton.Tag = entry;

                sizeRadioButton.CheckedChanged += sizeRadioButton_CheckedChanged;

                sizeFlowLayoutPanel.Controls.Add(sizeRadioButton);
            }

        }
        private void InitializeToppings()
        {
            toppingsFlowLayoutPanel.Controls.Clear();

            foreach (var entry in settingsForm.Toppings)
            {
                var toppingsCheckBox = new CheckBox();

                toppingsCheckBox.Text = entry.Name;
                toppingsCheckBox.AutoSize = true;
                toppingsCheckBox.Tag = entry;

                toppingsCheckBox.CheckedChanged += sizeRadioButton_CheckedChanged;//used same event as Sizes because it performs same task

                toppingsFlowLayoutPanel.Controls.Add(toppingsCheckBox);
            }
        }
        private void sizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

    }
}
