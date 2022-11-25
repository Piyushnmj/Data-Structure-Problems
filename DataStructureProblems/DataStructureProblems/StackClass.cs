using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class StackClass
    {
        public bool BalancedParenthesis()
        {
            string expression = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
            Stack<char> objStack = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    objStack.Push(expression[i]);
                }
                if (expression[i] == ')')
                {
                    if (objStack.Count == 0)
                    {
                        Console.WriteLine("\nExpression is not Balanced");
                        return false;
                    }
                    if (!expression[i].Equals(objStack.Peek()))
                    {
                        objStack.Pop();
                    }
                }
            }

            if (objStack.Count == 0)
            {
                Console.WriteLine("\nExpression is balanced");
                return true;
            }
            else
            {
                Console.WriteLine("\nExpression is not balanced");
                return false;
            }
        }
    }
}
