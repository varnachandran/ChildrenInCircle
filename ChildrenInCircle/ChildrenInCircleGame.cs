using System;
using System.Windows.Forms;

//The form does not take values of n<2 and k<1, so even if the user enters a 
//values which are not practical, the system resets n to 2 and k to 1
namespace ChildrenInCircle
{
    public partial class ChildrenInCircleGame : Form
    {
        public ChildrenInCircleGame()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            

            var currentchildren = new Children((int) Numberofchildren.Value, (int) Eliminationindex.Value);
            Results.Text = ("The Winner is the child with ID: " + currentchildren.FindWinner().ToString()+

           "\n\nThe Eliminated sequence is: " + string.Join(", ", currentchildren._eliminatedList));

        }

    
    }
}
