using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        const double BURGER_PRICE = 4.00;
        const double FRIES_PRICE = 2.00;
        const double DRINK_PRICE = 1.00;

        double tax = 1.13;
        

        int numOfBurgers = 0;
        int numOfFries = 0;
        int numOfDrink = 0;

        double subTotal = 0;
        double totalTax;
        double totalPrice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate1Button_Click(object sender, EventArgs e)
        {
            try
            {
                // get your inputs
                numOfBurgers = Convert.ToInt16(burgerBox.Text);
                numOfFries = Convert.ToInt16(friesBox.Text);
                numOfDrink = Convert.ToInt16(drinkBox.Text);

                // calculate amounts

                subTotal = BURGER_PRICE * numOfBurgers + FRIES_PRICE * numOfFries + DRINK_PRICE * numOfDrink;
                totalTax = subTotal * tax;
                totalPrice = subTotal + totalTax;

                // show outputs
                displayLabel.Text = "" + subTotal.ToString("C");
                displayLabel.Text += "\n\n" + totalTax.ToString("C");
                displayLabel.Text += "\n\n" + totalPrice.ToString("C");
            }
            catch
            {

            }
        }

        private void PrintrecieptButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Graphics Settings
                SoundPlayer Dot = new SoundPlayer(Properties.Resources.dot);
                Graphics g = this.CreateGraphics();
                Font receiptFont = new Font("consolas", 10);
                SolidBrush RecieptBrush = new SolidBrush(Color.Black);

                //The Reciept 
                Dot.Play();
                g.DrawString("Bob's Burger", receiptFont, RecieptBrush, 650, 70);

                Thread.Sleep(500); 

               g.DrawString("Burgers x " + numOfBurgers + "   " + BURGER_PRICE.ToString("C"), receiptFont,RecieptBrush,650,95);

                Thread.Sleep(500);

                g.DrawString("Fries x " + numOfFries + "     " + FRIES_PRICE.ToString("C"), receiptFont, RecieptBrush, 650, 110);

                Thread.Sleep(500);

                g.DrawString("Drink x " + numOfDrink + "     " + DRINK_PRICE.ToString("C"), receiptFont, RecieptBrush, 650, 130);
                Dot.Play();
                Thread.Sleep(500);

                g.DrawString("Subtotal " + subTotal.ToString("C"), receiptFont, RecieptBrush, 650, 150);

                Thread.Sleep(500);

                g.DrawString("Tax      " + totalTax.ToString("C"), receiptFont, RecieptBrush, 650, 170);

                Thread.Sleep(500);

                g.DrawString("Total    " + totalPrice.ToString("C"), receiptFont, RecieptBrush, 650, 190);
                
            }
            catch
            {

            }
        }

        private void NeworderButton_Click(object sender, EventArgs e)
        {
            //Graphics settings

            Graphics g = this.CreateGraphics();

            //clearing recieipt 

            g.Clear(Color.LightCoral);

            //resetting textbox value 

            burgerBox.Text = "";
            friesBox.Text = "";
            drinkBox.Text = "";

            //resting variables
            numOfBurgers = 0;
            numOfFries = 0;
            numOfDrink = 0;

            //resetting labels to show no amount so a new order can be placed 

            displayLabel.Text = "";
            

        }
    }
    }

