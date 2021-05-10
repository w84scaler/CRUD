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
    public partial class TankItemForm : Form
    {
        private ReturnMethod ReturnObj;
        private int ObjectIndex;
        public TankItemForm(ReturnMethod method, object obj, int index)
        {
            InitializeComponent();
            ReturnObj = method;
            ObjectIndex = index;

            if (obj != null)
            {
                textBoxName.Text = (obj as TankItem).Name;
                textBoxDescription.Text = (obj as TankItem).Description;
                comboBoxLevel.SelectedIndex = (obj as TankItem).Level - 1;
                textBoxCost.Text = (obj as TankItem).Cost.ToString();
                checkBoxJungle.Checked = (obj as TankItem).Jungle;

                textBoxMagicResistance.Text = (obj as TankItem).MagicResistance.ToString();
                textBoxArmor.Text = (obj as TankItem).Armor.ToString();
                textBoxHealth.Text = (obj as TankItem).Health.ToString();
                textBoxRegen.Text = (obj as TankItem).Regen.ToString();

                effect = (obj as TankItem).Passive;
            }
        }

        private PassiveEffect effect = null;
        private void GetPassiveEffect(object Obj, int i)
        {
            effect = (Obj as PassiveEffect);
        }
        private void buttonCreatePassiveEffect_Click(object sender, EventArgs e)
        {
            PassiveEffectCreator creator = new PassiveEffectCreator();
            var frm = creator.Create(GetPassiveEffect, effect, 0);
            frm.Show();
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            try
            {
                var item = new TankItem();

                item.Name = textBoxName.Text;
                item.Description = textBoxDescription.Text;
                item.Level = comboBoxLevel.SelectedIndex + 1;
                item.Cost = Convert.ToInt32(textBoxCost.Text);
                item.Jungle = checkBoxJungle.Checked;

                item.MagicResistance = Convert.ToInt32(textBoxMagicResistance.Text);
                item.Armor = Convert.ToInt32(textBoxArmor.Text);
                item.Health = Convert.ToInt32(textBoxHealth.Text);
                item.Regen = Convert.ToInt32(textBoxRegen.Text);
                item.Passive = effect;

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
