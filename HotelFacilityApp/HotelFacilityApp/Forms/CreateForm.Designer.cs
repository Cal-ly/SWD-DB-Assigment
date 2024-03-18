namespace HotelFacilityApp.Forms
{
    partial class CreateForm
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
            AddFacilityToDB = new Button();
            button1 = new Button();
            FacilityDescription = new TextBox();
            FacilityName = new TextBox();
            SuspendLayout();
            // 
            // AddFacilityToDB
            // 
            AddFacilityToDB.Location = new Point(466, 147);
            AddFacilityToDB.Name = "AddFacilityToDB";
            AddFacilityToDB.Size = new Size(120, 40);
            AddFacilityToDB.TabIndex = 2;
            AddFacilityToDB.Text = "Add Facility";
            AddFacilityToDB.UseVisualStyleBackColor = true;
            AddFacilityToDB.Click += AddFacilityToDB_Click;
            // 
            // button1
            // 
            button1.Location = new Point(410, 110);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FacilityDescription
            // 
            FacilityDescription.BorderStyle = BorderStyle.None;
            FacilityDescription.Location = new Point(12, 52);
            FacilityDescription.Multiline = true;
            FacilityDescription.Name = "FacilityDescription";
            FacilityDescription.PlaceholderText = "Facility Description";
            FacilityDescription.Size = new Size(579, 89);
            FacilityDescription.TabIndex = 7;
            // 
            // FacilityName
            // 
            FacilityName.BorderStyle = BorderStyle.None;
            FacilityName.Location = new Point(12, 12);
            FacilityName.Multiline = true;
            FacilityName.Name = "FacilityName";
            FacilityName.PlaceholderText = "Facility Name";
            FacilityName.Size = new Size(579, 34);
            FacilityName.TabIndex = 6;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 199);
            Controls.Add(FacilityDescription);
            Controls.Add(FacilityName);
            Controls.Add(button1);
            Controls.Add(AddFacilityToDB);
            Name = "CreateForm";
            Text = "CreateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddFacilityToDB;
        private Button button1;
        private TextBox FacilityDescription;
        private TextBox FacilityName;
    }
}