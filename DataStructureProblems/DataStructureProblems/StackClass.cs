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
    public class StackClass<T>
    {
        public bool BalancedParenthesis()
        {
            string expression = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
            Stack<char> objStack = new Stack<char>();

            foreach (char element in expression)
            {
                if (element == '(')
                {
                    objStack.Push(element);
                }
                if (element == ')')
                {
                    if (objStack.Count == 0)
                    {
                        Console.WriteLine("\n Expression is not balanced");
                        return false;
                    }
                    if (!objStack.Contains(element))
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
