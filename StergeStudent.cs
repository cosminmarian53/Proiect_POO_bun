﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_POO_bun
{
    public partial class StergeStudent : Form
    {
        public StergeStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server  = localhost; userid = root; password = ; database = poo");
            con.Open();

            string Query = "DELETE FROM studenti WHERE ID = @id";
            MySqlCommand cmd = new MySqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@id", textBox2.Text);




            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
