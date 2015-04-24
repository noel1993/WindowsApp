using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace IdeaApp
{
    public partial class Treble_Bet : PhoneApplicationPage
    {
        public double eachWayValue1 = 0.25;
        public double eachWayValue2 = 0.20;
        public string bet1Value, bet2Value, bet3Value, winValue1, placeVlaue1, placeValue2, placeValue, ewValue1;
        public string newOdds1, newOdds2, newOdds3, newbet1, newbet2, newbet3;

        public Treble_Bet()
        {
            InitializeComponent();
        }

        private void WinTreble1_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Treble1.Text) / Decimal.Parse(txtBox2Treble1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Treble2.Text) / Decimal.Parse(txtBox2Treble2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Treble3.Text) / Decimal.Parse(txtBox2Treble3.Text))).ToString();

                // Calculating value of win part of bet
                winValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Treble1.Text = winValue1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Treble1.Text) / (Convert.ToDouble(newOdds1)) + 1);
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Treble2.Text) / (Convert.ToDouble(newOdds2)) + 1);
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Treble3.Text) / (Convert.ToDouble(newOdds3)) + 1);

                ewValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text)
                                          * Convert.ToDouble(newbet1) * Convert.ToDouble(newbet2) * Convert.ToDouble(newbet3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (WinTreble3.IsChecked == true && WinTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == false)
            {
                txtBox3Treble1.Text = winValue1;
            }
            else if (WinTreble3.IsChecked == true && WinTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(winValue1) + Convert.ToDouble(ewValue1));
            }
            else if (PlaceTreble3.IsChecked == true && PlaceTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
            else if (WinTreble3.IsChecked == true && PlaceTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
            else if (PlaceTreble3.IsChecked == true && WinTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
        }

        private void PlaceTreble1_Checked(object sender, RoutedEventArgs e)
        {
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Treble1.Text) / (Convert.ToDouble(newOdds1)) + 1);
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Treble2.Text) / (Convert.ToDouble(newOdds2)) + 1);
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Treble3.Text) / (Convert.ToDouble(newOdds3)) + 1);

                ewValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text)
                                          * Convert.ToDouble(newbet1) * Convert.ToDouble(newbet2) * Convert.ToDouble(newbet3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (WinTreble3.IsChecked == true && PlaceTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (PlaceTreble3.IsChecked == true && WinTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (PlaceTreble3.IsChecked == true && PlaceTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (WinTreble3.IsChecked == true && WinTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
        }

        private void Treble1_Checked(object sender, RoutedEventArgs e)
        {
            txtBox3Treble1.Text = "0";
        }

        private void NRTreble1_Checked(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show("Bet is no longer a treble. Please change your bet to a Double");
        }

        private void WinTreble2_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Treble1.Text) / Decimal.Parse(txtBox2Treble1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Treble2.Text) / Decimal.Parse(txtBox2Treble2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Treble3.Text) / Decimal.Parse(txtBox2Treble3.Text))).ToString();

                // Calculating value of win part of bet
                winValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Treble1.Text = winValue1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Treble1.Text) / (Convert.ToDouble(newOdds1)) + 1);
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Treble2.Text) / (Convert.ToDouble(newOdds2)) + 1);
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Treble3.Text) / (Convert.ToDouble(newOdds3)) + 1);

                ewValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text)
                                          * Convert.ToDouble(newbet1) * Convert.ToDouble(newbet2) * Convert.ToDouble(newbet3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (WinTreble3.IsChecked == true && WinTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == false)
            {
                txtBox3Treble1.Text = winValue1;
            }
            else if (WinTreble3.IsChecked == true && WinTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(winValue1) + Convert.ToDouble(ewValue1));
            }
            else if (PlaceTreble3.IsChecked == true && PlaceTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
            else if (WinTreble3.IsChecked == true && PlaceTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
            else if (PlaceTreble3.IsChecked == true && WinTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
        }

        private void PlaceTreble2_Checked(object sender, RoutedEventArgs e)
        {
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Treble1.Text) / (Convert.ToDouble(newOdds1)) + 1);
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Treble2.Text) / (Convert.ToDouble(newOdds2)) + 1);
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Treble3.Text) / (Convert.ToDouble(newOdds3)) + 1);

                ewValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text)
                                          * Convert.ToDouble(newbet1) * Convert.ToDouble(newbet2) * Convert.ToDouble(newbet3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (WinTreble1.IsChecked == true && PlaceTreble3.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (PlaceTreble1.IsChecked == true && WinTreble3.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (PlaceTreble1.IsChecked == true && PlaceTreble3.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (WinTreble1.IsChecked == true && WinTreble3.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
        }

        private void LoseTreble2_Checked(object sender, RoutedEventArgs e)
        {
            txtBox3Treble1.Text = "0";
        }

        private void NRTreble2_Checked(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Bet is no longer a treble. Please change your bet to a Double");
        }

        private void WinTreble3_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Treble1.Text) / Decimal.Parse(txtBox2Treble1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Treble2.Text) / Decimal.Parse(txtBox2Treble2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Treble3.Text) / Decimal.Parse(txtBox2Treble3.Text))).ToString();

                // Calculating value of win part of bet
                winValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Treble1.Text = winValue1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Treble1.Text) / (Convert.ToDouble(newOdds1)) + 1);
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Treble2.Text) / (Convert.ToDouble(newOdds2)) + 1);
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Treble3.Text) / (Convert.ToDouble(newOdds3)) + 1);

                ewValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text)
                                          * Convert.ToDouble(newbet1) * Convert.ToDouble(newbet2) * Convert.ToDouble(newbet3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (WinTreble1.IsChecked == true && WinTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == false)
            {
                txtBox3Treble1.Text = winValue1;
            }
            else if (WinTreble1.IsChecked == true && WinTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(winValue1) + Convert.ToDouble(ewValue1));
            }
            else if (PlaceTreble1.IsChecked == true && PlaceTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
            else if (WinTreble1.IsChecked == true && PlaceTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
            else if (PlaceTreble1.IsChecked == true && WinTreble2.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = Convert.ToString(Convert.ToDouble(ewValue1));
            }
        }

        private void PlaceTreble3_Checked(object sender, RoutedEventArgs e)
        {
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Quarter_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Fifth_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Fifth_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 5);
                }
                else if (Fifth_OddsTreble1.IsChecked == true && Quarter_OddsTreble2.IsChecked == true && Quarter_OddsTreble3.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Treble1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Treble2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Treble3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Treble1.Text) / (Convert.ToDouble(newOdds1)) + 1);
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Treble2.Text) / (Convert.ToDouble(newOdds2)) + 1);
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Treble3.Text) / (Convert.ToDouble(newOdds3)) + 1);

                ewValue1 = Convert.ToString(Convert.ToDouble(txtBokStakeTreble1.Text)
                                          * Convert.ToDouble(newbet1) * Convert.ToDouble(newbet2) * Convert.ToDouble(newbet3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (WinTreble3.IsChecked == true && PlaceTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (PlaceTreble3.IsChecked == true && WinTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (PlaceTreble3.IsChecked == true && PlaceTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
            else if (WinTreble3.IsChecked == true && WinTreble1.IsChecked == true && EW_CheckTreble1.IsChecked == true)
            {
                txtBox3Treble1.Text = ewValue1;
            }
        }

        private void LoseTreble3_Checked(object sender, RoutedEventArgs e)
        {
            txtBox3Treble1.Text = "0";
        }

        private void NRTreble3_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bet is no longer a treble. Please change your bet to a Double");
        }

        private void Fifth_OddsTreble1_Checked(object sender, RoutedEventArgs e)
        {

        }

    }
}