using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MedioSoft
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-K6Q9EHO\\SQLEXPRESS;Initial Catalog=mediosoft;Integrated Security=True");

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            string totalUsers = "";
            string totalMedicines = "";
            string totalCategories = "";
            string totalOrders = "";
            string totalPharmacists = "";
            string totalCustomers = "";

            //get total Users
            string queryUsers = "SELECT * FROM Users;";
            SqlDataAdapter sda = new SqlDataAdapter(queryUsers, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            totalUsers = dt.Rows.Count.ToString();
            lbl_totalUsersCount.Text = totalUsers;

            //get total Pharmacists
            string queryPharmacists = "SELECT * FROM Users where user_role = 'Pharmacist'";
            SqlDataAdapter sda_Pharmacists = new SqlDataAdapter(queryPharmacists, con);
            DataTable dt_Pharmacists = new DataTable();
            sda_Pharmacists.Fill(dt_Pharmacists);
            totalPharmacists = dt_Pharmacists.Rows.Count.ToString();
            lbl_totalPharmacists.Text = totalPharmacists;

            //get total Customers
            string queryCustomers = "SELECT * FROM Users where user_role = 'Customer'";
            SqlDataAdapter sda_Customers = new SqlDataAdapter(queryCustomers, con);
            DataTable dt_Customers = new DataTable();
            sda_Customers.Fill(dt_Customers);
            totalCustomers = dt_Customers.Rows.Count.ToString();
            lbl_totalCustomers.Text = totalCustomers;

            //get total categories
            string queryCategories = "SELECT * FROM Categories";
            SqlDataAdapter sda_Categories = new SqlDataAdapter(queryCategories, con);
            DataTable dt_Categories = new DataTable();
            sda_Categories.Fill(dt_Categories);
            totalCategories = dt_Categories.Rows.Count.ToString();
            lbl_totalCategoriesCount.Text = totalCategories;

            //get total medicines
            string queryMedicines = "SELECT * FROM Medicines";
            SqlDataAdapter sda_Medicines = new SqlDataAdapter(queryMedicines, con);
            DataTable dt_Medicines = new DataTable();
            sda_Medicines.Fill(dt_Medicines);
            totalMedicines = dt_Medicines.Rows.Count.ToString();
            lbl_totalMedicinesCount.Text = totalMedicines;

            //get total orders
            string queryOrders = "SELECT * FROM Orders";
            SqlDataAdapter sda_Orders = new SqlDataAdapter(queryOrders, con);
            DataTable dt_Orders = new DataTable();
            sda_Orders.Fill(dt_Orders);
            totalOrders = dt_Orders.Rows.Count.ToString();
            lbl_totalOrdersCount.Text = totalOrders;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}
