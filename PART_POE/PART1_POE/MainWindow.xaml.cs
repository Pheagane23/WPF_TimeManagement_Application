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
using POE_part1_CLASSLIBRARY;

namespace PART1_POE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int Number_of_credits;
        private int Number_of_weeks;
        private int Number_of_hours;
        private int toStudy;
        public MainWindow()
        {
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string hoursSpent = Convert.ToString(toStudy);
            int hoursRemaining = int.Parse(CreditsTxtBox1.Text)*10/ int.Parse(WeekModuleTxtBox1.Text) - int.Parse(TimeModuleTxtBox1.Text);
            MessageBox.Show("Module code: " + ModuleCodeTxtBox1.Text.ToUpper() + ",  " + "Module name: "
                + ModuleNameTxtBox1.Text.ToUpper() + ", " + "your self-study hours per week: " + hoursSpent + ",  "
                + "your remaing hours: " + Convert.ToString(hoursRemaining));
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ModuleCodeTxtBox1.Clear();
            ModuleNameTxtBox1.Clear();
            CreditsTxtBox1.Clear();
            TimeModuleTxtBox1.Clear();
            WeekModuleTxtBox1.Clear();
            

        }

        private void DetailsBtn_Click(object sender, RoutedEventArgs e)
        {

            Calculation CalcSt = new Calculation();
            Number_of_credits = int.Parse(this.CreditsTxtBox1.Text);
            Number_of_weeks = int.Parse(this.WeekModuleTxtBox1.Text);
            Number_of_hours = int.Parse(this.TimeModuleTxtBox1.Text);
            toStudy = CalcSt.StudyCal(Number_of_credits, Number_of_weeks, Number_of_hours);
            string hoursSpent = Convert.ToString(toStudy);
            int hoursRemaining = int.Parse(TimeModuleTxtBox1.Text) - int.Parse(TimeModuleTxtBox1.Text);

            // output shown for hours spent and hours remaining in a messagebox
            MessageBox.Show("Your study hours per week: " + hoursSpent);

            
            MessageBox.Show(Convert.ToString("Your hours remaining: " + hoursRemaining));

            
        }

        private void TimeModuleTxtBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
