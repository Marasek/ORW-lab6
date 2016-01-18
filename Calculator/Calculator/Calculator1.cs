using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Calculator1
    {
        Operator[] _operatory = new Operator[]
        {
            new Operator('+', (left,right) => { return left + right;} ),
            new Operator('-', (left,right) => { return left - right;} ),
            new Operator('*', (left,right) => { return left * right;} ),
            new Operator('/', (left,right) => { return left / right;} )
        };

        class Operator
        {
            public char Symbol;
            public Func<int, int, int> Function;
            public Operator(char symbol, Func<int, int, int> function)
            {
                Symbol = symbol;
                Function = function;
            }
        }

        public int Calculate(string input)
        {
            foreach (var o in _operatory)
            {
                if (input.Contains(o.Symbol))
                {
                    string[] parts = input.Split(new char[] { o.Symbol }, StringSplitOptions.RemoveEmptyEntries);
                    int left = Convert.ToInt32(parts[0]);
                    int right = Convert.ToInt32(parts[1]);
                    return o.Function(left, right);
                }
            }
            throw new InvalidOperationException();
        }
    }
}
