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
    public partial class Trixie_Bet : PhoneApplicationPage
    {
        public double eachWayValue1 = 0.25;
        public double eachWayValue2 = 0.20;
        public string bet1Value, bet2Value, bet3Value, winTreble, placeVlaue1, placeValue2, placeValue, ewTrebleValue;
        public string newOdds1, newOdds2, newOdds3, newbet1, newbet2, newbet3;
        public string winDouble1, winDouble2, winDouble3, placeTreble, placeDouble1, placeDouble2, placeDouble3;
        public string totalWinValue, totalPlaceValue;

        public Trixie_Bet()
        {
            InitializeComponent();
        }

        private void WinTrixie1_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winTreble = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Trixie1.Text = winTreble;
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                ewTrebleValue = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(ewTrebleValue) + (Convert.ToDouble(placeDouble1))
                                 + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning if statements

            if (WinTrixie3.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                + (Convert.ToDouble(winDouble2)) + Convert.ToDouble(winDouble3));
            }
            else if (WinTrixie3.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalWinValue) + (Convert.ToDouble(totalPlaceValue)));

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Placed and Win if statements

            else if (PlaceTrixie3.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie3.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if (WinTrixie3.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble2)));
            }
            else if (WinTrixie3.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
            }

            else if(PlaceTrixie3.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble1)));
            }
            else if (PlaceTrixie3.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning, Placed and Lose If statements

            // 1 winner, 1 placed, 1 lost not EW
            else if (PlaceTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost EW
            else if (PlaceTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (LoseTrixie2.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost EW
            else if (LoseTrixie2.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }

            // 2 winners, 1 lost not EW
            else if (WinTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
            }
            // 2 winners, 1 lost EW
            else if (WinTrixie2.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1)+ (Convert.ToDouble(winDouble1)));
            }

            // 2 winners, 1 lost not EW
            else if (WinTrixie3.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
            }
            // 2 winners, 1 lost EW
            else if (WinTrixie3.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2) + (Convert.ToDouble(winDouble2)));
            }

            // 1 winner, 2 lost
            else if(LoseTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
        }

        private void PlaceTrixie1_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winTreble = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Trixie1.Text = winTreble;
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                ewTrebleValue = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(ewTrebleValue) + (Convert.ToDouble(placeDouble1))
                                 + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning if statements

            if (WinTrixie3.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
            }
            else if (WinTrixie3.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(totalPlaceValue)));

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Placed and Win if statements

            else if (PlaceTrixie3.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie3.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if (WinTrixie3.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (WinTrixie3.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if(PlaceTrixie3.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie3.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning, Placed and Lose If statements

            // 1 winner, 1 placed, 1 lost not EW
            else if (PlaceTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }

            // 2 placed, 1 lost not EW
            else if (LoseTrixie2.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (LoseTrixie2.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie3.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie3.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }

            // 1 placed, 2 lost
            else if(LoseTrixie2.IsChecked == true && LoseTrixie3.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
        }

        private void Trixie1_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            // 1 placed, 2 lost
            if (LoseTrixie2.IsChecked == true || LoseTrixie3.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie2.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie2.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie2.IsChecked == true && WinTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie2.IsChecked == true && WinTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (WinTrixie2.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }
            // 2 placed, 1 lost EW
            else if (WinTrixie2.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 won, 1 lost EW
            else if (WinTrixie2.IsChecked == true && WinTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeDouble3)));
            }
            // 2 won, 1 lost EW
            else if (WinTrixie2.IsChecked == true && WinTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
            }
        }

        private void NRTrixie1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bet is no longer a trixe. Please choose another bet");
        }

        private void WinTrixie2_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winTreble = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Trixie1.Text = winTreble;
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                ewTrebleValue = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(ewTrebleValue) + (Convert.ToDouble(placeDouble1))
                                 + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning if statements

            if (WinTrixie3.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                + (Convert.ToDouble(winDouble2)) + Convert.ToDouble(winDouble3));
            }
            else if (WinTrixie3.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalWinValue) + (Convert.ToDouble(totalPlaceValue)));

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Placed and Win if statements

            else if (PlaceTrixie3.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie3.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if (WinTrixie3.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble3)));
            }
            else if (WinTrixie3.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
            }

            else if (PlaceTrixie3.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble1)));
            }
            else if (PlaceTrixie3.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning, Placed and Lose If statements

            // 1 winner, 1 placed, 1 lost not EW
            else if (PlaceTrixie1.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (Trixie1.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost EW
            else if (Trixie1.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }

            // 2 winners, 1 lost not EW
            else if (WinTrixie1.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
            }
            // 2 winners, 1 lost EW
            else if (WinTrixie1.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1) + (Convert.ToDouble(winDouble1)));
            }

            // 2 winners, 1 lost not EW
            else if (WinTrixie3.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
            }
            // 2 winners, 1 lost EW
            else if (WinTrixie3.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3) + (Convert.ToDouble(winDouble3)));
            }

            // 1 winner, 2 lost
            else if (Trixie1.IsChecked == true && LoseTrixie3.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
        }

        private void PlaceTrixie2_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winTreble = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Trixie1.Text = winTreble;
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                ewTrebleValue = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(ewTrebleValue) + (Convert.ToDouble(placeDouble1))
                                 + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning if statements

            if (WinTrixie3.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
            }
            else if (WinTrixie3.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(totalPlaceValue)));

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Placed and Win if statements

            else if (PlaceTrixie3.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie3.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if (WinTrixie3.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (WinTrixie3.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if (PlaceTrixie3.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie3.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning, Placed and Lose If statements

            // 1 winner, 1 placed, 1 lost not EW
            else if (PlaceTrixie1.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }

            // 2 placed, 1 lost not EW
            else if (Trixie1.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (Trixie1.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie1.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie1.IsChecked == true && LoseTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie3.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie3.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }

            // 1 placed, 2 lost
            else if (Trixie1.IsChecked == true && LoseTrixie3.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
        }

        private void LoseTrixie2_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            // 1 placed, 2 lost
            if (Trixie1.IsChecked == true || LoseTrixie3.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && WinTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && WinTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (WinTrixie1.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }
            // 2 placed, 1 lost EW
            else if (WinTrixie1.IsChecked == true && PlaceTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 won, 1 lost EW
            else if (WinTrixie1.IsChecked == true && WinTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeDouble2)));
            }
            // 2 won, 1 lost EW
            else if (WinTrixie1.IsChecked == true && WinTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
            }
        }

        private void NRTrixie2_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bet is no longer a trixe. Please choose another bet");
        }

        private void WinTrixie3_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winTreble = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Trixie1.Text = winTreble;
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                ewTrebleValue = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(ewTrebleValue) + (Convert.ToDouble(placeDouble1))
                                 + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning if statements

            if (WinTrixie2.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                + (Convert.ToDouble(winDouble2)) + Convert.ToDouble(winDouble3));
            }
            else if (WinTrixie2.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalWinValue) + (Convert.ToDouble(totalPlaceValue)));

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Placed and Win if statements

            else if (PlaceTrixie2.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie2.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if (WinTrixie2.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble3)));
            }
            else if (WinTrixie2.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
            }

            else if (PlaceTrixie2.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble2)));
            }
            else if (PlaceTrixie2.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning, Placed and Lose If statements

            // 1 winner, 1 placed, 1 lost not EW
            else if (PlaceTrixie1.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (Trixie1.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost EW
            else if (Trixie1.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }

            // 2 winners, 1 lost not EW
            else if (WinTrixie1.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
            }
            // 2 winners, 1 lost EW
            else if (WinTrixie1.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2) + (Convert.ToDouble(winDouble2)));
            }

            // 2 winners, 1 lost not EW
            else if (WinTrixie2.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
            }
            // 2 winners, 1 lost EW
            else if (WinTrixie2.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3) + (Convert.ToDouble(winDouble3)));
            }

            // 1 winner, 2 lost
            else if (Trixie1.IsChecked == true && LoseTrixie2.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
        }

        private void PlaceTrixie3_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winTreble = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));
                txtBox3Trixie1.Text = winTreble;
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winTreble) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                ewTrebleValue = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(ewTrebleValue) + (Convert.ToDouble(placeDouble1))
                                 + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning if statements

            if (WinTrixie2.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
            }
            else if (WinTrixie2.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(totalPlaceValue)));
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Placed and Win if statements

            else if (PlaceTrixie2.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie2.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if (WinTrixie2.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (WinTrixie2.IsChecked == true && PlaceTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }

            else if (PlaceTrixie2.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
            }
            else if (PlaceTrixie2.IsChecked == true && WinTrixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Winning, Placed and Lose If statements

            // 1 winner, 1 placed, 1 lost not EW
            else if (PlaceTrixie1.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }

            // 2 placed, 1 lost not EW
            else if (Trixie1.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (Trixie1.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie1.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie1.IsChecked == true && LoseTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
            }

            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie2.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 1 winner, 1 placed, 1 lost not EW
            else if (WinTrixie2.IsChecked == true && Trixie1.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
            }

            // 1 placed, 2 lost
            else if (Trixie1.IsChecked == true && LoseTrixie2.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
        }

        private void LoseTrixie3_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Trixie1.Text) / Decimal.Parse(txtBox2Trixie1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Trixie2.Text) / Decimal.Parse(txtBox2Trixie2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Trixie3.Text) / Decimal.Parse(txtBox2Trixie3.Text))).ToString();

                // Calculating value of win part of bet
                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));
                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }
            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Quarter_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Fifth_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Fifth_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 5);
                }
                else if (Fifth_OddsTrixie1.IsChecked == true && Quarter_OddsTrixie2.IsChecked == true && Quarter_OddsTrixie3.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Trixie1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Trixie2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Trixie3.Text) * 4);
                }


                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Trixie1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Trixie2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Trixie3.Text) / (Convert.ToDouble(newOdds3)));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet2) + 1));
                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet1) + 1) * (Convert.ToDouble(newbet3) + 1));
                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeTrixie1.Text)
                                          * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newbet2) + 1));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            // 1 placed, 2 lost
            if (Trixie1.IsChecked == true || LoseTrixie2.IsChecked == true)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }
            // 2 placed, 1 lost EW
            else if (PlaceTrixie1.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 placed, 1 lost EW
            else if (WinTrixie1.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
            }
            // 2 placed, 1 lost EW
            else if (WinTrixie1.IsChecked == true && PlaceTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = "0";
            }
            // 2 won, 1 lost EW
            else if (WinTrixie1.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == true)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeDouble1)));
            }
            // 2 won, 1 lost EW
            else if (WinTrixie1.IsChecked == true && WinTrixie2.IsChecked == true && EW_CheckTrixie1.IsChecked == false)
            {
                txtBox3Trixie1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
            }
        }

        private void NRTrixie3_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bet is no longer a trixe. Please choose another bet");
        }

        private void Fifth_OddsTrixie1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}