namespace HotelFacilityApp.Forms
{
    partial class ConnectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            Connect = new Button();
            GetAll = new Button();
            GetAllHotels = new Button();
            AddFacility = new Button();
            dataGridView2 = new DataGridView();
            DataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            About = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Connect
            // 
            Connect.Location = new Point(872, 891);
            Connect.Name = "Connect";
            Connect.Size = new Size(153, 44);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // GetAll
            // 
            GetAll.Location = new Point(171, 891);
            GetAll.Name = "GetAll";
            GetAll.Size = new Size(153, 44);
            GetAll.TabIndex = 1;
            GetAll.Text = "GetAll";
            GetAll.UseVisualStyleBackColor = true;
            GetAll.Click += GetAll_Click;
            // 
            // GetAllHotels
            // 
            GetAllHotels.Location = new Point(12, 891);
            GetAllHotels.Name = "GetAllHotels";
            GetAllHotels.Size = new Size(153, 44);
            GetAllHotels.TabIndex = 4;
            GetAllHotels.Text = "GetAllHotels";
            GetAllHotels.UseVisualStyleBackColor = true;
            GetAllHotels.Click += GetAllHotels_Click;
            // 
            // AddFacility
            // 
            AddFacility.Location = new Point(330, 891);
            AddFacility.Name = "AddFacility";
            AddFacility.Size = new Size(153, 44);
            AddFacility.TabIndex = 5;
            AddFacility.Text = "Add Facility";
            AddFacility.UseVisualStyleBackColor = true;
            AddFacility.Click += AddFacility_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1013, 317);
            dataGridView2.TabIndex = 7;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(12, 357);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 62;
            DataGridView1.Size = new Size(1013, 398);
            DataGridView1.TabIndex = 8;
            DataGridView1.RowHeaderMouseDoubleClick += DataGridView1_RowHeaderMouseDoubleClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(12, 771);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1013, 96);
            textBox1.TabIndex = 9;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // About
            // 
            About.Location = new Point(713, 891);
            About.Name = "About";
            About.Size = new Size(153, 44);
            About.TabIndex = 10;
            About.Text = "About";
            About.UseVisualStyleBackColor = true;
            About.Click += About_Click;
            // 
            // ConnectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 944);
            Controls.Add(About);
            Controls.Add(textBox1);
            Controls.Add(DataGridView1);
            Controls.Add(dataGridView2);
            Controls.Add(AddFacility);
            Controls.Add(GetAllHotels);
            Controls.Add(GetAll);
            Controls.Add(Connect);
            Name = "ConnectForm";
            Text = "ConnectForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Connect;
        private Button GetAll;
        private Button GetAllHotels;
        private Button AddFacility;
        private DataGridView dataGridView2;
        private DataGridView DataGridView1;
        private TextBox textBox1;
        private Button About;
    }
}