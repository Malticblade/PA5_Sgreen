namespace PA5_GreenSteven_PokeDexWithClasses
{
    partial class frmMain
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
            this.grpbxSortBy = new System.Windows.Forms.GroupBox();
            this.btnHeight = new System.Windows.Forms.Button();
            this.btnWeight = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnHP = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.grpbxDisplay = new System.Windows.Forms.GroupBox();
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbxNewPokemon = new System.Windows.Forms.GroupBox();
            this.txtbxType = new System.Windows.Forms.TextBox();
            this.txtbxHeight = new System.Windows.Forms.TextBox();
            this.txtbxWeight = new System.Windows.Forms.TextBox();
            this.txtbxHP = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDataFill = new System.Windows.Forms.Button();
            this.grpbxCurrentSort = new System.Windows.Forms.GroupBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbHP = new System.Windows.Forms.RadioButton();
            this.rbType = new System.Windows.Forms.RadioButton();
            this.rbWeight = new System.Windows.Forms.RadioButton();
            this.rbHeight = new System.Windows.Forms.RadioButton();
            this.grpbxSortBy.SuspendLayout();
            this.grpbxDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            this.gpbxNewPokemon.SuspendLayout();
            this.grpbxCurrentSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxSortBy
            // 
            this.grpbxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxSortBy.Controls.Add(this.btnHeight);
            this.grpbxSortBy.Controls.Add(this.btnWeight);
            this.grpbxSortBy.Controls.Add(this.btnType);
            this.grpbxSortBy.Controls.Add(this.btnHP);
            this.grpbxSortBy.Controls.Add(this.btnName);
            this.grpbxSortBy.Location = new System.Drawing.Point(844, 12);
            this.grpbxSortBy.MinimumSize = new System.Drawing.Size(87, 188);
            this.grpbxSortBy.Name = "grpbxSortBy";
            this.grpbxSortBy.Size = new System.Drawing.Size(87, 190);
            this.grpbxSortBy.TabIndex = 1;
            this.grpbxSortBy.TabStop = false;
            this.grpbxSortBy.Text = "Sort By";
            // 
            // btnHeight
            // 
            this.btnHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHeight.Location = new System.Drawing.Point(6, 145);
            this.btnHeight.Name = "btnHeight";
            this.btnHeight.Size = new System.Drawing.Size(75, 25);
            this.btnHeight.TabIndex = 12;
            this.btnHeight.Text = "Height";
            this.btnHeight.UseVisualStyleBackColor = true;
            this.btnHeight.Click += new System.EventHandler(this.btnHeight_Click);
            // 
            // btnWeight
            // 
            this.btnWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeight.Location = new System.Drawing.Point(6, 114);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(75, 25);
            this.btnWeight.TabIndex = 11;
            this.btnWeight.Text = "Weight";
            this.btnWeight.UseVisualStyleBackColor = true;
            this.btnWeight.Click += new System.EventHandler(this.btnWeight_Click);
            // 
            // btnType
            // 
            this.btnType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnType.Location = new System.Drawing.Point(6, 83);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(75, 25);
            this.btnType.TabIndex = 10;
            this.btnType.Text = "Type";
            this.btnType.UseVisualStyleBackColor = true;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnHP
            // 
            this.btnHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHP.Location = new System.Drawing.Point(6, 52);
            this.btnHP.Name = "btnHP";
            this.btnHP.Size = new System.Drawing.Size(75, 25);
            this.btnHP.TabIndex = 9;
            this.btnHP.Text = "HP";
            this.btnHP.UseVisualStyleBackColor = true;
            this.btnHP.Click += new System.EventHandler(this.btnHP_Click);
            // 
            // btnName
            // 
            this.btnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnName.Location = new System.Drawing.Point(6, 20);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 25);
            this.btnName.TabIndex = 8;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // grpbxDisplay
            // 
            this.grpbxDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxDisplay.Controls.Add(this.dgvPokemon);
            this.grpbxDisplay.Location = new System.Drawing.Point(12, 12);
            this.grpbxDisplay.Name = "grpbxDisplay";
            this.grpbxDisplay.Size = new System.Drawing.Size(826, 306);
            this.grpbxDisplay.TabIndex = 2;
            this.grpbxDisplay.TabStop = false;
            this.grpbxDisplay.Text = "Display";
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.AllowUserToAddRows = false;
            this.dgvPokemon.AllowUserToDeleteRows = false;
            this.dgvPokemon.AllowUserToResizeRows = false;
            this.dgvPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.Location = new System.Drawing.Point(9, 13);
            this.dgvPokemon.MultiSelect = false;
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.ReadOnly = true;
            this.dgvPokemon.RowHeadersVisible = false;
            this.dgvPokemon.RowTemplate.Height = 24;
            this.dgvPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemon.Size = new System.Drawing.Size(809, 281);
            this.dgvPokemon.TabIndex = 2;
            this.dgvPokemon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPokemon_CellContentClick);
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(856, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 25);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "0 Pokemon";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gpbxNewPokemon
            // 
            this.gpbxNewPokemon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbxNewPokemon.Controls.Add(this.txtbxType);
            this.gpbxNewPokemon.Controls.Add(this.txtbxHeight);
            this.gpbxNewPokemon.Controls.Add(this.txtbxWeight);
            this.gpbxNewPokemon.Controls.Add(this.txtbxHP);
            this.gpbxNewPokemon.Controls.Add(this.txtbxName);
            this.gpbxNewPokemon.Controls.Add(this.lblHeight);
            this.gpbxNewPokemon.Controls.Add(this.lblWeight);
            this.gpbxNewPokemon.Controls.Add(this.lblType);
            this.gpbxNewPokemon.Controls.Add(this.lblHP);
            this.gpbxNewPokemon.Controls.Add(this.lblName);
            this.gpbxNewPokemon.Location = new System.Drawing.Point(12, 324);
            this.gpbxNewPokemon.Name = "gpbxNewPokemon";
            this.gpbxNewPokemon.Size = new System.Drawing.Size(826, 190);
            this.gpbxNewPokemon.TabIndex = 15;
            this.gpbxNewPokemon.TabStop = false;
            this.gpbxNewPokemon.Text = "Details";
            // 
            // txtbxType
            // 
            this.txtbxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxType.Location = new System.Drawing.Point(48, 44);
            this.txtbxType.Name = "txtbxType";
            this.txtbxType.ReadOnly = true;
            this.txtbxType.Size = new System.Drawing.Size(772, 20);
            this.txtbxType.TabIndex = 2;
            // 
            // txtbxHeight
            // 
            this.txtbxHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxHeight.Location = new System.Drawing.Point(48, 122);
            this.txtbxHeight.Name = "txtbxHeight";
            this.txtbxHeight.ReadOnly = true;
            this.txtbxHeight.Size = new System.Drawing.Size(772, 20);
            this.txtbxHeight.TabIndex = 5;
            // 
            // txtbxWeight
            // 
            this.txtbxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxWeight.Location = new System.Drawing.Point(48, 96);
            this.txtbxWeight.Name = "txtbxWeight";
            this.txtbxWeight.ReadOnly = true;
            this.txtbxWeight.Size = new System.Drawing.Size(772, 20);
            this.txtbxWeight.TabIndex = 4;
            // 
            // txtbxHP
            // 
            this.txtbxHP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxHP.Location = new System.Drawing.Point(48, 70);
            this.txtbxHP.Name = "txtbxHP";
            this.txtbxHP.ReadOnly = true;
            this.txtbxHP.Size = new System.Drawing.Size(772, 20);
            this.txtbxHP.TabIndex = 3;
            // 
            // txtbxName
            // 
            this.txtbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxName.Location = new System.Drawing.Point(48, 18);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.ReadOnly = true;
            this.txtbxName.Size = new System.Drawing.Size(772, 20);
            this.txtbxName.TabIndex = 1;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged_1);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(7, 127);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 14);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(7, 100);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(40, 14);
            this.lblWeight.TabIndex = 3;
            this.lblWeight.Text = "Weight";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 14);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(7, 74);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 14);
            this.lblHP.TabIndex = 1;
            this.lblHP.Text = "HP";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 14);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(775, 599);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDataFill
            // 
            this.btnDataFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataFill.Location = new System.Drawing.Point(694, 599);
            this.btnDataFill.Name = "btnDataFill";
            this.btnDataFill.Size = new System.Drawing.Size(75, 25);
            this.btnDataFill.TabIndex = 16;
            this.btnDataFill.Text = "DataFill";
            this.btnDataFill.UseVisualStyleBackColor = true;
            this.btnDataFill.Click += new System.EventHandler(this.btnDataFill_Click);
            // 
            // grpbxCurrentSort
            // 
            this.grpbxCurrentSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbxCurrentSort.Controls.Add(this.rbHeight);
            this.grpbxCurrentSort.Controls.Add(this.rbWeight);
            this.grpbxCurrentSort.Controls.Add(this.rbType);
            this.grpbxCurrentSort.Controls.Add(this.rbHP);
            this.grpbxCurrentSort.Controls.Add(this.rbName);
            this.grpbxCurrentSort.Enabled = false;
            this.grpbxCurrentSort.Location = new System.Drawing.Point(844, 208);
            this.grpbxCurrentSort.MinimumSize = new System.Drawing.Size(87, 188);
            this.grpbxCurrentSort.Name = "grpbxCurrentSort";
            this.grpbxCurrentSort.Size = new System.Drawing.Size(87, 188);
            this.grpbxCurrentSort.TabIndex = 17;
            this.grpbxCurrentSort.TabStop = false;
            this.grpbxCurrentSort.Text = "Current Sort";
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbName.Enabled = false;
            this.rbName.Location = new System.Drawing.Point(6, 19);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(52, 18);
            this.rbName.TabIndex = 0;
            this.rbName.TabStop = true;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            // 
            // rbHP
            // 
            this.rbHP.AutoSize = true;
            this.rbHP.Enabled = false;
            this.rbHP.Location = new System.Drawing.Point(6, 43);
            this.rbHP.Name = "rbHP";
            this.rbHP.Size = new System.Drawing.Size(40, 18);
            this.rbHP.TabIndex = 1;
            this.rbHP.TabStop = true;
            this.rbHP.Text = "HP";
            this.rbHP.UseVisualStyleBackColor = true;
            // 
            // rbType
            // 
            this.rbType.AutoSize = true;
            this.rbType.Enabled = false;
            this.rbType.Location = new System.Drawing.Point(6, 67);
            this.rbType.Name = "rbType";
            this.rbType.Size = new System.Drawing.Size(49, 18);
            this.rbType.TabIndex = 2;
            this.rbType.TabStop = true;
            this.rbType.Text = "Type";
            this.rbType.UseVisualStyleBackColor = true;
            // 
            // rbWeight
            // 
            this.rbWeight.AutoSize = true;
            this.rbWeight.Enabled = false;
            this.rbWeight.Location = new System.Drawing.Point(6, 91);
            this.rbWeight.Name = "rbWeight";
            this.rbWeight.Size = new System.Drawing.Size(58, 18);
            this.rbWeight.TabIndex = 3;
            this.rbWeight.TabStop = true;
            this.rbWeight.Text = "Weight";
            this.rbWeight.UseVisualStyleBackColor = true;
            // 
            // rbHeight
            // 
            this.rbHeight.AutoSize = true;
            this.rbHeight.Enabled = false;
            this.rbHeight.Location = new System.Drawing.Point(6, 115);
            this.rbHeight.Name = "rbHeight";
            this.rbHeight.Size = new System.Drawing.Size(56, 18);
            this.rbHeight.TabIndex = 4;
            this.rbHeight.TabStop = true;
            this.rbHeight.Text = "Height";
            this.rbHeight.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(943, 636);
            this.Controls.Add(this.grpbxCurrentSort);
            this.Controls.Add(this.btnDataFill);
            this.Controls.Add(this.gpbxNewPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpbxDisplay);
            this.Controls.Add(this.grpbxSortBy);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(480, 675);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PokeDex";
            this.grpbxSortBy.ResumeLayout(false);
            this.grpbxDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            this.gpbxNewPokemon.ResumeLayout(false);
            this.gpbxNewPokemon.PerformLayout();
            this.grpbxCurrentSort.ResumeLayout(false);
            this.grpbxCurrentSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbxSortBy;
        private System.Windows.Forms.GroupBox grpbxDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHeight;
        private System.Windows.Forms.Button btnWeight;
        private System.Windows.Forms.Button btnHP;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.GroupBox gpbxNewPokemon;
        private System.Windows.Forms.TextBox txtbxType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxHeight;
        private System.Windows.Forms.TextBox txtbxWeight;
        private System.Windows.Forms.TextBox txtbxHP;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDataFill;
        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.GroupBox grpbxCurrentSort;
        private System.Windows.Forms.RadioButton rbHeight;
        private System.Windows.Forms.RadioButton rbWeight;
        private System.Windows.Forms.RadioButton rbType;
        private System.Windows.Forms.RadioButton rbHP;
        private System.Windows.Forms.RadioButton rbName;
    }
}

