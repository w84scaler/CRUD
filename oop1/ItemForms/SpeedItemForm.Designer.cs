namespace oop1
{
    partial class SpeedItemForm
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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.labelJungle = new System.Windows.Forms.Label();
            this.textBoxCritChance = new System.Windows.Forms.TextBox();
            this.textBoxAttackSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMoveSpeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxJungle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(12, 12);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(134, 66);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescription.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 69);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(134, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(12, 95);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(33, 13);
            this.labelLevel.TabIndex = 11;
            this.labelLevel.Text = "Level";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "Basic",
            "Advanced",
            "Finished"});
            this.comboBoxLevel.Location = new System.Drawing.Point(134, 92);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLevel.TabIndex = 13;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(12, 122);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(28, 13);
            this.labelCost.TabIndex = 14;
            this.labelCost.Text = "Cost";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(134, 119);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 15;
            // 
            // labelJungle
            // 
            this.labelJungle.AutoSize = true;
            this.labelJungle.Location = new System.Drawing.Point(12, 147);
            this.labelJungle.Name = "labelJungle";
            this.labelJungle.Size = new System.Drawing.Size(38, 13);
            this.labelJungle.TabIndex = 16;
            this.labelJungle.Text = "Jungle";
            // 
            // textBoxCritChance
            // 
            this.textBoxCritChance.Location = new System.Drawing.Point(134, 199);
            this.textBoxCritChance.Name = "textBoxCritChance";
            this.textBoxCritChance.Size = new System.Drawing.Size(100, 20);
            this.textBoxCritChance.TabIndex = 20;
            // 
            // textBoxAttackSpeed
            // 
            this.textBoxAttackSpeed.Location = new System.Drawing.Point(134, 173);
            this.textBoxAttackSpeed.Name = "textBoxAttackSpeed";
            this.textBoxAttackSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxAttackSpeed.TabIndex = 22;
            // 
            // textBoxMoveSpeed
            // 
            this.textBoxMoveSpeed.Location = new System.Drawing.Point(134, 225);
            this.textBoxMoveSpeed.Name = "textBoxMoveSpeed";
            this.textBoxMoveSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxMoveSpeed.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "MoveSpeed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "CritChance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "AttackSpeed";
            // 
            // checkBoxJungle
            // 
            this.checkBoxJungle.AutoSize = true;
            this.checkBoxJungle.Location = new System.Drawing.Point(134, 146);
            this.checkBoxJungle.Name = "checkBoxJungle";
            this.checkBoxJungle.Size = new System.Drawing.Size(44, 17);
            this.checkBoxJungle.TabIndex = 27;
            this.checkBoxJungle.Text = "Yes";
            this.checkBoxJungle.UseVisualStyleBackColor = true;
            // 
            // SpeedItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 251);
            this.Controls.Add(this.checkBoxJungle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMoveSpeed);
            this.Controls.Add(this.textBoxAttackSpeed);
            this.Controls.Add(this.textBoxCritChance);
            this.Controls.Add(this.labelJungle);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonCreate);
            this.Name = "SpeedItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpeedItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label labelJungle;
        private System.Windows.Forms.TextBox textBoxCritChance;
        private System.Windows.Forms.TextBox textBoxAttackSpeed;
        private System.Windows.Forms.TextBox textBoxMoveSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxJungle;
    }
}