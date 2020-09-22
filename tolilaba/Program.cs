using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tolilaba
{
    public class Matrix
    {
        private int row;
        cell first;
        public cell First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }
        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }
        private int col;
        public int Col
        {
            get
            {
                return col;
            }
            set
            {
                col = value;
            }
        }
        Matrix() { first = null; }
        public Matrix(int r, int c) 
        {
            row = r;
            col = c;
            first = null;
        }
        public class cell
        {
            public cell(int i, int j, int val) 
            {
                this.i = i;
                this.j = j;
                this.val = val;
            }
            public int i;
            
            public int j;
            
            public double val;
            public cell next;
        }
        public Matrix Sum(Matrix m)
        {
            return new Matrix();
        }
        public Matrix MultiplierMatrix(Matrix m)
        {
            return new Matrix();
        }
        public Matrix MultiplierNumber(Matrix m)
        {
            return new Matrix();
        }
        public double Det(Matrix m)
        {
            return 0;
        }
        public Matrix Push(cell c)
        {

        }





        static void Main(string[] args)
        {


        }

    }
}
