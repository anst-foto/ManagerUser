using System;

namespace CheckPass
{
    public class CheckPassword
    {
        private readonly string _symbols1;
        private readonly string _symbols2;
        private readonly string _symbols3;
        private readonly string _symbols4;
        private readonly string _alphabet;
        private readonly int _length;

        public CheckPassword()
        {
            _symbols1 = "QWERTYUIOPASDFGHJKLZXCVBNM";
            _symbols2 = "qwertyuiopasdfghjklzxcvbnm";
            _symbols3 = "1234567890";
            _symbols4 = "@#$%^&*!-=_,.:;<>";
            _alphabet = _symbols1 + _symbols2 + _symbols3 + _symbols4;
            _length = 8;
        }

        public bool CheckMinLength(string password)
        {
            return password.Length >= _length;
        }

        public bool CheckIsCorrect(string password)
        {
            var check1 = password.IndexOfAny(_symbols1.ToCharArray());
            var check2 = password.IndexOfAny(_symbols2.ToCharArray());
            var check3 = password.IndexOfAny(_symbols3.ToCharArray());
            var check4 = password.IndexOfAny(_symbols4.ToCharArray());

            return check1 != -1 && check2 != -1 && check3 != -1 && check4 != -1;
        }

        public bool CheckAlphabet(string password)
        {
            foreach (var symbol in password)
            {
                var check = _alphabet.IndexOf(symbol);
                if (check == -1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}