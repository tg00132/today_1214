﻿using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.Model;
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

namespace CarManager0323.UI
{
     partial class SellerInsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;
        public SellerInsForm()
        {
            InitializeComponent();
        }
        public SellerInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }
        public SellerInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void SellerInsFormcs_Load(object sender, EventArgs e)
        {

        }

        private void sellOK_Click(object sender, EventArgs e)
        {
            if (sellName.Text == "" || sellTel.Text == "" ||
                sellEmail.Text == "" || sellSpot.Text == "" ||
                sellBusiness.Text == "")
            {
                MessageBox.Show("누락된 정보가 있습니다.\n" + "올바르게 입력하세요.");
                return;
            }
            List<Deal> list = dHandler.getDealList();
            try
            {
                Seller seller = new Seller(
                    sellName.Text,
                    sellTel.Text,
                    sellEmail.Text,
                    sellSpot.Text,
                    sellBusiness.Text);
                list[0].Seller = seller;
                oracle.insertSeller(seller);
                Close();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("똑바로 입력하세요.");
            }
        }

        private void sellTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
