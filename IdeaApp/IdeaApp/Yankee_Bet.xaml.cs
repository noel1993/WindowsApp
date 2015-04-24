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
    public partial class Yankee_Bet : PhoneApplicationPage
    {

        public double eachWayValue1 = 0.25;
        public double eachWayValue2 = 0.20;
        public string bet1Value, bet2Value, bet3Value, bet4Value, winTreble, placeVlaue1, placeValue2, placeValue, ewTrebleValue;
        public string newOdds1, newOdds2, newOdds3, newOdds4, newbet1, newbet2, newbet3, newBet4;
        public string winDouble1, winDouble2, winDouble3, placeDouble1, placeDouble2, placeDouble3;
        public string totalWinValue, totalPlaceValue, winQuad;
        public string winTreble1, winTreble2, winTreble3, winTreble4, winDouble4, winDouble5, winDouble6, winDouble7;
        public string placeQuad, placeTreble1, placeTreble2, placeTreble3, placeTreble4, placeDouble4, placeDouble5, placeDouble6;

        public Yankee_Bet()
        {
            InitializeComponent();
            // Calculating value of odds
        }

        private void WinYankee1_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) +1));
      
                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + + (Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }
            //////////////////////////////////////////////////////////////////////////////////////          
            // Non EachWay Bets
            if(EW_CheckYankee1.IsChecked == false)
            { 
                // All winners
                if(WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalWinValue)));
                }

                // Two Winners 1 & 4 with 2 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 1 & 4 with 3 placing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 1 & 4 with 3 placing and 2 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 1 & 4 with 3 losing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }

                // Three Winners 1 & 2 & 3 and 4 losing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(winDouble1)) 
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));                   
                }
                // Three Winners 1 & 2 & 3 and 4 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                // Three Winners 1 & 2 & 4 and 3 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 1 & 2 & 4 and 3 losing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 1 & 3 & 4 and 2 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 1 & 3 & 4 and 2 losing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6)));
                }
                // Two Winners 1 & 2 with 3 and 4 losing
                else if (WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 2 with 3 and 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 2 with 3 placing and 4 losing
                else if (WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 2 with 3 losing and 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 3 with 4 losing and 2 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 3 with 2 losing and 4 placing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 3 with 4 losing and 2 placing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 3 with 2 placing and 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }

            }
            //////////////////////////////////////////////////////////////////////////////////////

            // EachWay Bets
            else if (EW_CheckYankee1.IsChecked == true)
            {
                // All winners
                if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalWinValue) + (Convert.ToDouble(totalPlaceValue))));
                }
                // 1 winner 3 placed
                else if (PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalPlaceValue)));
                }
                else if(PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1)
                     + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)))));
                }
                else if (PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1)
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)))));
                }
                else if (LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4)
                     + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)))));
                }
                else if (PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble1)));
                }
                else if (LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble2)));
                }
                else if (LoseYankee2.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble3)));
                }


                // Two Winners 1 & 4 with 2 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeTreble2))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)));
                    // txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));                                    
                }
                // Two Winners 1 & 4 with 3 placing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)));
                }
                // Two Winners 1 & 4 with 3 placing and 2 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 1 & 4 with 3 losing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeDouble3)));
                }

                // Three Winners 1 & 2 & 3 and 4 losing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(placeTreble1))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(placeDouble4)));
                }
                // Three Winners 1 & 2 & 3 and 4 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));                   
                }
                // Three Winners 1 & 2 & 4 and 3 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble1))+ (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));                    
                }
                // Three Winners 1 & 2 & 4 and 3 losing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(placeTreble2))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(winDouble3))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(winDouble5)));                   
                }
                // Three Winners 1 & 3 & 4 and 2 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6)));                   
                }
                // Three Winners 1 & 3 & 4 and 2 losing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(winDouble6)));
                }

                ////////////// WIN DOUBLES WITH PLACE TREBLES

                // Two Winners 1 & 2 with 3 and 4 losing
                else if (WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeDouble1)));
                }
                // Two Winners 1 & 2 with 3 and 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 1 & 2 with 3 placing and 4 losing
                else if (WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeTreble1))
                     + (Convert.ToDouble(placeDouble1))+ (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // Two Winners 1 & 2 with 3 losing and 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeTreble3))
                     + (Convert.ToDouble(placeDouble5))+ (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble5)));                    
                }


                // Two Winners 1 & 3 with 4 losing and 2 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeTreble1))
                     + (Convert.ToDouble(placeDouble4))+ (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)));
                    
                }
                // Two Winners 1 & 3 with 2 losing and 4 placing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeTreble3))
                      + (Convert.ToDouble(placeDouble6))+ (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble2)));
                }
                // Two Winners 1 & 3 with 4 losing and 2 losing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeDouble2)));
                }
                // Two Winners 1 & 3 with 2 placing and 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(totalPlaceValue)));
                }
            }
        }

        private void PlaceYankee1_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            //////////////////////////////////////////////////////////////////////////////////////          
            // Non EachWay Bets
            if(EW_CheckYankee1.IsChecked == false)
            { 
                // Three winners
                if(WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(winDouble4)) 
					+ (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6))));
                }
                // Two Winners 2 & 3 and 4 losing and 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));                
                }
                // Two Winners 2 & 3 and 1 & 4 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));     
                }
                // Two Winners 2 & 4 and 1 & 3 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));     
                }
                // Two Winners 2 & 4 and 3 losing and 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // Two Winners 3 & 4 and 1 & 2 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // Two Winners 3 & 4 and 1 placing and 2 losing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // One Winner 2 and 1 placing with 3 and 4 losing
                else if (WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 1 & 3 & 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 1 & 3 placing and 4 losing
                else if (WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 3 losing and 1 & 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 4 losing and 1 & 2 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 2 losing and 1 & 4 placing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 4 losing and 1 & 2 placing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 1 & 2 placing and 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 2 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 3 placing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 2 & 3 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 & 4 with 3 losing and 1 & 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////

            // EachWay Bets
            else if (EW_CheckYankee1.IsChecked == true)
            {
                // 3 winners 1 placed
                if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
				else if(PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 2 & 3 and 1 placing and 4 losing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeTreble1))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // Three Winners 2 & 3 and 1 & 4 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble4)));                    
                }
				
                // Two Winners 2 & 4 and 1 & 3 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble5)));                    
                }
                // Two Winners 2 & 4 and 3 losing and 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1) + (Convert.ToDouble(placeTreble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(placeDouble5)));                
                }
				
                // Two Winners 3 & 4 and 1 & 2 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble6)));                    
                }
                // Two Winners 3 & 4 and 2 losing and 1 losing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(placeDouble3))+ (Convert.ToDouble(winDouble6)) + (Convert.ToDouble(placeDouble6)));                    
                    
                }

                ////////////// One Winner WITH PLACE Double and Trebles

                                // One Winners 4 with 1 & 2 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                // One Winner 4 with 1 & 3 placing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 4 with 1 & 2 & 3 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                // One Winner 4 with 1 placing and 3 & 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }

                // One Winners 1 & 2 with 3 and 4 losing
                else if (WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                // One Winners 2 with  1 & 3 & 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                // One Winner 2 with 1 & 3 placing and 4 losing
                else if (WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)));
                }
                // One Winner 2 with 3 losing and 1 & 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble3)));                   
                }

                // One Winner 3 with 4 losing and 1 & 2 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));                    
                }
                // One Winner 3 with 2 losing and 1 & 4 placing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)));
                }
                // One Winner 3 with 1 placing and 4 & 2 losing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                // One Winner 3 with 1 & 2 & 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }

                else if(PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                else if (PlaceYankee3.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                else if (PlaceYankee4.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }

                else if (PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }

                else if (PlaceYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }

                else if (PlaceYankee4.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (PlaceYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
            }  
        }

        private void Yankee1_Checked(object sender, RoutedEventArgs e)
        {
            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if(EW_CheckYankee1.IsChecked == false)
            {
                if(WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                else if (WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                else if (LoseYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                else if (WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                else if (PlaceYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }                
            }
            else if(EW_CheckYankee1.IsChecked == true)
            {
                if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(winTreble4)) 
                    + (Convert.ToDouble(winDouble4))+ (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)) + (Convert.ToDouble(placeDouble6)));
                                     
                }
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeDouble4)));
                }
                else if (WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(placeDouble5)));
                }
                else if (LoseYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(placeDouble6)));
                }

                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(winDouble5))
                    + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee2.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(winDouble6))
                    + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }

                else if(PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4)) 
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee2.IsChecked == true && WinYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true & WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }

                else if (PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true & LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }
                else if (PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }
                else if (LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                else if(WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }
                else if (WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }

                else if (WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                else if (WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                else
                {
                    txtBox3Yankee1.Text = "0";
                }  
            }
        }

        private void NRYankee1_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bet is no longer a yankee. Please use another bet to get your winnings");
        }

        private void WinYankee2_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            //////////////////////////////////////////////////////////////////////////////////////          
            // Non EachWay Bets
            if (EW_CheckYankee1.IsChecked == false)
            {
                // All winners
                if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalWinValue)));
                }

                // Two Winners 2 & 4 with 1 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // Two Winners 2 & 4 with 3 placing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // Two Winners 2 & 4 with 3 placing and 1 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // Two Winners 2 & 4 with 3 losing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }

                // Three Winners 1 & 2 & 3 and 4 losing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                // Three Winners 1 & 2 & 3 and 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                // Three Winners 1 & 2 & 4 and 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 1 & 2 & 4 and 3 losing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 2 & 3 & 4 and 1 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 losing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Two Winners 1 & 2 with 3 and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 2 with 3 and 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 2 with 3 placing and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 2 with 3 losing and 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 2 & 3 with 4 losing and 1 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                // Two Winners 2 & 3 with 1 losing and 4 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                // Two Winners 2 & 3 with 4 losing and 1 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                // Two Winners 2 & 3 with 1 placing and 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }

            }
            //////////////////////////////////////////////////////////////////////////////////////

            // EachWay Bets
            else if (EW_CheckYankee1.IsChecked == true)
            {
                // All winners
                if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalWinValue) + (Convert.ToDouble(totalPlaceValue))));
                }
                // 1 winner 3 placed
                else if (PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalPlaceValue)));
                }
                // One winner 2 with Two placed 1 & 3 placed and 4 lost
                else if (PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1)
                     + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)))));
                }
                // One winner 2 with Two placed 1 & 3 placed and 4 lost
                else if (PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1)
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)))));
                }
                // One winner with 2 placed and 1 lost
                else if (Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4)
                     + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)))));
                }
                // One winner with one placed and two lost
                else if (PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble1)));
                }
                // One winner with one placed and two lost
                else if (Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble4)));
                }
                // One winner with two placed and one lost
                else if (Yankee1.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble5)));
                }


                // Two Winners 2 & 4 with 1 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeTreble2))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)));
                    // txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));                                    
                }
                // Two Winners 2 & 4 with 3 placing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)));
                }
                // Two Winners 2 & 4 with 3 placing and 1 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 2 & 4 with 3 losing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(placeDouble5)));
                }

                // Three Winners 1 & 2 & 3 and 4 losing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(placeTreble1))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(placeDouble4)));
                }
                // Three Winners 1 & 2 & 3 and 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                // Three Winners 1 & 2 & 4 and 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 1 & 2 & 4 and 3 losing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(placeTreble2))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(winDouble3))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 2 & 3 & 4 and 1 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 losing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(winDouble6)));
                }

                ////////////// WIN DOUBLES WITH PLACE TREBLES

                // Two Winners 1 & 2 with 3 and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeDouble1)));
                }
                // Two Winners 1 & 2 with 3 and 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 1 & 2 with 3 placing and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeTreble1))
                     + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // Two Winners 1 & 2 with 3 losing and 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeTreble3))
                     + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble5)));
                }


                // Two Winners 2 & 3 with 4 losing and 1 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeTreble1))
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)));

                }
                // Two Winners 2 & 3 with 1 losing and 4 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeTreble4))
                      + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // Two Winners 2 & 3 with 4 losing and 1 losing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeDouble4)));
                }
                // Two Winners 2 & 3 with 1 placing and 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(totalPlaceValue)));
                }
            }
        }

        private void PlaceYankee2_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            //////////////////////////////////////////////////////////////////////////////////////          
            // Non EachWay Bets
            if (EW_CheckYankee1.IsChecked == false)
            {
                // Three winners
                if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6))));
                }
                // Two Winners 1 & 3 and 4 losing and 2 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 3 and 2 & 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 4 and 2 & 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 1 & 4 and 3 losing and 2 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 3 & 4 and 2 & 2 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // Two Winners 3 & 4 and 2 placing and 2 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // One Winner 1 and 2 placing with 3 and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 1 & 3 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 1 & 3 placing and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 3 losing and 2 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 4 losing and 2 & 2 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 2 placing and 2 & 4 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 4 losing and 2 & 2 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 1 & 2 placing and 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 2 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 3 placing and 2 placing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 2 & 3 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 & 4 with 3 losing and 2 placing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////

            // EachWay Bets
            else if (EW_CheckYankee1.IsChecked == true)
            {
                // 3 winners 1 placed
                if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6)));
                }
                else if (PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 1 & 3 and 2 placing and 4 losing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeTreble1))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // Three Winners 1 & 3 and 2 & 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble2)));
                }
                // Two Winners 1 & 4 and 2 & 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble3)));
                }
                // Two Winners 1 & 4 and 3 losing and 2 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1) + (Convert.ToDouble(placeTreble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(placeDouble5)));
                }

                // Two Winners 3 & 4 and 2 & 2 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble6)));
                }
                // Two Winners 3 & 4 and 2 placing and 2 placing
                else if (WinYankee3.IsChecked == true && WinYankee4.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(winDouble6)) + (Convert.ToDouble(placeDouble6)));

                }

                ////////////// One Winner WITH PLACE Double and Trebles

                // One Winner 4 with 1 & 2 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                // One Winner 4 with 2 & 3 placing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 4 with 1 & 2 & 3 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                // One Winner 4 with 1 placing and 3 & 2 placing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }

                // One Winner 1 and with 2 placing with 3 and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                // One Winner 1 with  rest placed
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                // One Winner 1 with 2 & 3 placing and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // One Winner 1 with 3 losing and 2 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble3)));
                }

                // One Winner 3 with 4 losing and 1 & 2 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // One Winner 3 with 1 losing and 2 & 4 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 3 with 1 placing and 4 & 2 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }
                // One Winner 3 with 1 & 2 & 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }

                else if (PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                else if (PlaceYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }
                else if (PlaceYankee4.IsChecked == true && LoseYankee3.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }

                else if (PlaceYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (PlaceYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
            }  
        }

        private void LoseYankee2_Checked(object sender, RoutedEventArgs e)
        {
            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (EW_CheckYankee1.IsChecked == false)
            {
                if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6)));
                }
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                else if (Yankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }
            else if (EW_CheckYankee1.IsChecked == true)
            {
                if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(winTreble3))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6)) + (Convert.ToDouble(placeDouble6)));

                }
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeDouble2)));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeDouble3)));
                }
                else if (Yankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(placeDouble6)));
                }

                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(winDouble3))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee3.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(winDouble6))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true & WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true & LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                else if (PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }
                else if (Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }

        }

        private void NRYankee2_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bet is no longer a yankee. Please use another bet to get your winnings");
        }

        private void WinYankee3_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            //////////////////////////////////////////////////////////////////////////////////////          
            // Non EachWay Bets
            if (EW_CheckYankee1.IsChecked == false)
            {
                // All winners
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalWinValue)));
                }

                // Two Winners 3 & 4 with 1 placing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // Two Winners 3 & 4 with 2 placing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // Two Winners 3 & 4 with 2 placing and 1 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // Two Winners 3 & 4 with 2 losing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }

                // Three Winners 1 & 2 & 3 and 4 losing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                // Three Winners 1 & 2 & 3 and 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                // Three Winners 1 & 3 & 4 and 2 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 1 & 3 & 4 and 2 losing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 2 & 3 & 4 and 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 losing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Two Winners 1 & 3 with 2 and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 3 with 2 and 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 3 with 2 placing and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 3 with 2 losing and 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 2 & 3 with 4 losing and 1 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                // Two Winners 2 & 3 with 1 losing and 4 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                // Two Winners 2 & 3 with 4 losing and 1 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                // Two Winners 2 & 3 with 1 placing and 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }

            }
            //////////////////////////////////////////////////////////////////////////////////////

            // EachWay Bets
            else if (EW_CheckYankee1.IsChecked == true)
            {
                // All winners
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalWinValue) + (Convert.ToDouble(totalPlaceValue))));
                }
                // 1 winner 3 placed
                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalPlaceValue)));
                }
                // One winner 3 with Two placed 1 & 3 and 4 lost
                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1)
                     + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)))));
                }
                // One winner 3 with Two placed 1 & 4 placed and 2 lost
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2)
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)))));
                }
                // One winner with 2 placed and 1 lost
                else if (Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4)
                     + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)))));
                }
                // One winner with one placed and two lost
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble2)));
                }
                // One winner with one placed and two lost
                else if (Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble4)));
                }
                // One winner with two placed and one lost
                else if (Yankee1.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble6)));
                }

                // Two Winners 3 & 4 with 1 placing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                    // txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));                                    
                }
                // Two Winners 3 & 4 with 2 placing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)));
                }
                // Two Winners 3 & 4 with 2 placing and 1 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 3 & 4 with 2 losing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(placeDouble6)));
                }

                // Three Winners 1 & 2 & 3 and 4 losing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(placeTreble1))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(placeDouble4)));
                }
                // Three Winners 1 & 2 & 3 and 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                // Three Winners 1 & 3 & 4 and 2 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 1 & 3 & 4 and 2 losing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(winDouble3))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 losing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(winDouble6)));
                }

                ////////////// WIN DOUBLES WITH PLACE TREBLES

                // Two Winners 1 & 3 with 2 and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeDouble2)));
                }
                // Two Winners 1 & 3 with 2 and 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 1 & 3 with 2 placing and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeTreble1))
                     + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // Two Winners 1 & 3 with 2 losing and 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeTreble3))
                     + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble6)));
                }


                // Two Winners 2 & 3 with 4 losing and 1 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeTreble1))
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)));
                }
                // Two Winners 2 & 3 with 1 losing and 4 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeTreble4))
                      + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // Two Winners 2 & 3 with 4 losing and 1 losing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeDouble4)));
                }
                // Two Winners 2 & 3 with 1 placing and 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(totalPlaceValue)));
                }
            }
        }

        private void PlaceYankee3_Checked(object sender, RoutedEventArgs e)
        {
            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            //////////////////////////////////////////////////////////////////////////////////////          
            // Non EachWay Bets
            if (EW_CheckYankee1.IsChecked == false)
            {
                // Three winners
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5))));
                }
                // Two Winners 1 & 2 and 4 losing and 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 2 and 3 & 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 4 and 2 & 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 1 & 4 and 2 losing and 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 2 & 4 and 1 & 3 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // Two Winners 2 & 4 and 23placing and 2 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // One Winner 1 and 2 placing with 3 and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 1 & 3 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 1 & 3 placing and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 2 losing and 3 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 4 losing and 3 & 2 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 3 placing and 2 & 4 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 4 losing and 3 & 2 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 1 & 3 placing and 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 3 placing and 2 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 3 placing and 2 placing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 4 with 1 & 2 & 3 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 & 4 with 3 losing and 2 placing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////

            // EachWay Bets
            else if (EW_CheckYankee1.IsChecked == true)
            {
                // 3 winners 1 placed
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 1 & 2 and 3 placing and 4 losing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeTreble1))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));

                }
                // Three Winners 1 & 2 and 3 & 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble1)));
                }
                // Two Winners 1 & 4 and 2 & 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble3)));
                }
                // Two Winners 1 & 4 and 2 losing and 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(placeDouble6)));
                }

                // Two Winners 2 & 4 and 3 & 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble6)));
                }
                // Two Winners 2 & 4 and 3 placing and 1 losing
                else if (WinYankee2.IsChecked == true && WinYankee4.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(placeDouble6)));

                }

                ////////////// One Winner WITH PLACE Double and Trebles

                // One Winner 4 with 1 & 2 placing and 3 losing
                else if (WinYankee4.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 4 with 2 & 3 placing and 1 losing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 4 with 1 & 2 & 3 placing
                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                // One Winner 4 with 1 placing and 3 & 2 placing
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                // One Winner 1 and with 2 placing with 3 and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                // One Winner 1 with  rest placed
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                // One Winner 1 with 2 & 3 placing and 4 losing
                else if (WinYankee1.IsChecked == true && LoseYankee4.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // One Winner 1 with 3 losing and 2 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee4.IsChecked == true || LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(placeDouble3)));
                }

                // One Winner 2 with 4 losing and 1 & 2 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                // One Winner 2 with 1 losing and 2 & 4 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 2 with 1 placing and 4 & 2 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }
                // One Winner 2 with 1 & 2 & 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }

                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                else if (PlaceYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }
                else if (PlaceYankee4.IsChecked == true && LoseYankee2.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }

                else if (PlaceYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
            }  
        }

        private void LoseYankee3_Checked(object sender, RoutedEventArgs e)
        {
            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (EW_CheckYankee1.IsChecked == false)
            {
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                else if (Yankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }
            else if (EW_CheckYankee1.IsChecked == true)
            {
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(winTreble2))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(placeDouble5)));

                }
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeDouble1)));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeDouble3)));
                }
                else if (Yankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(placeDouble5)));
                }

                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(winDouble3))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(winDouble5))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee2.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee2.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true & WinYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true & LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }
                else if (Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true & PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }

                else if (WinYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee4.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }

                else if (WinYankee4.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }
                else if (WinYankee4.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }

                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }

        }

        private void NRYankee3_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bet is no longer a yankee. Please use another bet to get your winnings");
        }

        private void WinYankee4_Checked(object sender, RoutedEventArgs e)
        {
            // Win Only Bet

            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            //////////////////////////////////////////////////////////////////////////////////////          
            // Non EachWay Bets
            if (EW_CheckYankee1.IsChecked == false)
            {
                // All winners
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalWinValue)));
                }

                // Two Winners 3 & 4 with 1 placing and 2 losing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // Two Winners 3 & 4 with 2 placing and 1 losing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // Two Winners 3 & 4 with 2 placing and 1 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }
                // Two Winners 3 & 4 with 2 losing and 1 losing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6));
                }

                // Three Winners 1 & 2 & 4 and 3 losing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 1 & 2 & 4 and 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 1 & 3 & 4 and 2 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 1 & 3 & 4 and 2 losing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 losing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Two Winners 1 & 4 with 2 and 3 losing
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 1 & 4 with 2 and 3 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 1 & 4 with 2 placing and 3 losing
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 1 & 4 with 2 losing and 3 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true || LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3));
                }
                // Two Winners 2 & 4 with 3 losing and 1 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // Two Winners 2 & 4 with 1 losing and 3 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // Two Winners 2 & 4 with 3 losing and 1 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                // Two Winners 2 & 4 with 1 placing and 3 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5));
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }

            }
            //////////////////////////////////////////////////////////////////////////////////////

            // EachWay Bets
            else if (EW_CheckYankee1.IsChecked == true)
            {
                // All winners
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalWinValue) + (Convert.ToDouble(totalPlaceValue))));
                }
                // 1 winner 3 placed
                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalPlaceValue)));
                }
                // One winner 4 with Two placed 1 & 2 and 3 lost
                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1)
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)))));
                }
                // One winner 4 with Two placed 1 & 3 placed and 2 lost
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2)
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)))));
                }
                // One winner with 2 placed and 1 lost
                else if (Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4)
                     + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)))));
                }
                // One winner with one placed and two lost
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble3)));
                }
                // One winner with one placed and two lost
                else if (Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble5)));
                }
                // One winner with two placed and one lost
                else if (Yankee1.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(placeDouble6)));
                }

                // Two Winners 3 & 4 with 1 placing and 2 losing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                // Two Winners 3 & 4 with 2 placing and 1 losing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)));
                }
                // Two Winners 3 & 4 with 2 placing and 1 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 3 & 4 with 2 losing and 1 losing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble6) + (Convert.ToDouble(placeDouble6)));
                }

                // Three Winners 1 & 2 & 4 and 3 losing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(placeTreble2))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(winDouble3))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(placeDouble5)));
                }
                // Three Winners 1 & 2 & 4 and 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble2) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble5)));
                }
                // Three Winners 1 & 3 & 4 and 2 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 1 & 3 & 4 and 2 losing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble3) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(winDouble3))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(winDouble6)));
                }
                // Three Winners 2 & 3 & 4 and 1 losing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble4) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5))
                    + (Convert.ToDouble(winDouble5)) + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(winDouble6)));
                }

                ////////////// WIN DOUBLES WITH PLACE TREBLES

                // Two Winners 1 & 4 with 2 and 3 losing
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeDouble3)));
                }
                // Two Winners 1 & 4 with 2 and 3 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 1 & 4 with 2 placing and 3 losing
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeTreble2))
                     + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                // Two Winners 1 & 4 with 2 losing and 3 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true || LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble3) + (Convert.ToDouble(placeTreble3))
                     + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }

                // Two Winners 2 & 4 with 3 losing and 1 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(placeTreble2))
                     + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                // Two Winners 2 & 4 with 1 losing and 3 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(placeTreble4))
                      + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // Two Winners 2 & 4 with 3 losing and 1 losing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(placeDouble5)));
                }
                // Two Winners 2 & 4 with 1 placing and 3 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble5) + (Convert.ToDouble(totalPlaceValue)));
                }
            }
        }

        private void PlaceYankee4_Checked(object sender, RoutedEventArgs e)
        {
            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            //////////////////////////////////////////////////////////////////////////////////////          
            // Non EachWay Bets
            if (EW_CheckYankee1.IsChecked == false)
            {
                // Three winners
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4))));
                }
                // Two Winners 1 & 2 and 3 losing and 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 2 and 3 & 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                // Two Winners 1 & 3 and 4 & 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 1 & 3 and 2 losing and 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                // Two Winners 2 & 4 and 1 & 3 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                // Two Winners 2 & 3 and 4 placing and 2 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                // One Winner 1 and 4 placing with 2 and 3 losing
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 1 & 3 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 1 & 4 placing and 3 losing
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 with 2 losing and 3 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 3 losing and 4 & 2 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 1 losing and 3 & 4 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 1 & 3 placing and 4 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 2 with 1 & 3 placing and 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 1 & 4 placing and 2 losing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 1 & 4 placing and 2 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 3 with 1 & 2 & 4 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                // One Winner 1 and  4 placing with 3 losing and 2
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = "0";
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }
            //////////////////////////////////////////////////////////////////////////////////////

            // EachWay Bets
            else if (EW_CheckYankee1.IsChecked == true)
            {
                // 3 winners 1 placed
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(totalPlaceValue))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = (Convert.ToString(Convert.ToDouble(totalPlaceValue)));
                }
                // Two Winners 1 & 2 and 3 placing and 4 losing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeTreble2))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                // Three Winners 1 & 2 and 3 & 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble1)));
                }
                // Two Winners 1 & 3 and 2 & 4 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble2)));
                }
                // Two Winners 1 & 3 and 2 losing and 3 placing
                else if (WinYankee1.IsChecked == true && WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2) + (Convert.ToDouble(placeTreble3))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(placeDouble6)));
                }

                // Two Winners 2 & 3 and 4 & 1 placing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue) + (Convert.ToDouble(winDouble4)));
                }
                // Two Winners 2 & 4 and 3 placing and 1 losing
                else if (WinYankee2.IsChecked == true && WinYankee3.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4) + (Convert.ToDouble(placeTreble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(placeDouble6)));

                }

                ////////////// One Winner WITH PLACE Double and Trebles

                // One Winner 3 with 1 & 4 placing and 2 losing
                else if (WinYankee3.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                     + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 3 with 2 & 4 placing and 1 losing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 3 with 1 & 2 & 3 placing
                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                // One Winner 3 with 4 placing and 1 & 2 placing
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                // One Winner 1 and with 4 placing with 3 and 2 losing
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }
                // One Winner 1 with  rest placed
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                // One Winner 1 with 2 & 4 placing and 2 losing
                else if (WinYankee1.IsChecked == true && LoseYankee3.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                // One Winner 1 with 2 losing and 3 & 4 placing
                else if (WinYankee1.IsChecked == true && PlaceYankee3.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble6)) + (Convert.ToDouble(placeDouble3)));
                }

                // One Winner 2 with 3 losing and 1 & 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                // One Winner 2 with 1 losing and 2 & 4 placing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                // One Winner 2 with 4 placing and 3 & 2 losing
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }
                // One Winner 2 with 1 & 2 & 4 placing
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(totalPlaceValue));
                }
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble3));
                }
                else if (PlaceYankee2.IsChecked == true && Yankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble5));
                }
                else if (PlaceYankee3.IsChecked == true && LoseYankee2.IsChecked == true && Yankee1.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble6));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble2) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble5)));
                }
                else if (PlaceYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble3) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble6)));
                }
                else if (PlaceYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble5)) + (Convert.ToDouble(placeDouble6)));
                }
            }  
        }

        private void LoseYankee4_Checked(object sender, RoutedEventArgs e)
        {
            // Calculating value of odds
            try
            {
                bet1Value = ((Decimal.Parse(txtBox1Yankee1.Text) / Decimal.Parse(txtBox2Yankee1.Text))).ToString();
                bet2Value = ((Decimal.Parse(txtBox1Yankee2.Text) / Decimal.Parse(txtBox2Yankee2.Text))).ToString();
                bet3Value = ((Decimal.Parse(txtBox1Yankee3.Text) / Decimal.Parse(txtBox2Yankee3.Text))).ToString();
                bet4Value = ((Decimal.Parse(txtBox1Yankee4.Text) / Decimal.Parse(txtBox2Yankee4.Text))).ToString();

                // Calculating value of win part of bet
                winQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet3Value) + 1));

                winTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1) * (Convert.ToDouble(bet4Value) + 1));

                winDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet2Value) + 1));

                winDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet1Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet3Value) + 1));

                winDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet2Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                winDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(bet3Value) + 1)
                * (Convert.ToDouble(bet4Value) + 1));

                totalWinValue = Convert.ToString(Convert.ToDouble(winQuad) + (Convert.ToDouble(winTreble1)) + (Convert.ToDouble(winTreble2))
                + (Convert.ToDouble(winTreble3)) + (Convert.ToDouble(winTreble4)) + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(winDouble2))
                + (Convert.ToDouble(winDouble3)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(winDouble5)) + +(Convert.ToDouble(winDouble6)));

                txtBox3Yankee1.Text = totalWinValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);
            }

            // calculating the ew part of the bet
            try
            {
                if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Quarter_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                else if (Quarter_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 4);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }

                if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Fifth_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 5);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Fifth_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 5);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Fifth_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 5);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }
                else if (Fifth_OddsYankee1.IsChecked == true && Quarter_OddsYankee2.IsChecked == true && Quarter_OddsYankee3.IsChecked == true && Quarter_OddsYankee4.IsChecked == true && EW_CheckYankee1.IsChecked == true)
                {
                    newOdds1 = Convert.ToString(Convert.ToDouble(txtBox2Yankee1.Text) * 5);
                    newOdds2 = Convert.ToString(Convert.ToDouble(txtBox2Yankee2.Text) * 4);
                    newOdds3 = Convert.ToString(Convert.ToDouble(txtBox2Yankee3.Text) * 4);
                    newOdds4 = Convert.ToString(Convert.ToDouble(txtBox2Yankee4.Text) * 4);
                }

                newbet1 = Convert.ToString(Convert.ToDouble(txtBox1Yankee1.Text) / (Convert.ToDouble(newOdds1)));
                newbet2 = Convert.ToString(Convert.ToDouble(txtBox1Yankee2.Text) / (Convert.ToDouble(newOdds2)));
                newbet3 = Convert.ToString(Convert.ToDouble(txtBox1Yankee3.Text) / (Convert.ToDouble(newOdds3)));
                newBet4 = Convert.ToString(Convert.ToDouble(txtBox1Yankee4.Text) / (Convert.ToDouble(newOdds4)));

                placeQuad = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newbet3) + 1));

                placeTreble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeTreble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1) * (Convert.ToDouble(newBet4) + 1));

                placeDouble1 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet2) + 1));

                placeDouble2 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble3 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet1) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble4 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newbet3) + 1));

                placeDouble5 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet2) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                placeDouble6 = Convert.ToString(Convert.ToDouble(txtBokStakeYankee1.Text) * (Convert.ToDouble(newbet3) + 1)
                * (Convert.ToDouble(newBet4) + 1));

                totalPlaceValue = Convert.ToString(Convert.ToDouble(placeQuad) + (Convert.ToDouble(placeTreble1)) + (Convert.ToDouble(placeTreble2))
                + (Convert.ToDouble(placeTreble3)) + (Convert.ToDouble(placeTreble4)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                + (Convert.ToDouble(placeDouble3)) + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble5)) + +(Convert.ToDouble(placeDouble6)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Please Enter all needed fields!", MessageBoxButton.OK);

            }

            if (EW_CheckYankee1.IsChecked == false)
            {
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winTreble1) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)));
                }
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                else if (Yankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4));
                }
                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }
            else if (EW_CheckYankee1.IsChecked == true)
            {
                if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(winTreble1))
                    + (Convert.ToDouble(winDouble1)) + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2))
                    + (Convert.ToDouble(winDouble2)) + (Convert.ToDouble(winDouble4)) + (Convert.ToDouble(placeDouble4)));

                }
                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble1) + (Convert.ToDouble(placeDouble1)));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble2) + (Convert.ToDouble(placeDouble2)));
                }
                else if (Yankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(winDouble4) + (Convert.ToDouble(placeDouble4)));
                }

                else if (WinYankee1.IsChecked == true && WinYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(winDouble1))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(winDouble2))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee2.IsChecked == true && WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(winDouble4))
                    + (Convert.ToDouble(placeDouble1)) + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true & PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (WinYankee1.IsChecked == true && PlaceYankee2.IsChecked == true & PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee1.IsChecked == true && WinYankee2.IsChecked == true & PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble4) + (Convert.ToDouble(placeDouble4))
                    + (Convert.ToDouble(placeDouble4)) + (Convert.ToDouble(placeDouble4)));
                }
                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true & WinYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeTreble1) + (Convert.ToDouble(placeDouble1))
                    + (Convert.ToDouble(placeDouble2)) + (Convert.ToDouble(placeDouble4)));
                }

                else if (PlaceYankee1.IsChecked == true && PlaceYankee2.IsChecked == true & LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                else if (PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true & PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                else if (Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true & PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }

                else if (WinYankee1.IsChecked == true && PlaceYankee2.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                else if (WinYankee1.IsChecked == true && LoseYankee2.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                else if (WinYankee2.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble1));
                }
                else if (WinYankee2.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee3.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }

                else if (WinYankee3.IsChecked == true && PlaceYankee1.IsChecked == true && LoseYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble2));
                }
                else if (WinYankee3.IsChecked == true && Yankee1.IsChecked == true && PlaceYankee2.IsChecked == true)
                {
                    txtBox3Yankee1.Text = Convert.ToString(Convert.ToDouble(placeDouble4));
                }

                else
                {
                    txtBox3Yankee1.Text = "0";
                }
            }

        }

        private void NRYankee4_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bet is no longer a yankee. Please use another bet to get your winnings");
        }

        private void EW_CheckYankee1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}