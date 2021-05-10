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
    public partial class PassiveEffectForm : Form
    {
        private ReturnMethod ReturnObj;
        private int ObjectIndex;
        public PassiveEffectForm(ReturnMethod method, object obj, int index)
        {
            InitializeComponent();
            ReturnObj = method;
            ObjectIndex = index;

            if (obj != null)
            {
                textBoxName.Text = (obj as PassiveEffect).Name;
                textBoxDescription.Text = (obj as PassiveEffect).Description;
                checkBoxUnique.Checked = (obj as PassiveEffect).Unique;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var item = new PassiveEffect();

                item.Name = textBoxName.Text;
                item.Description = textBoxDescription.Text;
                item.Unique = checkBoxUnique.Checked;

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
