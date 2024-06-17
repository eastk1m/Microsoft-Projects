
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._2
{

    public partial Calculator : Form, ICaclulator 


        {

        double firstNumber = 0;
        string Operation = "";  
    

    public Calculator()
    {
        InitializeComponent();
    }

    void Add()
    { }


    internal interface ICalculator
    {
        void Add();
        void Subtract();
        void Multiply();
        void Divide();



    }
    private void Onebutton_Click(object sender, EventArgs e)

    { 
        if (ResulttextBox.Text == "1" && ResulttextBox.Text != null)

        {
            ResulttextBox.Text = "1";
        }

        else
        {

            ResulttextBox.Text == "1" && ResulttextBox.Text
        }


        }
    
    
    }
        
    }
}
