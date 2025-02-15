﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ADIbanking
{
    public partial class Savings_payee : UserControl
    {
        public Savings_payee()
        {
            InitializeComponent();
        }
        
        MySqlConnection connect = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=retailbankdb;convert Zero Datetime=True");
        private void Savings_payee_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Payee", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
                                                            

            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM savings_handles WHERE Username = '" + Savings_login.uName + "'";
            MySqlDataReader myReader;

            try
            {
                connect.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    Balance.Text = myReader["balance"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        private void paypayee_Click(object sender, EventArgs e)
        {
            MySqlCommand command = connect.CreateCommand();

            try
            {
                    if (Balance.Text == "0.00")
                    {
                    MessageBox.Show(Amount, "You don't have enough funds Please make a deposite");
                    }
                    else if (double.Parse(Amount.Text) >= 100)
                    {
                  
                        connect.Open();
                        command.CommandText = "Update Savings_handles set Balance = Balance - '" + double.Parse(Amount.Text) + "' WHERE Username = '" + Savings_login.uName + "'";
                        command.ExecuteNonQuery();
                        command.CommandText = "Update Payee set Amount = Amount + '" + double.Parse(Amount.Text) + "' WHERE  Id = '" + Payee_name.Text + "' ";
                        command.ExecuteNonQuery();

                        MessageBox.Show("Transaction Added Succesfully....");

                    }
                
                   else 
                    {
                        MessageBox.Show(Amount, "minimum cash 100");
                    }
                     

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
                Amount.Clear();
                Payee_name.Clear();
                Balance.Refresh();
                Balance.Update();
                dataGridView1.Refresh();
            }
        }

        private void Addpayee_Click(object sender, EventArgs e)
        {
            Savings.Savings_add_payee sdp = new  Savings.Savings_add_payee();
            sdp.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Payee", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;
        }

        private void paypayee_MouseClick(object sender, MouseEventArgs e)
        {
            MySqlDataAdapter My = new MySqlDataAdapter("SELECT * FROM Payee", connect);
            DataTable dTable = new DataTable();
            My.Fill(dTable);
            dataGridView1.DataSource = dTable;


            MySqlCommand command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM savings_handles WHERE Username = '" + Savings_login.uName + "'";
            MySqlDataReader myReader;

            try
            {
                connect.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    Balance.Text = myReader["balance"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();

        }

         
    }
}
