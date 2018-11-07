using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Shape
    {
        private string sTop;
        private string sBott;
        private string sLeft;
        private string sRight;

        public string Top { get => sTop; set => sTop = value; }
        public string Bott { get => sBott; set => sBott = value; }
        public string Left { get => sLeft; set => sLeft = value; }
        public string Right { get => sRight; set => sRight = value; }

        public Shape(string top, string bott, string left, string right)
        {
            Top = top;
            Bott = bott;
            Right = right;
            Left = left;
        }
        public string determineShape()
        {
            string retbool;
            if (sTop != sBott || sLeft != sRight)
            {
                retbool = "Neither";
            }
            else if ((sLeft == sRight && sTop == sBott) && (sTop != sLeft))
            {
                retbool = "Rectangle";
            }
            else
            {
                retbool = "Square";
            }


            return retbool;

        }
    }
    }
