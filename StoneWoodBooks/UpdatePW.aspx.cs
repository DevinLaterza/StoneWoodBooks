﻿using System;
using System.Web.UI;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace StoneWoodBooks
{
    public partial class UpdatePW : Page
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit(object sender, EventArgs e)
        {
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            cmd.Connection = conn;

            cmd.CommandText = "Select Password From Customer where CID = " + (string)Cache.Get("username") + ";";
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader[0].ToString().Equals(txtPW.Text))
            {
                lblpw.Text = "Please Enter your new password";
                btnSubmit.Enabled = false;
                btnChangePW.Enabled = true;
            }

            else
                lblpw.Text = "Wrong password entered, try typing slowly";


        }

        protected void btnChangePW_Click(object sender, EventArgs e)
        {
            if(btnChangePW.Text.Length == 0)
            {
                lblpw.Text = "Password must have at least one character";
                return;
            }

            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            cmd.Connection = conn;

            cmd.CommandText = "Update Customer Set Password = " + txtPW.Text + ";";
            cmd.ExecuteNonQuery();

            lblpw.Text = "Password changed";


        }
    }
}