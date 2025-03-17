using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movieGenre = { "Animation", "Horror", "Sci-Fi" };
            movieComboBox.Items.AddRange(movieGenre);

            movieComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            movieComboBox.SelectedIndex = 0;
        }

        private void Select_Click(object sender, EventArgs e)
        {
            string[] animatedMovieList = { "Big Hero 6", "Bolt", "Shrek 4" };
            string[] horrorMovieList = { "Shake Rattle & Roll", "Feng Shui" };
            string[] scifiMovieList = { "Interstellar", "Oblivion" };

            movieCheckedListBox.Items.Clear();

            if (movieComboBox.SelectedItem.ToString().Contains("Animation"))
            {
                movieCheckedListBox.Items.AddRange(animatedMovieList);
            } else if (movieComboBox.SelectedItem.ToString().Contains("Horror"))
            {
                movieCheckedListBox.Items.AddRange(horrorMovieList);
            } else if (movieComboBox.SelectedItem.ToString().Contains("Sci-Fi"))
            {
                movieCheckedListBox.Items.AddRange(scifiMovieList);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach ( var item in movieCheckedListBox.Items)
            {
                bool isSelected = movieCheckedListBox.GetItemChecked(movieCheckedListBox.Items.IndexOf(item));
                if (isSelected && !movieListBox.Items.Contains(item))
                {
                    movieListBox.Items.Add(item);

                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (movieListBox.Items.Count >= 1)
            {
                movieListBox.Items.Remove(movieListBox.SelectedItem);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            movieListBox.Items.Clear();
        }
    }
}
