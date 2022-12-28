using APILibrary.Endpoints;
using Caliburn.Micro;
using DesktopUI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DesktopUI.ViewModels
{
    public class ShellViewModel : Screen
    {
        private ExpressionSolverEndpoint _expressionSolver = new ExpressionSolverEndpoint();

        private string _inputField = "";
        public string InputField
        {
            get 
            { 
                return _inputField;
            }
            set 
            {
                _inputField = value;
                NotifyOfPropertyChange(() => InputField);
                
            }
        }


        public async Task ButtonClicked(Button button)
        {
            //Check it is not back or clear
            if(button.Content.ToString() == "⌫")
            {
                if(InputField.Length != 0)
                {
                    InputField = InputField.Remove(InputField.Length - 1, 1);
                    return;
                }
                return;
            }

            if(button.Content.ToString() == "C")
            {
                InputField = "";
                return;
            }

            if(button.Content.ToString() == "=")
            {
                try
                {
                    InputField = await _expressionSolver.SolveExpressionAsync(")");
                }
                catch (Exception e)
                {
                    MessageBox.Show("");
                }
                return;
            }

            //Add to the textbox string
            InputField += button.Content;
        }
    }
}
