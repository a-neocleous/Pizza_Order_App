using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Pizza_Order_AndreasNeocleous
{
    public partial class SettingsForm : Form
    {
        public List<Sizes> Sizes { get; set; }
        public List<Toppings> Toppings { get; set; }
        

        private const string SizeFile = "Size.json";
        private const string ToppingsFile = "Toppings.json";

        public SettingsForm()
        {
            InitializeComponent();

            LoadSize();
            LoadToppings();
        }

        private void LoadSize()
        {
            if (File.Exists(SizeFile))
            {
                var fileString = File.ReadAllText(SizeFile);
                Sizes = JsonConvert.DeserializeObject<List<Sizes>>(fileString);
            }
            else
            {
                Sizes = new List<Sizes>();
            }

            sizeDataGridView.DataSource = new BindingList<Sizes>(Sizes);
        }

        private void LoadToppings()
        {
            if (File.Exists(ToppingsFile))
            {
                var fileString = File.ReadAllText(ToppingsFile);
                Toppings = JsonConvert.DeserializeObject<List<Toppings>>(fileString);
            }
            else
            {
                Toppings = new List<Toppings>();
            }

            toppingsDataGridView.DataSource = new BindingList<Toppings>(Toppings);
        }

        private void sizesSaveButton_Click(object sender, System.EventArgs e)
        {
            var fileString = JsonConvert.SerializeObject(Sizes);
            File.WriteAllText(SizeFile, fileString);

            MessageBox.Show("Pizza Sizes were successfully saved", "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void toppingSaveButton_Click(object sender, System.EventArgs e)
        {
            var fileString = JsonConvert.SerializeObject(Toppings);
            File.WriteAllText(ToppingsFile, fileString);

            MessageBox.Show("Pizza Toppings were successfully saved", "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void sizesResetButton_Click(object sender, System.EventArgs e)
        {
            LoadSize();
        }

        private void toppingsResetButton_Click(object sender, System.EventArgs e)
        {
            LoadToppings();
        }
    }
    
}
