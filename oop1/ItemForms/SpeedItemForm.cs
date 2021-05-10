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
    public partial class SpeedItemForm : Form
    {
        private ReturnMethod ReturnObj;
        private int ObjectIndex;
        public SpeedItemForm(ReturnMethod method, object obj, int index)
        {
            InitializeComponent();
            ReturnObj = method;
            ObjectIndex = index;

            if (obj != null)
            {
                textBoxName.Text = (obj as SpeedItem).Name;
                textBoxDescription.Text = (obj as SpeedItem).Description;
                comboBoxLevel.SelectedIndex = (obj as SpeedItem).Level - 1;
                textBoxCost.Text = (obj as SpeedItem).Cost.ToString();
                checkBoxJungle.Checked = (obj as SpeedItem).Jungle;

                textBoxAttackSpeed.Text = (obj as SpeedItem).AttackSpeed.ToString();
                textBoxCritChance.Text = (obj as SpeedItem).CritChance.ToString();
                textBoxMoveSpeed.Text = (obj as SpeedItem).MoveSpeed.ToString();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new SpeedItem();

                item.Name = textBoxName.Text;
                item.Description = textBoxDescription.Text;
                item.Level = comboBoxLevel.SelectedIndex + 1;
                item.Cost = Convert.ToInt32(textBoxCost.Text);
                item.Jungle = checkBoxJungle.Checked;

                item.AttackSpeed = Convert.ToInt32(textBoxAttackSpeed.Text);
                item.CritChance = Convert.ToInt32(textBoxCritChance.Text);
                item.MoveSpeed = Convert.ToInt32(textBoxMoveSpeed.Text);

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
