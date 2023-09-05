using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaswordChecker
{
    public class Checker
    {

        public int PasswordCheck(string password) {
            int passwordLength = 7;
            int truePoints = 0;
            string spec = "@#$%!&";



            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    truePoints++;
                    break;
                }
            }

            if (truePoints != 1) return 0;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    truePoints++;
                    break;
                }
            }

            if (truePoints != 2) return 1;

            foreach (char c in password)
            {
                if (spec.Contains(c))
                {
                    truePoints++;
                    break;
                }
            }

            if (truePoints != 3) return 2;

            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    truePoints++;
                    break;
                }
            }

            if (truePoints != 4) return 3;

            if (password.Length == passwordLength && truePoints == 4) return 5;
            else
            {
                return 4;
            }
        }
    }
}
