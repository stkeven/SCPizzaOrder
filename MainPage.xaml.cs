using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//Namespace holds everything
namespace SCPizzaOrder
{//this class holds all the methods
    public partial class MainPage : ContentPage
    {//this is the classs for the constructer method
        public MainPage()
        {//Intializes all the components
            InitializeComponent();
        }
        /// <summary>
        /// Clicked event to order pizza with all of the options that the user selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOrder_Clicked(object sender, EventArgs e)
        {
            //This is to tell the computer that the cheese, or the pepperoni, or the pineapple are selected
            if (SwtchCheese.IsToggled|| SwtchPepperoni.IsToggled || SwtchPineapple.IsToggled)
            {//SelectedIndex is 0 for the first item, 1 for the second etc. If they don't select anything then we want to show that its not valid.
             //The value for SelectedIndex for not selecting anything is -1, therefore this statement says "if the value is greater than -1 then..."
                if (PckCrust.SelectedIndex > -1)
                {//This says that if the selected item string is not an empty string, then we know an item was selected. This is for city
                    if (LstViewCity.SelectedItem.ToString() != "")
                    {//Determines if the toppings selection was empty or...
                        string toppings = "";
                        //This concatenates the users selection for crust
                        string crust = PckCrust.SelectedItem.ToString();
                        //This concatenates the users selection for city
                        string city = LstViewCity.SelectedItem.ToString();
                        //determines if cheese was selected or...
                            toppings = SwtchCheese.IsToggled ? "Cheese" :
                        //determines if pepperoni was selected or...
                            toppings += SwtchPepperoni.IsToggled ? "Pepperoni ":
                        //determines if pineapple was selected
                            toppings += SwtchPineapple.IsToggled ? "Pineapple " : "";

                        //Displays an alert with the type of crust and toppings delivered to what city
                        DisplayAlert("Pizza Order", $"{crust} pizza with {toppings} will be delivered to {city}. Thank you for using our app!", "Close");
                    }
                    else
                    {//Displays alert to user if they didn't select a city
                        DisplayAlert("Invalid Input", "Please select a city.", "Close");
                    }

                }
                else
                {//Displays alert to user if a crust was not selected
                    DisplayAlert("Invalid Input", "Please select a crust.", "Close");
                }

            }//If none of the toppings are selected, the program goes here.
            else
            {//Displays alert to user to select at least one topping
                DisplayAlert("Invalid Input", "Please select at least one topping.", "Close");
            }
        }
    }
}
