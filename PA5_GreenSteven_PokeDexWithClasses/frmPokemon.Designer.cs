namespace PA5_GreenSteven_PokeDexWithClasses
{
    partial class frmPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokemon));
            this.gpbxNewPokemon = new System.Windows.Forms.GroupBox();
            this.cbxHeight = new System.Windows.Forms.ComboBox();
            this.cbxWeight = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtbxHeight = new System.Windows.Forms.TextBox();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.txtbxHP = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gpbxNewPokemon.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxNewPokemon
            // 
            this.gpbxNewPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxNewPokemon.Controls.Add(this.cbxHeight);
            this.gpbxNewPokemon.Controls.Add(this.cbxWeight);
            this.gpbxNewPokemon.Controls.Add(this.cbxType);
            this.gpbxNewPokemon.Controls.Add(this.btnCancel);
            this.gpbxNewPokemon.Controls.Add(this.btnSave);
            this.gpbxNewPokemon.Controls.Add(this.txtbxHeight);
            this.gpbxNewPokemon.Controls.Add(this.txtbxWeight);
            this.gpbxNewPokemon.Controls.Add(this.txtbxHP);
            this.gpbxNewPokemon.Controls.Add(this.txtbxName);
            this.gpbxNewPokemon.Controls.Add(this.lblHeight);
            this.gpbxNewPokemon.Controls.Add(this.lblWeight);
            this.gpbxNewPokemon.Controls.Add(this.lblType);
            this.gpbxNewPokemon.Controls.Add(this.lblHP);
            this.gpbxNewPokemon.Controls.Add(this.lblName);
            this.gpbxNewPokemon.Location = new System.Drawing.Point(1, 3);
            this.gpbxNewPokemon.Name = "gpbxNewPokemon";
            this.gpbxNewPokemon.Size = new System.Drawing.Size(370, 211);
            this.gpbxNewPokemon.TabIndex = 1;
            this.gpbxNewPokemon.TabStop = false;
            this.gpbxNewPokemon.Text = "New Pokemon";
            // 
            // cbxHeight
            // 
            this.cbxHeight.AllowDrop = true;
            this.cbxHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHeight.FormattingEnabled = true;
            this.cbxHeight.Items.AddRange(new object[] {
            "in",
            "m"});
            this.cbxHeight.Location = new System.Drawing.Point(289, 121);
            this.cbxHeight.Name = "cbxHeight";
            this.cbxHeight.Size = new System.Drawing.Size(75, 21);
            this.cbxHeight.Sorted = true;
            this.cbxHeight.TabIndex = 7;
            this.cbxHeight.SelectedIndexChanged += new System.EventHandler(this.cbxHeight_SelectedIndexChanged);
            // 
            // cbxWeight
            // 
            this.cbxWeight.AllowDrop = true;
            this.cbxWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWeight.FormattingEnabled = true;
            this.cbxWeight.Items.AddRange(new object[] {
            "kg",
            "oz"});
            this.cbxWeight.Location = new System.Drawing.Point(289, 95);
            this.cbxWeight.Name = "cbxWeight";
            this.cbxWeight.Size = new System.Drawing.Size(75, 21);
            this.cbxWeight.Sorted = true;
            this.cbxWeight.TabIndex = 6;
            this.cbxWeight.SelectedIndexChanged += new System.EventHandler(this.cbxWeight_SelectedIndexChanged);
            // 
            // cbxType
            // 
            this.cbxType.AllowDrop = true;
            this.cbxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "Bug",
            "Dark",
            "Dragon",
            "Electric",
            "Fairy",
            "Fighting",
            "Fire",
            "Flying",
            "Ghost",
            "Grass",
            "Ground",
            "Ice",
            "Normal",
            "Poison",
            "Psychic",
            "Rock",
            "Steel",
            "Whater"});
            this.cbxType.Location = new System.Drawing.Point(48, 43);
            this.cbxType.MaxDropDownItems = 18;
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(316, 21);
            this.cbxType.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(208, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(289, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtbxHeight
            // 
            this.txtbxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxHeight.Location = new System.Drawing.Point(48, 122);
            this.txtbxHeight.Name = "txtbxHeight";
            this.txtbxHeight.Size = new System.Drawing.Size(235, 20);
            this.txtbxHeight.TabIndex = 5;
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxWeight.Location = new System.Drawing.Point(48, 96);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.Size = new System.Drawing.Size(235, 20);
            this.txtbxWeight.TabIndex = 4;
            // 
            // txtbxHP
            // 
            this.txtbxHP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxHP.Location = new System.Drawing.Point(48, 70);
            this.txtbxHP.Name = "txtbxHP";
            this.txtbxHP.Size = new System.Drawing.Size(316, 20);
            this.txtbxHP.TabIndex = 3;
            // 
            // txtbxName
            // 
            this.txtbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxName.Location = new System.Drawing.Point(48, 18);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(316, 20);
            this.txtbxName.TabIndex = 1;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(7, 127);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(7, 100);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(7, 74);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 13);
            this.lblHP.TabIndex = 1;
            this.lblHP.Text = "HP";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // frmPokemon
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(374, 215);
            this.Controls.Add(this.gpbxNewPokemon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Pokemon";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmPokemon_Load);
            this.gpbxNewPokemon.ResumeLayout(false);
            this.gpbxNewPokemon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxNewPokemon;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtbxHeight;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.TextBox txtbxHP;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbxWeight;
        private System.Windows.Forms.ComboBox cbxHeight;
    }
}