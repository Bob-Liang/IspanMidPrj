using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrjEIP.models
{
    public class CPasswordStrengthChecker
    {
        //先建立enum給下面的switch case使用
        public enum PasswordStrength
        {
            VeryWeak,
            Weak,
            Medium,
            Strong,
            VeryStrong
        }
        public static PasswordStrength CheckStrength(string password)
        {
            //符合下列條件的話,密碼強度分數就++
            int score = 0;
            if (password.Length >= 8) score++;
            if (Regex.IsMatch(password, @"[a-z]")) score++;
            if (Regex.IsMatch(password, @"[A-Z]")) score++;
            if (Regex.IsMatch(password, @"[0-9]")) score++;
            if (Regex.IsMatch(password, @"[\w_]")) score++;

            //使用switch來判斷各個情況的分數
            switch (score)
            {
                case 1:
                    return PasswordStrength.VeryWeak;
                case 2:
                    return PasswordStrength.Weak;
                case 3:
                    return PasswordStrength.Medium;
                case 4:
                    return PasswordStrength.Strong;
                case 5:
                    return PasswordStrength.VeryStrong;
                default:
                    return PasswordStrength.VeryWeak;
            }
        }

    }
}
