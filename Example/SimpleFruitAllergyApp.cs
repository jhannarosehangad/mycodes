using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFruitAllergyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] fruits = { "Apple", "Mango", "Jackfruit", "Grape", "Watermelon", "Banana" };
            fruitcheckedListBox1.Items.AddRange(fruits);

            fruitcheckedListBox1.CheckOnClick = true;
        }

        private void fruitcheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (var fruit in fruitcheckedListBox1.Items)
            {
                bool isSelected = fruitcheckedListBox1.GetItemChecked(fruitcheckedListBox1.Items.IndexOf(fruit));
                if (isSelected && !fruitListBox.Items.Contains(fruit)) 
                {
                    fruitListBox.Items.Add(fruit);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (fruitListBox.Items.Count >= 1)
            {
                fruitListBox.Items.Remove(fruitListBox.SelectedItem);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            fruitListBox.Items.Clear();
        }
    }
}
