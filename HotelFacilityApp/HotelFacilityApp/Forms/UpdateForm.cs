using Microsoft.Data.SqlClient;

namespace HotelFacilityApp.Forms;

public partial class UpdateForm : Form
{
    private DataGridViewRow selectedRow;
    private const string connectionString = @"Data Source=CALEGION\MSSQLSERVER01;Initial Catalog=SWD2_HotelManagement;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";

    public UpdateForm(DataGridViewRow selectedRow)
    {
        InitializeComponent();
        this.selectedRow = selectedRow;
        FacilityName.Text = selectedRow.Cells["Name"].Value.ToString();
        FacilityDescription.Text = selectedRow.Cells["Description"].Value.ToString();
    }


    private void Update_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(FacilityName.Text) || string.IsNullOrWhiteSpace(FacilityDescription.Text))
        {
            MessageBox.Show("Both facility name and description are required.");
            return;
        }
        if (MessageBox.Show("Are you sure you want to update this facility?", "Update Facility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }

        ExecuteNonQuery("UPDATE Facilities SET Name = @FacilityName, Description = @FacilityDescription WHERE FacilityID = @FacilityID", FacilityName.Text, FacilityDescription.Text);
        this.Close();
    }

    private void Delete_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to delete this facility?", "Delete Facility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }

        ExecuteNonQuery("DELETE FROM Facilities WHERE FacilityID = @FacilityID");
        this.Close();
    }

    private void ExecuteNonQuery(string query, string? facilityName = null, string? facilityDescription = null)
    {
        using (SqlConnection cnn = new SqlConnection(connectionString))
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, cnn))
                {
                    if (!string.IsNullOrEmpty(facilityName))
                    {
                        command.Parameters.AddWithValue("@FacilityName", facilityName);
                    }
                    if (!string.IsNullOrEmpty(facilityDescription))
                    {
                        command.Parameters.AddWithValue("@FacilityDescription", facilityDescription);
                    }
                    command.Parameters.AddWithValue("@FacilityId", selectedRow.Cells["FacilityId"].Value);
                    cnn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while executing the SQL command: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    private void AddNew_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(FacilityName.Text) || string.IsNullOrWhiteSpace(FacilityDescription.Text))
        {
            MessageBox.Show("Both facility name and description are required.");
            return;
        }

        if (MessageBox.Show("Are you sure you want to add this facility?", "Add Facility", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }

        ExecuteNonQuery("INSERT INTO Facilities (Name, Description) VALUES (@FacilityName, @FacilityDescription)", FacilityName.Text, FacilityDescription.Text);
        this.Close();
    }
}
