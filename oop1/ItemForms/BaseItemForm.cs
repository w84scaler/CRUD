using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop1
{
    public partial class BaseItemForm : Form
    {
        private ReturnMethod ReturnObj;
        private int ObjectIndex;
        public BaseItemForm(ReturnMethod method, object obj, int index)
        {
            InitializeComponent();
            ReturnObj = method;
            ObjectIndex = index;

            if (obj != null)
            {
                textBoxName.Text = (obj as BaseItem).Name;
                textBoxDescription.Text = (obj as BaseItem).Description;
                comboBoxLevel.SelectedIndex = (obj as BaseItem).Level - 1;
                textBoxCost.Text = (obj as BaseItem).Cost.ToString();
                checkBoxJungle.Checked = (obj as BaseItem).Jungle;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new BaseItem();

                item.Name = textBoxName.Text;
                item.Description = textBoxDescription.Text;
                item.Level = comboBoxLevel.SelectedIndex + 1;
                item.Cost = Convert.ToInt32(textBoxCost.Text);
                item.Jungle = checkBoxJungle.Checked;

                ReturnObj(item, ObjectIndex);
                Close();
            }
            catch
            {
                MessageBox.Show(
                    "Input error",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
