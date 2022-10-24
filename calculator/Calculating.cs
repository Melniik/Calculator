using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public class Calculating
    {
        private bool operand1=true; 
        private bool operand2=true;
        private int numLimit=9;
        private int action=0;
        private double resultOfCalculations;
        private string result;
        private double firstNum;
        private double secondNum;
        public Calculating() { }

        // прибавляет введенные к общему
        public string EnteredNum(string enteredNum)
        {
            if (result == null||result.Length <= numLimit)
            {
                result += enteredNum;
            }
            return result;
        }
       
        public void Action(int action2,Label label) 
        {
            try
            {
                label.Text = "";
                
                if (firstNum != 0 && result != "")
                {
                    Equals(label);
                    action = action2;
                    result = "";
                }
                
                
                if (result != "" && action == 0)
                {

                    firstNum = Convert.ToDouble(result);
                    action = action2;
                    result = "";
                }
                
                if (action != 0)
                {
                    action = action2;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // смена знака +/-
        public void OperandChange(Label label) 
        {
            if (result != "") 
            {
               
                if (firstNum != 0)
                {
                    operand2 = !operand2;
                    if (operand2 == true) label.Text = "";
                    else label.Text = "-";
                }
                
                else 
                {
                    operand1 = !operand1;
                    if (operand1 == true) label.Text = "";
                    else label.Text = "-";
                }
            }
            
        }
        
        public string Equals(Label label) 
        {
            if (result != "")
            {
                secondNum = Convert.ToDouble(result);
                
                if (operand1 == false) firstNum *= (-1);
                if (operand2 == false) secondNum *= (-1);
                
                switch (action) 
                {
                    //plus
                    case 1:resultOfCalculations = firstNum + secondNum; break;
                    //minus
                    case 2:resultOfCalculations = firstNum - secondNum;break;
                    //*
                    case 3:resultOfCalculations = firstNum * secondNum;break;
                    // divide
                    case 4:resultOfCalculations = firstNum / secondNum;break;
                    
                }
                
            }
           
            if (resultOfCalculations.ToString().Length > numLimit) return "EXCEED";
            if (resultOfCalculations < 0)
            {
                operand1 = false;
                label.Text = "-";
            }
            else
            {
                operand1 = true;
                label.Text = "";
            }
            operand2 = true;
            resultOfCalculations = Math.Abs(resultOfCalculations);
            firstNum = resultOfCalculations;
            result = resultOfCalculations.ToString();
            secondNum = 0;
            action = 0;
            return result;
        }
        //сброк(кнопка "C")
        public void Reset(Label label) 
        {
            resultOfCalculations = 0;
            firstNum = 0;
            secondNum = 0;
            result = "";
            action = 0;
            operand1 = true;
            operand2 = true;
            label.Text = "";
        }


    }
}
