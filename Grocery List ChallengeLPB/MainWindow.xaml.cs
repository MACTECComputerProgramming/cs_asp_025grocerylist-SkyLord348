using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Grocery_List_ChallengeLPB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //The array and variables
        string[] itemListArray;
        int num = 0;
        double total = 0;   
        
        private void itemAmountButton_Click(object sender, RoutedEventArgs e)
        {
            //Hiding used button and starting list code
            itemList();
            textBlock2.Text = "Enter Item: ";
            itemAmountButton.Visibility = Visibility.Hidden;
            addItemButton.Visibility = Visibility.Visible;
        }

        private void addItemButton_Click(object sender, RoutedEventArgs e)
        {
            //Giving user info on what to do
            if (num + 1 == itemListArray.Length)
            {
               textBlock2.Text = "Push again to print";
            }
            else if (num+1 < itemListArray.Length)
            {
                textBlock2.Text = "Enter Item: " + (num + 2);
            }

            addItem();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void addItem()
        {
            //Number of Items in list code
            
            if (num < itemListArray.Length)
            {
                total += Convert.ToDouble(textBox3.Text);
                
                //Printing items in list but not to screen
                itemListArray[num] = textBox2.Text + string.Format(" {0:c}", 
                    Convert.ToDouble(textBox3.Text));

                num++;

            }
            //Printing out the total amount
            else
            {
                foreach (string item in itemListArray)
                {
                    resultLabel.Content += item + "\n";
                }

                totalLabel.Content = string.Format("Total: {0:c}", total);
            }




        }

        private void itemList()
        {
            //Item list array
            itemListArray = new string[Convert.ToInt32(textBox1.Text)];
        }

        



    }
}
