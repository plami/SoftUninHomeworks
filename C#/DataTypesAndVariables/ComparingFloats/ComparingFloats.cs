using System;

    class PrograComparingFloats
    {
        static void Main()
        {
            float firstA = 5.3f;
            float firstB = 6.01f;
            if ((firstA - firstB) <= 0.000001 && (firstA - firstB) >= -0.000001)
            {
                Console.WriteLine("true\nThe difference of 0.71 is too small (<eps)");
            }
            else
            {
                Console.WriteLine("false\nThe difference of 0.71 is too big (>eps)");
            }

            double secondA = 5.00000001d;
            double secondB = 5.00000003d;
            if ((secondA - secondB) <= 0.000001 && (secondA - secondB) >= -0.000001)
            {
                Console.WriteLine("true\nThe difference 0.00000002 <eps");
            }
            else
            {
                Console.WriteLine("false\nThe numbers are equal");
            }

            double thirdA = 5.00000005d;
            double thirdB = 5.00000001d;
            if ((thirdA - thirdB) <= 0.000001 && (thirdA - thirdB) >= -0.000001)
            {
                Console.WriteLine("true\nThe difference 0.00000004 <eps");
            }
            else
            {
                Console.WriteLine("false\nThe numbers are equal");
            }

            double fourthA = -0.0000007d;
            double fourthB = 0.00000007d;
            if ((fourthA - fourthB) <= 0.000001 && (fourthA - fourthB) >= -0.000001)
            {
                Console.WriteLine("true\nThe difference 0.00000077 <eps");
            }
            else
            {
                Console.WriteLine("false\nThe numbers are equal");
            }

            double fifthA = -4.999999d;
            double fifthB = -4.999998d;
            if ((fifthA - fifthB) <= 0.000001 && (fifthA - fifthB) >= -0.000001)
            {
                Console.WriteLine("true\nThe difference <eps");
            }
            else
            {
                Console.WriteLine("false\nBorder case.The difference 0.000001 ==eps.We consider the numbers are different.");
            }

            double sixthA = 4.999999d;
            double sixthB = 4.999998d;
            if ((sixthA - sixthB) <= 0.000001 && (sixthA - sixthB) >= -0.000001)
            {
                Console.WriteLine("true\nThe difference <eps");
            }
            else
            {
                Console.WriteLine("false\nBorder case.The difference 0.000001 ==eps.We consider the numbers are different.");
            }
        }
    }

