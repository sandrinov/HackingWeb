using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using VulnerableApp.ORM;

namespace VulnerableApp.Injection
{
    public partial class ExecuteSQL : System.Web.UI.Page
    {
        /// <summary>
        /// try those query
        ///  -----------------------------  GET DB SCHEMA   ----------------
        ///  where CategoryID='1'
        ///  union ALL
        ///  select 0,
        ///	 INFORMATION_SCHEMA.TABLES.TABLE_NAME,
        ///	 0,
        ///	 0,
        ///	 NULL,
        ///	 NULL,
        ///	 0,
        ///	 0,
        ///  0,
        ///  NULL
        ///  FROM INFORMATION_SCHEMA.TABLES
        /// 
        /// --------------------   GET TABLE Employees SCHEMA  --------------
        /// 
        ///   where CategoryID='1'
        ///   union ALL
        ///   select 0,
        ///       INFORMATION_SCHEMA.COLUMNS.COLUMN_NAME,
        ///       0,
        ///       0,
        ///       NULL,
        ///       NULL,
        ///       0,
        ///       0,
        ///       0,
        ///       NULL
        ///  FROM INFORMATION_SCHEMA.COLUMNS
        ///  where TABLE_NAME = 'Employees'
        /// 
        /// --------------------   GET Employees DATA  --------------
        /// 
        /// select Employees.EmployeeID,
        ///     Employees.FirstName,
        ///     0,
        ///     0,
        ///     Employees.LastName,
        ///     NULL,
        ///     0,
        ///     0,
        ///     0,
        ///     NULL
        ///     FROM Employees
        /// 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            InsaneFillGrid();
            //FixedWithRegExp();
            //FixedWithStoredProcedure();
            //FixedWithNamedParameters();
            //UsingLinqToSql();
        }

        private void UsingLinqToSql()
        {
            var catID = Request.QueryString["CategoryID"];
            var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            var dc = new NorthwindClassesDataContext(connString);
            var catIDInt = Convert.ToInt16(catID);
            grdProducts.DataSource = 
                dc.Products.Where(p => p.CategoryID == catIDInt);
            grdProducts.DataBind();
        }

        private void FixedWithNamedParameters()
        {
            var catID = Request.QueryString["CategoryID"];
            const string sqlString = "SELECT * FROM Products WHERE CategoryID = @CategoryID";
            var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            using (var conn = new SqlConnection(connString))
            {
                var command = new SqlCommand(sqlString, conn);
                command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = catID;
                command.Connection.Open();
                grdProducts.DataSource = command.ExecuteReader();
                grdProducts.DataBind();
            }
        }

        private void FixedWithStoredProcedure()
        {
            var catID = Request.QueryString["CategoryID"];
            var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;

            var conn = new SqlConnection(connString);
            using (var command = new SqlCommand("GetProducts", conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@CategoryID", SqlDbType.Int).Value = catID;
                command.Connection.Open();
                grdProducts.DataSource = command.ExecuteReader();
                grdProducts.DataBind();
            }
        }

        private void FixedWithRegExp()
        {
            var catID = Request.QueryString["CategoryID"];
            var positiveIntRegex = new Regex(@"^0*[1-9][0-9]*$");
            if (!positiveIntRegex.IsMatch(catID))
            {
                lblResults.Text = "An invalid CategoryID has been specified.";
                return;
            }
            var sqlString = "SELECT * FROM Products WHERE CategoryID = " + catID;
            var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            using (var conn = new SqlConnection(connString))
            {
                var command = new SqlCommand(sqlString, conn);
                command.Connection.Open();
                grdProducts.DataSource = command.ExecuteReader();
                grdProducts.DataBind();
            }
        }

        private void InsaneFillGrid()
        {
            var catID = Request.QueryString["CategoryID"];
            var sqlString = "SELECT * FROM Products WHERE CategoryID = " + catID;
            var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            using (var conn = new SqlConnection(connString))
            {
                var command = new SqlCommand(sqlString, conn);
                command.Connection.Open();
                grdProducts.DataSource = command.ExecuteReader();
                grdProducts.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //var catID = Request.QueryString["CategoryID"];
            //var sqlString = "SELECT * FROM Products WHERE CategoryID = " + catID;
            //var connString = WebConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString;
            //using (var conn = new SqlConnection(connString))
            //{
            //    var command = new SqlCommand(sqlString, conn);
            //    command.Connection.Open();
            //    grdProducts.DataSource = command.ExecuteReader();
            //    grdProducts.DataBind();
            //}

            //InsaneFillGrid();
            //FixedWithRegExp();
            //FixedWithStoredProcedure();
            //FixedWithNamedParameters();
            //UsingLinqToSql();
        }
    }
}