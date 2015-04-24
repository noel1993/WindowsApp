using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Input;

namespace IdeaApp
{
    public partial class ButoonPage : PhoneApplicationPage
    {
        public double eachWayValue;
        public double amount;
        public int fifth = 5, quarter = 4;

        public ButoonPage()
        {
            InitializeComponent();
        }

      
        private void txtBox3_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //txtBox3.IsEnabled = false;
        }

        private void Win_Checked(object sender, RoutedEventArgs e)
        {
            string betValue;

            if (Win.IsChecked == true && EW_Check.IsChecked == false)
            {
                // Calculating the win part of the bet with error handeling
                try
                {
                    betValue = ((Decimal.Parse(txtBox1.Text) / Decimal.Parse(txtBox2.Text))).ToString();
                    txtBox3.Text = Convert.ToString(Convert.ToDouble(txtBokStake.Text) * (Convert.ToDouble(betValue) + 1));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

                }
            }
            else if(Win.IsChecked == true && EW_Check.IsChecked == true)
            {
                string ewBetValue;

                // Calculating the win part of the bet with error handeling
                try
                {
                    betValue = ((Decimal.Parse(txtBox1.Text) / Decimal.Parse(txtBox2.Text))).ToString();
                    betValue = Convert.ToString(Convert.ToDouble(txtBokStake.Text) * (Convert.ToDouble(betValue) + 1));

                    ewBetValue = ((Decimal.Parse(txtBox1.Text) / Decimal.Parse(txtBox2.Text))).ToString();
                    if(Quarter_Odds.IsChecked == true)
                    {
                        ewBetValue = Convert.ToString(Convert.ToDouble(ewBetValue) * 0.2 + 1);
                    }
                    else if(Fifth_Odds.IsChecked == true)
                    {
                        ewBetValue = Convert.ToString(Convert.ToDouble(ewBetValue) * 0.25 + 1);
                    }
                    ewBetValue = Convert.ToString(Convert.ToDouble(txtBokStake.Text) * (Convert.ToDouble(ewBetValue)));
                    txtBox3.Text = Convert.ToString(Convert.ToDouble(betValue) + Convert.ToDouble(ewBetValue));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

                }
                
            }
        }

        private void Place_Checked(object sender, RoutedEventArgs e)
        {
            // Calculating the Place only bet
            if (EW_Check.IsChecked == false)
            {
                txtBox3.Text = "0"; ;
            }

            if (Place.IsChecked == true && EW_Check.IsChecked == true)
            {
                string ewBetValue;

                // Calculating the win part of the bet with error handeling
                try
                {
                    ewBetValue = ((Decimal.Parse(txtBox1.Text) / Decimal.Parse(txtBox2.Text))).ToString();
                    ewBetValue = Convert.ToString(Convert.ToDouble(ewBetValue) * 0.25 + 1);
                    ewBetValue = Convert.ToString(Convert.ToDouble(txtBokStake.Text) * (Convert.ToDouble(ewBetValue)));
                    txtBox3.Text = Convert.ToString(Convert.ToDouble(ewBetValue));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

                }

             }            
        }

        private void Lose_Checked(object sender, RoutedEventArgs e)
        {
            // Sets returns to 0 if its a lose
            txtBox3.Text = "0";
        }

        private void N_R_Checked(object sender, RoutedEventArgs e)
        {
            // Orignal stake is returned if bet is a non runner
            if(EW_Check.IsChecked == false)
            {
                txtBox3.Text = (Decimal.Parse(txtBokStake.Text)).ToString();
            }
            else if(EW_Check.IsChecked == true)
            {
                txtBox3.Text = (Decimal.Parse(txtBokStake.Text)).ToString();
                string betValue = txtBox3.Text;
                txtBox3.Text = Convert.ToString(Convert.ToDouble(betValue) + (Convert.ToDouble(betValue)));
            }

        }

        private void Fifth_Odds_Checked(object sender, RoutedEventArgs e)
        {
            eachWayValue = 0.2;
        }

        private void Quarter_Odds_Checked(object sender, RoutedEventArgs e)
        {
            eachWayValue = 0.25;
        }


        



        
    }
}