using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newItem = textBoxInput.Text.Trim();
            if (!string.IsNullOrEmpty(newItem) && !comboBoxItems.Items.Contains(newItem))
            {
                comboBoxItems.Items.Add(newItem);
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Елемент порожній або вже існує!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string itemToRemove = textBoxInput.Text.Trim();
            if (comboBoxItems.Items.Contains(itemToRemove))
            {
                comboBoxItems.Items.Remove(itemToRemove);
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Елемент не знайдено в списку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
