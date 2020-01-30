using System;
using System.Globalization;
public static class NumericHelper // The methods in this class replicate the behavior of IsNumeric() and Val() Methods
{
    public static bool IsNumeric(object expression)
    {
        if (expression == null)
            return false;

        double testDouble;
        if (expression is string)
        {
            CultureInfo provider;
            if (((string)expression).StartsWith("$"))
                provider = new CultureInfo("en-US");
            else
                provider = CultureInfo.InvariantCulture;

            if (double.TryParse((string)expression, NumberStyles.Any, provider, out testDouble))
                return true;
        }
        else
        {
            if (double.TryParse(expression.ToString(), out testDouble))
                return true;
        }

        // This User Defined Method called 'IsNumeric'  returns true for any boolean value:
        bool testBool;
        if (bool.TryParse(expression.ToString(), out testBool))
            return true;

        return false;
    }

    public static double Val(string expression)
    {
        if (expression == null)
            return 0;

        // try the entire string, then progressively smaller substrings to replicate the behavior of 'Val', which ignores trailing characters after a recognizable value
        for (int size = expression.Length; size > 0; size--)
        {
            double testDouble;
            if (double.TryParse(expression.Substring(0, size), out testDouble))
                return testDouble;
        }

        // No value is recognized, so return 0:
        return 0;
    }

    public static double Val(object expression)
    {
        if (expression == null)
            return 0;

        double testDouble;
        if (double.TryParse(expression.ToString(), out testDouble))
            return testDouble;

        // This User Defined Method called 'Val' returns -1 for 'true'
        bool testBool;
        if (bool.TryParse(expression.ToString(), out testBool))
            return testBool ? -1 : 0;

        // This User Defined Method called 'Val' returns the day of the month for dates
        DateTime testDate;
        if (DateTime.TryParse(expression.ToString(), out testDate))
            return testDate.Day;

        // No value is recognized, so return 0
        return 0;
    }

    public static int Val(char expression)
    {
        int testInt;
        if (int.TryParse(expression.ToString(), out testInt))
            return testInt;
        else
            return 0;
    }
}