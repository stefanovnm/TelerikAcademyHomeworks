using System;

namespace SchoolSystem.Models
{
    internal static class Validation
    {
        internal static bool ValidateName(string name)
        {
            bool isValid = true;

            if (name.Length > 31 || name.Length < 2)
            {
                isValid = false;
                throw new ArgumentOutOfRangeException("Name should be between 2 and 31 symbols!");
            }

            foreach (char letter in name)
            {
                if (!IsBasicLetter(letter))
                {
                    isValid = false;
                    throw new ArgumentException("Name contains illegal letters!");
                }
            }

            return isValid;
        }

        private static bool IsBasicLetter(char letter)
        {
            int letterInt = letter;
            return !(letterInt < 65 || letterInt > 122 || (letterInt > 90 & letterInt < 97));
        }
    }
}