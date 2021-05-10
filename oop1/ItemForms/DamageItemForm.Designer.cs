namespace oop1
{
    partial class DamageItemForm
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
            this.labelActive = new System.Windows.Forms.Label();
            this.labelSlowEffect = new System.Windows.Forms.Label();
            this.labelGrieviousWounds = new System.Windows.Forms.Label();
            this.checkBoxJungle = new System.Windows.Forms.CheckBox();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.checkBoxSlowEffect = new System.Windows.Forms.CheckBox();
            this.checkBoxGrieviousWounds = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.comboBoxLevel.TabIndex = 24;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(132, 66);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 21;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(132, 118);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 20;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 19;
            // 
            // labelJungle
            // 
            this.labelJungle.AutoSize = true;
            this.labelJungle.Location = new System.Drawing.Point(12, 146);
            this.labelJungle.Name = "labelJungle";
            this.labelJungle.Size = new System.Drawing.Size(38, 13);
            this.labelJungle.TabIndex = 18;
            this.labelJungle.Text = "Jungle";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 121);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(28, 13);
            this.labelCost.TabIndex = 17;
            this.labelCost.Text = "Cost";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(12, 95);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 16;
            this.labelLevel.Text = "Level";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 69);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Description";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 13;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Location = new System.Drawing.Point(12, 168);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(37, 13);
            this.labelActive.TabIndex = 25;
            this.labelActive.Text = "Active";
            // 
            // labelSlowEffect
            // 
            this.labelSlowEffect.AutoSize = true;
            this.labelSlowEffect.Location = new System.Drawing.Point(12, 190);
            this.labelSlowEffect.Name = "labelSlowEffect";
            this.labelSlowEffect.Size = new System.Drawing.Size(58, 13);
            this.labelSlowEffect.TabIndex = 28;
            this.labelSlowEffect.Text = "SlowEffect";
            // 
            // labelGrieviousWounds
            // 
            this.labelGrieviousWounds.AutoSize = true;
            this.labelGrieviousWounds.Location = new System.Drawing.Point(12, 213);
            this.labelGrieviousWounds.Name = "labelGrieviousWounds";
            this.labelGrieviousWounds.Size = new System.Drawing.Size(91, 13);
            this.labelGrieviousWounds.TabIndex = 31;
            this.labelGrieviousWounds.Text = "GrieviousWounds";
            // 
            // checkBoxJungle
            // 
            this.checkBoxJungle.AutoSize = true;
            this.checkBoxJungle.Location = new System.Drawing.Point(132, 145);
            this.checkBoxJungle.Name = "checkBoxJungle";
            this.checkBoxJungle.Size = new System.Drawing.Size(44, 17);
            this.checkBoxJungle.TabIndex = 32;
            this.checkBoxJungle.Text = "Yes";
            this.checkBoxJungle.UseVisualStyleBackColor = true;
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(132, 167);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(44, 17);
            this.checkBoxActive.TabIndex = 33;
            this.checkBoxActive.Text = "Yes";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // checkBoxSlowEffect
            // 
            this.checkBoxSlowEffect.AutoSize = true;
            this.checkBoxSlowEffect.Location = new System.Drawing.Point(132, 189);
            this.checkBoxSlowEffect.Name = "checkBoxSlowEffect";
            this.checkBoxSlowEffect.Size = new System.Drawing.Size(44, 17);
            this.checkBoxSlowEffect.TabIndex = 34;
            this.checkBoxSlowEffect.Text = "Yes";
            this.checkBoxSlowEffect.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrieviousWounds
            // 
            this.checkBoxGrieviousWounds.AutoSize = true;
            this.checkBoxGrieviousWounds.Location = new System.Drawing.Point(132, 212);
            this.checkBoxGrieviousWounds.Name = "checkBoxGrieviousWounds";
            this.checkBoxGrieviousWounds.Size = new System.Drawing.Size(44, 17);
            this.checkBoxGrieviousWounds.TabIndex = 35;
            this.checkBoxGrieviousWounds.Text = "Yes";
            this.checkBoxGrieviousWounds.UseVisualStyleBackColor = true;
            // 
            // DamageItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 236);
            this.Controls.Add(this.checkBoxGrieviousWounds);
            this.Controls.Add(this.checkBoxSlowEffect);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.checkBoxJungle);
            this.Controls.Add(this.labelGrieviousWounds);
            this.Controls.Add(this.labelSlowEffect);
            this.Controls.Add(this.labelActive);
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
            this.Name = "DamageItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DamageItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.Label labelSlowEffect;
        private System.Windows.Forms.Label labelGrieviousWounds;
        private System.Windows.Forms.CheckBox checkBoxJungle;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.CheckBox checkBoxSlowEffect;
        private System.Windows.Forms.CheckBox checkBoxGrieviousWounds;
    }
}