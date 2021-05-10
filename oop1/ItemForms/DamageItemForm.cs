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
    public partial class DamageItemForm : Form
    {
        private ReturnMethod ReturnObj;
        private int ObjectIndex;
        public DamageItemForm(ReturnMethod method, object obj, int index)
        {
            InitializeComponent();
            ReturnObj = method;
            ObjectIndex = index;

            if (obj != null)
            {
                textBoxName.Text = (obj as DamageItem).Name;
                textBoxDescription.Text = (obj as DamageItem).Description;
                comboBoxLevel.SelectedIndex = (obj as DamageItem).Level - 1;
                textBoxCost.Text = (obj as DamageItem).Cost.ToString();
                checkBoxJungle.Checked = (obj as DamageItem).Jungle;

                checkBoxActive.Checked = (obj as DamageItem).Active;
                checkBoxSlowEffect.Checked = (obj as DamageItem).SlowEffect;
                checkBoxGrieviousWounds.Checked = (obj as DamageItem).GrievousWounds;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new DamageItem();

                item.Name = textBoxName.Text;
                item.Description = textBoxDescription.Text;
                item.Level = comboBoxLevel.SelectedIndex + 1;
                item.Cost = Convert.ToInt32(textBoxCost.Text);
                item.Jungle = checkBoxJungle.Checked;

                item.Active = checkBoxActive.Checked;
                item.SlowEffect = checkBoxSlowEffect.Checked;
                item.GrievousWounds = checkBoxGrieviousWounds.Checked;

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
