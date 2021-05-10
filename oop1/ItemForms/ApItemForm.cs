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
    public partial class ApItemForm : Form
    {
        private ReturnMethod ReturnObj;
        private int ObjectIndex;
        public ApItemForm(ReturnMethod method, object obj, int index)
        {
            InitializeComponent();
            ReturnObj = method;
            ObjectIndex = index;

            if (obj != null)
            {
                textBoxName.Text = (obj as ApItem).Name;
                textBoxDescription.Text = (obj as ApItem).Description;
                comboBoxLevel.SelectedIndex = (obj as ApItem).Level - 1;
                textBoxCost.Text = (obj as ApItem).Cost.ToString();
                checkBoxJungle.Checked = (obj as ApItem).Jungle;

                checkBoxActive.Checked = (obj as ApItem).Active;
                checkBoxSlowEffect.Checked = (obj as ApItem).SlowEffect;
                checkBoxGrieviousWounds.Checked = (obj as ApItem).GrievousWounds;

                textBoxAbilityPower.Text = (obj as ApItem).AbilityPower.ToString();
                textBoxCooldownReduction.Text = (obj as ApItem).CooldownReduction.ToString();
                textBoxMana.Text = (obj as ApItem).Mana.ToString();
            }
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                var item = new ApItem();

                item.Name = textBoxName.Text;
                item.Description = textBoxDescription.Text;
                item.Level = comboBoxLevel.SelectedIndex + 1;
                item.Cost = Convert.ToInt32(textBoxCost.Text);
                item.Jungle = checkBoxJungle.Checked;

                item.Active = checkBoxActive.Checked;
                item.SlowEffect = checkBoxSlowEffect.Checked;
                item.GrievousWounds = checkBoxGrieviousWounds.Checked;

                item.AbilityPower = Convert.ToInt32(textBoxAbilityPower.Text);
                item.CooldownReduction = Convert.ToInt32(textBoxCooldownReduction.Text);
                item.Mana = Convert.ToInt32(textBoxMana.Text);

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
