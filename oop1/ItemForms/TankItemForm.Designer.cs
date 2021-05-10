namespace oop1
{
    partial class TankItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMagicResistance = new System.Windows.Forms.Label();
            this.labelArmor = new System.Windows.Forms.Label();
            this.labelHealth = new System.Windows.Forms.Label();
            this.textBoxHealth = new System.Windows.Forms.TextBox();
            this.textBoxMagicResistance = new System.Windows.Forms.TextBox();
            this.textBoxArmor = new System.Windows.Forms.TextBox();
            this.labelRegen = new System.Windows.Forms.Label();
            this.textBoxRegen = new System.Windows.Forms.TextBox();
            this.buttonCreatePassiveEffect = new System.Windows.Forms.Button();
            this.labelPassive = new System.Windows.Forms.Label();
            this.checkBoxJungle = new System.Windows.Forms.CheckBox();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelJungle = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMagicResistance
            // 
            this.labelMagicResistance.AutoSize = true;
            this.labelMagicResistance.Location = new System.Drawing.Point(12, 168);
            this.labelMagicResistance.Name = "labelMagicResistance";
            this.labelMagicResistance.Size = new System.Drawing.Size(89, 13);
            this.labelMagicResistance.TabIndex = 32;
            this.labelMagicResistance.Text = "MagicResistance";
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Location = new System.Drawing.Point(12, 194);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(34, 13);
            this.labelArmor.TabIndex = 31;
            this.labelArmor.Text = "Armor";
            // 
            // labelHealth
            // 
            this.labelHealth.AutoSize = true;
            this.labelHealth.Location = new System.Drawing.Point(12, 220);
            this.labelHealth.Name = "labelHealth";
            this.labelHealth.Size = new System.Drawing.Size(38, 13);
            this.labelHealth.TabIndex = 30;
            this.labelHealth.Text = "Health";
            // 
            // textBoxHealth
            // 
            this.textBoxHealth.Location = new System.Drawing.Point(132, 217);
            this.textBoxHealth.Name = "textBoxHealth";
            this.textBoxHealth.Size = new System.Drawing.Size(100, 20);
            this.textBoxHealth.TabIndex = 29;
            // 
            // textBoxMagicResistance
            // 
            this.textBoxMagicResistance.Location = new System.Drawing.Point(132, 165);
            this.textBoxMagicResistance.Name = "textBoxMagicResistance";
            this.textBoxMagicResistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxMagicResistance.TabIndex = 28;
            // 
            // textBoxArmor
            // 
            this.textBoxArmor.Location = new System.Drawing.Point(132, 191);
            this.textBoxArmor.Name = "textBoxArmor";
            this.textBoxArmor.Size = new System.Drawing.Size(100, 20);
            this.textBoxArmor.TabIndex = 27;
            // 
            // labelRegen
            // 
            this.labelRegen.AutoSize = true;
            this.labelRegen.Location = new System.Drawing.Point(12, 246);
            this.labelRegen.Name = "labelRegen";
            this.labelRegen.Size = new System.Drawing.Size(39, 13);
            this.labelRegen.TabIndex = 34;
            this.labelRegen.Text = "Regen";
            // 
            // textBoxRegen
            // 
            this.textBoxRegen.Location = new System.Drawing.Point(132, 243);
            this.textBoxRegen.Name = "textBoxRegen";
            this.textBoxRegen.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegen.TabIndex = 33;
            // 
            // buttonCreatePassiveEffect
            // 
            this.buttonCreatePassiveEffect.Location = new System.Drawing.Point(132, 269);
            this.buttonCreatePassiveEffect.Name = "buttonCreatePassiveEffect";
            this.buttonCreatePassiveEffect.Size = new System.Drawing.Size(100, 23);
            this.buttonCreatePassiveEffect.TabIndex = 35;
            this.buttonCreatePassiveEffect.Text = "CreatePassive";
            this.buttonCreatePassiveEffect.UseVisualStyleBackColor = true;
            this.buttonCreatePassiveEffect.Click += new System.EventHandler(this.buttonCreatePassiveEffect_Click);
            // 
            // labelPassive
            // 
            this.labelPassive.AutoSize = true;
            this.labelPassive.Location = new System.Drawing.Point(12, 274);
            this.labelPassive.Name = "labelPassive";
            this.labelPassive.Size = new System.Drawing.Size(44, 13);
            this.labelPassive.TabIndex = 36;
            this.labelPassive.Text = "Passive";
            // 
            // checkBoxJungle
            // 
            this.checkBoxJungle.AutoSize = true;
            this.checkBoxJungle.Location = new System.Drawing.Point(132, 146);
            this.checkBoxJungle.Name = "checkBoxJungle";
            this.checkBoxJungle.Size = new System.Drawing.Size(44, 17);
            this.checkBoxJungle.TabIndex = 47;
            this.checkBoxJungle.Text = "Yes";
            this.checkBoxJungle.UseVisualStyleBackColor = true;
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Basic",
            "Advanced",
            "Finished"});
            this.comboBoxLevel.Location = new System.Drawing.Point(132, 92);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLevel.TabIndex = 46;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(132, 66);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 45;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(132, 118);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 44;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 43;
            // 
            // labelJungle
            // 
            this.labelJungle.AutoSize = true;
            this.labelJungle.Location = new System.Drawing.Point(12, 146);
            this.labelJungle.Name = "labelJungle";
            this.labelJungle.Size = new System.Drawing.Size(38, 13);
            this.labelJungle.TabIndex = 42;
            this.labelJungle.Text = "Jungle";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 121);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(28, 13);
            this.labelCost.TabIndex = 41;
            this.labelCost.Text = "Cost";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(12, 95);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 40;
            this.labelLevel.Text = "Level";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 69);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 39;
            this.labelDescription.Text = "Description";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 38;
            this.labelName.Text = "Name";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 37;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click_1);
            // 
            // TankItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 301);
            this.Controls.Add(this.checkBoxJungle);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelJungle);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelPassive);
            this.Controls.Add(this.buttonCreatePassiveEffect);
            this.Controls.Add(this.labelRegen);
            this.Controls.Add(this.textBoxRegen);
            this.Controls.Add(this.labelMagicResistance);
            this.Controls.Add(this.labelArmor);
            this.Controls.Add(this.labelHealth);
            this.Controls.Add(this.textBoxHealth);
            this.Controls.Add(this.textBoxMagicResistance);
            this.Controls.Add(this.textBoxArmor);
            this.Name = "TankItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TankItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMagicResistance;
        private System.Windows.Forms.Label labelArmor;
        private System.Windows.Forms.Label labelHealth;
        private System.Windows.Forms.TextBox textBoxHealth;
        private System.Windows.Forms.TextBox textBoxMagicResistance;
        private System.Windows.Forms.TextBox textBoxArmor;
        private System.Windows.Forms.Label labelRegen;
        private System.Windows.Forms.TextBox textBoxRegen;
        private System.Windows.Forms.Button buttonCreatePassiveEffect;
        private System.Windows.Forms.Label labelPassive;
        private System.Windows.Forms.CheckBox checkBoxJungle;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelJungle;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonCreate;
    }
}