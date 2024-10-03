using System;
using System.Collections.Generic;

class Solution
{
    public int[] PlusOne(int[] digits)
    {
        // بدء من الرقم الأخير في المصفوفة
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            // إذا كان الرقم أقل من 9، يمكن زيادة الرقم بمقدار 1
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits; // إرجاع النتيجة
            }
            // إذا كان الرقم يساوي 9، يتم تحويله إلى 0
            digits[i] = 0;
        }

        // إذا كانت جميع الأرقام 9، نحتاج إلى إضافة 1 في بداية المصفوفة
        int[] result = new int[digits.Length + 1];
        result[0] = 1; // إضافة الرقم 1 في بداية المصفوفة
        Array.Copy(digits, 0, result, 1, digits.Length); // نسخ الأرقام إلى المصفوفة الجديدة
        return result;
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        // أمثلة على الاستخدام
        int[] digits1 = { 1, 2, 3 };
        int[] result1 = solution.PlusOne(digits1);
        Console.WriteLine(string.Join(" ", result1)); // الناتج: 1 2 4

        int[] digits2 = { 4, 3, 2, 1 };
        int[] result2 = solution.PlusOne(digits2);
        Console.WriteLine(string.Join(" ", result2)); // الناتج: 4 3 2 2

        int[] digits3 = { 9 };
        int[] result3 = solution.PlusOne(digits3);
        Console.WriteLine(string.Join(" ", result3)); // الناتج: 1 0
    }
}
