﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Click
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        public void onClickPower(object sender,EventArgs e)
        {
            if (ClientData.points[3] > 1)
            {
                ClientData.consumePoint("Fuel");
                ClientData.Rotate("Power");
            }
            updateUI();
        }
        public void onClickIron(object sender, EventArgs e)
        {
            ClientData.Rotate("Iron");
            updateUI();
        }
        public void onClickCopper(object sender, EventArgs e)
        {
            ClientData.Rotate("Copper");
            updateUI();
        }
        public void onClickCoal(object sender, EventArgs e)
        {
            ClientData.Rotate("Fuel");
            updateUI();
        }
        public void onClickWater(object sender, EventArgs e)
        {
            ClientData.Rotate("Water");
            updateUI();
        }
        public void updateUI()
        { //"0-Power","1-Iron","2-Copper","3-Fuel","4-Water"
            powerDisplay.Text ="Power:"+ ClientData.points[0];
            iButton.Text = ClientData.rotationState[1] + "/" + ClientData.rotationPer[1];
            wButton.Text = ClientData.rotationState[4] + "/" + ClientData.rotationPer[4];
            fButton.Text = ClientData.rotationState[3] + "/" + ClientData.rotationPer[3];
            cButton.Text = ClientData.rotationState[2] + "/" + ClientData.rotationPer[2];
            pButton.Text = ClientData.rotationState[0] + "/" + ClientData.rotationPer[0];
            iDisplay.Text = "Iron:" + ClientData.points[1];
            wDisplay.Text="Water:"+ ClientData.points[4];
            fDisplay.Text="Fuel:"+ ClientData.points[3];
            cDisplay.Text="Copper:"+ ClientData.points[2];
        }
    }
}
