using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiptuning_Company_V7
{
    class SQLFunctions
    {
        static private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=CompanyDb;Integrated Security=True;Pooling=False");

        static public void Refresh(DataGridView _dataGridView)
        {
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT Vin, Make, Model, Year, Displacement, Fuel, Power FROM [Car]", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void Select(DataGridView _dataGridView, string _make)
        {
            try
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                dataAdapter.SelectCommand = new SqlCommand("SELECT Vin, Make, Model, Year, Displacement, Fuel, Power FROM [Car] WHERE Make = @make", connection);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@make", _make);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _dataGridView.DataSource = dataTable;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void Insert(string _vin, string _make, string _model, string _year, string _displacement, string _fuel, string _power)
        {
            try
            {
                connection.Open();
                SqlCommand commandInsert = new SqlCommand("INSERT INTO [Car] VALUES(@vin, @make, @model, @year, @displacement, @fuel, @power, null)", connection);
                commandInsert.Parameters.AddWithValue("@vin", _vin);
                commandInsert.Parameters.AddWithValue("@make", _make);
                commandInsert.Parameters.AddWithValue("@model", _model);
                commandInsert.Parameters.AddWithValue("@year", _year);
                commandInsert.Parameters.AddWithValue("@displacement", _displacement);
                commandInsert.Parameters.AddWithValue("@fuel", _fuel);
                commandInsert.Parameters.AddWithValue("@power", _power);

                commandInsert.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void Delete(string _vin)
        {
            try
            {
                connection.Open();
                SqlCommand commandDelete = new SqlCommand("DELETE FROM [Car] WHERE Vin = @vin", connection);
                commandDelete.Parameters.AddWithValue("@vin", _vin);
                commandDelete.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        static public void Update(string _vin, string _make, string _model, string _year, string _displacement, string _fuel, string _power)
        {
            try
            {
                connection.Open();
                SqlCommand commandUpdate = new SqlCommand("Update [Car] SET Make = @make, Model = @model, Year = @year, "
                    + "Displacement = @displacement, Fuel = @fuel, Power = @power "
                    + "WHERE Vin = @vin", connection);
                commandUpdate.Parameters.AddWithValue("@make", _make);
                commandUpdate.Parameters.AddWithValue("@model", _model);
                commandUpdate.Parameters.AddWithValue("@year", _year);
                commandUpdate.Parameters.AddWithValue("@displacement", _displacement);
                commandUpdate.Parameters.AddWithValue("@fuel", _fuel);
                commandUpdate.Parameters.AddWithValue("@power", _power);
                commandUpdate.Parameters.AddWithValue("@vin", _vin);

                commandUpdate.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
