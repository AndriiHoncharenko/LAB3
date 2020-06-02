namespace MessagesForm
{
    partial class Messages
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
            this.messageslistView = new System.Windows.Forms.ListView();
            this.userCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messagesCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearButton = new System.Windows.Forms.Button();
            this.MessageGeneration = new System.Windows.Forms.GroupBox();
            this.disableButton = new System.Windows.Forms.RadioButton();
            this.enableButton = new System.Windows.Forms.RadioButton();
            this.formatingComboBox = new System.Windows.Forms.ComboBox();
            this.formatingGroupBox = new System.Windows.Forms.GroupBox();
            this.filterBox = new System.Windows.Forms.GroupBox();
            this.toDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.textLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.ComboBox();
            this.FilteredShow = new System.Windows.Forms.Button();
            this.MessageGeneration.SuspendLayout();
            this.formatingGroupBox.SuspendLayout();
            this.filterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageslistView
            // 
            this.messageslistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userCol,
            this.messagesCol});
            this.messageslistView.FullRowSelect = true;
            this.messageslistView.GridLines = true;
            this.messageslistView.Location = new System.Drawing.Point(12, 125);
            this.messageslistView.Name = "messageslistView";
            this.messageslistView.Size = new System.Drawing.Size(384, 200);
            this.messageslistView.TabIndex = 0;
            this.messageslistView.TileSize = new System.Drawing.Size(250, 30);
            this.messageslistView.UseCompatibleStateImageBehavior = false;
            this.messageslistView.View = System.Windows.Forms.View.Tile;
            // 
            // userCol
            // 
            this.userCol.Text = "Abonent";
            // 
            // messagesCol
            // 
            this.messagesCol.Text = "Message Text";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(402, 284);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 41);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MessageGeneration
            // 
            this.MessageGeneration.Controls.Add(this.disableButton);
            this.MessageGeneration.Controls.Add(this.enableButton);
            this.MessageGeneration.Location = new System.Drawing.Point(12, 12);
            this.MessageGeneration.Name = "MessageGeneration";
            this.MessageGeneration.Size = new System.Drawing.Size(131, 107);
            this.MessageGeneration.TabIndex = 2;
            this.MessageGeneration.TabStop = false;
            this.MessageGeneration.Text = "MessageGeneration";
            // 
            // disableButton
            // 
            this.disableButton.AutoSize = true;
            this.disableButton.Location = new System.Drawing.Point(19, 72);
            this.disableButton.Name = "disableButton";
            this.disableButton.Size = new System.Drawing.Size(60, 17);
            this.disableButton.TabIndex = 1;
            this.disableButton.Text = "Disable";
            this.disableButton.UseVisualStyleBackColor = true;
            // 
            // enableButton
            // 
            this.enableButton.AutoSize = true;
            this.enableButton.Checked = true;
            this.enableButton.Location = new System.Drawing.Point(19, 40);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(58, 17);
            this.enableButton.TabIndex = 0;
            this.enableButton.TabStop = true;
            this.enableButton.Text = "Enable";
            this.enableButton.UseVisualStyleBackColor = true;
            this.enableButton.CheckedChanged += new System.EventHandler(this.enableButton_CheckedChanged);
            // 
            // formatingComboBox
            // 
            this.formatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatingComboBox.FormattingEnabled = true;
            this.formatingComboBox.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "Uppercase"});
            this.formatingComboBox.Location = new System.Drawing.Point(16, 28);
            this.formatingComboBox.Name = "formatingComboBox";
            this.formatingComboBox.Size = new System.Drawing.Size(112, 21);
            this.formatingComboBox.TabIndex = 3;
            this.formatingComboBox.SelectedIndexChanged += new System.EventHandler(this.formatingComboBox_SelectedIndexChanged);
            // 
            // formatingGroupBox
            // 
            this.formatingGroupBox.Controls.Add(this.formatingComboBox);
            this.formatingGroupBox.Location = new System.Drawing.Point(151, 12);
            this.formatingGroupBox.Name = "formatingGroupBox";
            this.formatingGroupBox.Size = new System.Drawing.Size(138, 106);
            this.formatingGroupBox.TabIndex = 4;
            this.formatingGroupBox.TabStop = false;
            this.formatingGroupBox.Text = "Formating Options";
            // 
            // filterBox
            // 
            this.filterBox.Controls.Add(this.FilteredShow);
            this.filterBox.Controls.Add(this.toDatePicker);
            this.filterBox.Controls.Add(this.fromDatePicker);
            this.filterBox.Controls.Add(this.textLabel);
            this.filterBox.Controls.Add(this.UserLabel);
            this.filterBox.Controls.Add(this.textBox);
            this.filterBox.Controls.Add(this.userBox);
            this.filterBox.Location = new System.Drawing.Point(402, 12);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(161, 266);
            this.filterBox.TabIndex = 5;
            this.filterBox.TabStop = false;
            this.filterBox.Text = "Filtering Options";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(12, 182);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(132, 20);
            this.toDatePicker.TabIndex = 5;
            this.toDatePicker.UseWaitCursor = true;
            this.toDatePicker.ValueChanged += new System.EventHandler(this.toDatePicker_ValueChanged);
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(12, 132);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(132, 20);
            this.fromDatePicker.TabIndex = 4;
            this.fromDatePicker.Value = new System.DateTime(2020, 1, 1, 10, 43, 0, 0);
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(16, 70);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(28, 13);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Text";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(16, 20);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(29, 13);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "User";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 86);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(132, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // userBox
            // 
            this.userBox.FormattingEnabled = true;
            this.userBox.Items.AddRange(new object[] {
            "No filter",
            "A",
            "B",
            "C",
            "D"});
            this.userBox.Location = new System.Drawing.Point(12, 38);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(132, 21);
            this.userBox.TabIndex = 0;
            this.userBox.SelectedIndexChanged += new System.EventHandler(this.userBox_SelectedIndexChanged);
            // 
            // FilteredShow
            // 
            this.FilteredShow.Location = new System.Drawing.Point(54, 221);
            this.FilteredShow.Name = "FilteredShow";
            this.FilteredShow.Size = new System.Drawing.Size(90, 28);
            this.FilteredShow.TabIndex = 6;
            this.FilteredShow.Text = "Show filtered";
            this.FilteredShow.UseVisualStyleBackColor = true;
            this.FilteredShow.Click += new System.EventHandler(this.FilteredShow_Click);
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 343);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.formatingGroupBox);
            this.Controls.Add(this.MessageGeneration);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.messageslistView);
            this.MaximizeBox = false;
            this.Name = "Messages";
            this.Text = "Messages Form";
            this.MessageGeneration.ResumeLayout(false);
            this.MessageGeneration.PerformLayout();
            this.formatingGroupBox.ResumeLayout(false);
            this.filterBox.ResumeLayout(false);
            this.filterBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView messageslistView;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox MessageGeneration;
        private System.Windows.Forms.RadioButton disableButton;
        private System.Windows.Forms.RadioButton enableButton;
        private System.Windows.Forms.ComboBox formatingComboBox;
        private System.Windows.Forms.GroupBox formatingGroupBox;
        private System.Windows.Forms.ColumnHeader userCol;
        private System.Windows.Forms.ColumnHeader messagesCol;
        private System.Windows.Forms.GroupBox filterBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox userBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.DateTimePicker toDatePicker;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
        private System.Windows.Forms.Button FilteredShow;
    }
}

