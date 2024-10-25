/* Codes here... */
private void UpdateDataGridView(string searchTerm)
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            // Open SQL connection
            connection.Open();

            // Define SQL query with a parameterized search term
            string query = "SELECT * FROM Employees WHERE Name LIKE @searchTerm";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Add a parameter for the search term to prevent SQL injection
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                // Execute query and load data into DataTable
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Bind DataTable to DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
/* Codes here... */
