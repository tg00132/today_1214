﻿using CarManager0323.DB;
using CarManager0323.UI;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0323
{
    public partial class MainForm : MaterialForm
    {
        DaoOracle ora = new DaoOracle();
        public MainForm()
        {
            
            InitializeComponent();
        }

        MainForm(DaoOracle oracle)
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {          
            //ora.dbConnect();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ora.dbClose();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ora.createAllTB();
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            ora.dropAllTB();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            /*ora.insertCar();
            ora.insertCustomer();
            ora.insertSeller();
            ora.insertDeal();*/
        }

        private void insertCar_Click(object sender, EventArgs e)
        {
            new CarInsForm(ora).ShowDialog();
        }

        private void insertCustomer_Click(object sender, EventArgs e)
        {
            new CustInsForm(ora).ShowDialog();
        }

        private void insertSeller_Click(object sender, EventArgs e)
        {
            new SellerInsFormcs(ora).ShowDialog();
        }

        private void insertDeal_Click(object sender, EventArgs e)
        {
            
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
