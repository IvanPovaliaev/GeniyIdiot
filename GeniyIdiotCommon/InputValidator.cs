using System;

namespace GeniyIdiot.Common
{
    public static class InputValidator
    {
        public static bool TryGetInt32(string answer, out int number, out string errorMessage)
        {
            try
            {
                number = int.Parse(answer);
                errorMessage = string.Empty;
                if (number < int.MinValue || number > int.MaxValue) throw new Exception("Число не в заданных границах");
                return true;
            }
            catch
            {
                errorMessage = ($"Пожалуйста, введите целое число в диапазоне от {int.MinValue} до {int.MaxValue}");
                number = 0;
                return false;
            }
        }
        public static bool TryGetInt32(string answer, int minValue, int maxValue, out int number, out string errorMessage)
        {
            try
            {
                number = int.Parse(answer);
                errorMessage = string.Empty;
                if (number < minValue || number > maxValue) throw new Exception("Число не в заданных границах");
                return true;
            }
            catch
            {
                errorMessage = ($"Пожалуйста, введите целое число в диапазоне от {minValue} до {maxValue}");
                number = 0;
                return false;
            }
        }
        public static bool TryGetString(string answer, out string text, out string errorMessage)
        {        
            if (answer.NullIfEmpty() == null)
            {
                text = string.Empty;
                errorMessage = $"Пожалуйста, введите текст вопроса!";
                return false;
            }

            text = answer;
            errorMessage = string.Empty;
            return true;


        }
    }
}
