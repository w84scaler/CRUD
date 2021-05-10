using System;
using System.Windows.Forms;

namespace oop1
{
    public partial class AdItemForm : Form
    {
        private ReturnMethod ReturnObj;
        private int ObjectIndex;
        public AdItemForm(ReturnMethod method, object obj, int index)
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

                checkBoxActive.Checked = (obj as AdItem).Active;
                checkBoxSlowEffect.Checked = (obj as AdItem).SlowEffect;
                checkBoxGrieviousWounds.Checked = (obj as AdItem).GrievousWounds;

                textBoxAttackDamage.Text = (obj as AdItem).AttackDamage.ToString();
                textBoxLethality.Text = (obj as AdItem).Lethality.ToString();
                textBoxLifeSteal.Text = (obj as AdItem).LifeSteal.ToString();
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new AdItem();

                item.Name = textBoxName.Text;
                item.Description = textBoxDescription.Text;
                item.Level = comboBoxLevel.SelectedIndex + 1;
                item.Cost = Convert.ToInt32(textBoxCost.Text);
                item.Jungle = checkBoxJungle.Checked;

                item.Active = checkBoxActive.Checked;
                item.SlowEffect = checkBoxSlowEffect.Checked;
                item.GrievousWounds = checkBoxGrieviousWounds.Checked;

                item.AttackDamage = Convert.ToInt32(textBoxAttackDamage.Text);
                item.Lethality = Convert.ToInt32(textBoxLethality.Text);
                item.LifeSteal = Convert.ToInt32(textBoxLifeSteal.Text);

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
