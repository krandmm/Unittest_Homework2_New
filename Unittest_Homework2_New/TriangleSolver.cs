using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unittest_Homework2_New
{
    public class TriangleSolver
    {
        /// <summary>
        /// Analyze whether the input integer is isosceles triangle or equilateral triangle or scalene triangle .
        /// </summary>
        /// <param name="sidea"></param>
        /// <param name="sideb"></param>
        /// <param name="sidec"></param>
        /// <returns></returns>
        public static String Analyze(int sidea, int sideb, int sidec)
        {
            String results = "";

                ///Eheck if the input is in triangle format
                if (sidea + sideb > sidec && sidea + sidec > sideb && sideb + sidec > sidea)
                {
                    ///Verify input is an equilateral triangle
                    if (sidea == sideb && sideb == sidec)
                    {
                        results = "Your input is an EQUILATERAL TRIANGLE.";

                    }
                    ///Eheck if the input is an Isosceles triangle
                    else if (sidea == sideb || sideb == sidec || sidec == sidea)
                    {
                        results = "Your input is an ISOSCELES TRIANGLE.";

                    }
                    ///Eheck if the input is an Scalene triangle
                    else
                    {
                        results = "Your input is a SCALENE TRIANGLE.";
                    }

                }
                ///Eheck if the input is Zero Number
                else if  (sidea == 0 && sideb == 0 && sidec == 0)
                {
                    results = "Your input are Zero number.";
                    
                }
                ///Eheck if the input is Negative Number
                else if (sidea < 0 && sideb < 0 && sidec < 0)
                {
                    results = "Your input are all of negative number.";

                }
                ///Eheck if the input of Side A is an Negative Number
                else if (sidea  < 0 && sideb > 0 && sidec > 0)
                {
                    results = "Side A input is a negative number.";

                }
                ///Eheck if the input of Side B is an Negative Number
                else if (sidea > 0 && sideb < 0 && sidec > 0)
                {
                    results = "Side B input is a negative number.";

                }
                ///Eheck if the input of Side C is an Negative Number
                else if (sidea > 0 && sideb > 0 && sidec < 0)
                {
                    results = "Side C input is a negative number.";

                }
            
            return results;
        }

    }
}
