using Microsoft.Data.SqlClient;
using System.Data;

namespace HotelFacilityApp.Forms;

public partial class CreateForm : Form
{
    private const string ConnectionString = @"Data Source=CALEGION\MSSQLSERVER01;Initial Catalog=SWD2_HotelManagement;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
    private SqlConnection cnn;

    public CreateForm()
    {
        InitializeComponent();
        cnn = new SqlConnection(ConnectionString);
    }

    private void AddFacilityToDB_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(FacilityName.Text))
        {
            MessageBox.Show("Facility name is required.");
            return;
        }

        if (string.IsNullOrWhiteSpace(FacilityDescription.Text))
        {
            MessageBox.Show("Facility description is required.");
            return;
        }

        string query = "INSERT INTO Facilities (Name, Description) VALUES (@FacilityName, @FacilityDescription)";
        using (SqlCommand command = new SqlCommand(query, cnn))
        {
            command.Parameters.AddWithValue("@FacilityName", FacilityName.Text);
            command.Parameters.AddWithValue("@FacilityDescription", FacilityDescription.Text);

            try
            {
                if (cnn.State != ConnectionState.Open)
                    cnn.Open();
                command.ExecuteNonQuery();
                this.Close(); // Close the form after the query has been successfully added
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the facility: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FacilityName.Text = string.Empty; // Reset the FacilityName field
                FacilityDescription.Text = string.Empty; // Reset the FacilityDescription field
            }
        }
    }
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        base.OnFormClosed(e);
        this.Dispose();
    }
}
