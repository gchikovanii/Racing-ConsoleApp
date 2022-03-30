using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racing.Servicess.Services
{
    public class RegisterService
    {
        public List<char> ForbiddenCharacter = new List<char>() 
        { 
            '0','1','2','3','4','5','6','7','8','9',
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')',
            '-', '_', '+', '=', '\\', '|', '/', '{', '}', '[',
            ']', '?', ',', '.', '~', '`', '"', '<', '>', ':'
        };

        public bool ChekNickName(string name)
        {
            var charNickName = name.ToCharArray();
            for (int i = 0; i < charNickName.Length; i++)
            {
                for (int j = 0; j < charNickName.Length; j++)
                {
                    if (charNickName[i] == ForbiddenCharacter[j])
                        return false;
                }
            }
            return true;
        }
    }
}
