namespace HotelFacilityApp.Forms
{
    partial class UpdateForm
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
            FacilityName = new TextBox();
            FacilityDescription = new TextBox();
            UpdateButton = new Button();
            Delete = new Button();
            AddNew = new Button();
            SuspendLayout();
            // 
            // FacilityName
            // 
            FacilityName.BorderStyle = BorderStyle.None;
            FacilityName.Location = new Point(12, 12);
            FacilityName.Multiline = true;
            FacilityName.Name = "FacilityName";
            FacilityName.PlaceholderText = "Facility Name";
            FacilityName.Size = new Size(579, 34);
            FacilityName.TabIndex = 0;
            // 
            // FacilityDescription
            // 
            FacilityDescription.BorderStyle = BorderStyle.None;
            FacilityDescription.Location = new Point(12, 52);
            FacilityDescription.Multiline = true;
            FacilityDescription.Name = "FacilityDescription";
            FacilityDescription.PlaceholderText = "Facility Description";
            FacilityDescription.Size = new Size(579, 89);
            FacilityDescription.TabIndex = 1;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(219, 147);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(120, 40);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += Update_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(345, 147);
            Delete.Name = "Delete";
            Delete.Size = new Size(120, 40);
            Delete.TabIndex = 3;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // AddNew
            // 
            AddNew.Location = new Point(471, 147);
            AddNew.Name = "AddNew";
            AddNew.Size = new Size(120, 40);
            AddNew.TabIndex = 4;
            AddNew.Text = "Add as New";
            AddNew.UseVisualStyleBackColor = true;
            AddNew.Click += AddNew_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 196);
            Controls.Add(AddNew);
            Controls.Add(Delete);
            Controls.Add(UpdateButton);
            Controls.Add(FacilityDescription);
            Controls.Add(FacilityName);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FacilityName;
        private TextBox FacilityDescription;
        private Button UpdateButton;
        private Button Delete;
        private Button AddNew;
    }
}