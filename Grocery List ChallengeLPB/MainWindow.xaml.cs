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

        

        //DON'T FORGET TO USE METHODS

        

        
        
        
        private void itemAmountButton_Click(object sender, RoutedEventArgs e)
        {
            //string[] items = new string[5] { textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text, textBox1.Text};

            //items = temp1;

        }

        private void addItemButton_Click(object sender, RoutedEventArgs e)
        {
            //Show number of items stored code
            int itemAmount = 0; 

            while (itemAmount < int.Parse(textBox1.Text))
            {
                
                //Print out grocery list
                resultLabel.Content = "In while loop";
                itemAmount++;

                

                //Clear text boxes after every item

                //textBox2.Clear();
                //textBox3.Clear();

                
            }
            resultLabel.Content = "Outside of while loop";


        }

        //Make array(s)

       // string[] temp1 = new string[5];
        //string[] temp2 = new string[5];


    }
}
