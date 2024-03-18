using Microsoft.Data.SqlClient;
using System.Data;

namespace HotelFacilityApp.Forms;

public partial class ConnectForm : Form
{
    private const string ConnectionString = @"Data Source=CALEGION\MSSQLSERVER01;Initial Catalog=SWD2_HotelManagement;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
    private static string ConnectionStringNew = string.Empty;
    private SqlConnection cnn;

    public ConnectForm()
    {
        InitializeComponent();
        cnn = new SqlConnection(ConnectionString);
        RefreshData();
    }
    private void Connect_Click(object sender, EventArgs e)
    {
        if (TryOpenConnection())
        {
            MessageBox.Show("Connection Open");
        }
        else if (MessageBox.Show("Do you want to connect to another instance?", "Paste ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            TextBox textBox = new TextBox
            {
                Text = ConnectionString,
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(200, 20)
            };
            this.Controls.Add(textBox);
            ConnectionStringNew = textBox.Text;
            cnn.ConnectionString = ConnectionStringNew;
            if (TryOpenConnection())
            {
                MessageBox.Show("Connection Open");
            }
            else
            {
                MessageBox.Show("Can not open connection");
            }
        }
    }
    private void GetAll_Click(object sender, EventArgs e)
    {
        FetchData("SELECT * FROM Facilities", DataGridView1);
    }
    private void GetAllHotels_Click(object sender, EventArgs e)
    {
        FetchData("SELECT * FROM HotelsWithFacilities", dataGridView2);
    }
    private void AddFacility_Click(object sender, EventArgs e)
    {
        CreateForm createForm = new CreateForm();
        createForm.FormClosed += (s, args) => RefreshData(); // Invoke RefreshData() upon close of CreateForm
        createForm.Show();
    }
    private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        UpdateForm updateForm = new UpdateForm(DataGridView1.Rows[e.RowIndex]);
        updateForm.FormClosed += (s, args) => RefreshData(); // Invoke RefreshData() upon close of UpdateForm
        updateForm.Show();
    }
    private void About_Click(object sender, EventArgs e)
    {
        string message = "This is a simple application to connect to a database and fetch data from it" + Environment.NewLine + Environment.NewLine +
                         "No, as of now you can't assign a Facility to a Hotel - Why? \r\nBecause WinForms generates the equivalent amount of excitement as that getting waterboarded with lukewarm urin.." + Environment.NewLine +
                         "so.. " + Environment.NewLine +
                         "probably next update.." + Environment.NewLine + Environment.NewLine +
                         "This application only works properly if there i the right connection to the Server - definitly a Level one tech problem." + Environment.NewLine + Environment.NewLine +
                         "Hugz 'n' kizzes // DuctTape Solutions";

        MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private bool TryOpenConnection()
    {
        try
        {
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
            return true;
        }
        catch (Exception)
        {
            MessageBox.Show("Can not open connection");
            return false;
        }
    }
    private void FetchData(string query, DataGridView dataGridView)
    {
        if (cnn.State != ConnectionState.Open)
            cnn.Open();
        using (SqlCommand command = new SqlCommand(query, cnn))
        using (SqlDataReader reader = command.ExecuteReader())
        {
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView.DataSource = dataTable;
        }
    }
    private void RefreshData()
    {
        FetchData("SELECT * FROM Facilities", DataGridView1);
    }
}
