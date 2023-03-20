using System;
using System.Linq;

namespace String.Utils {
    public static class StringUtils {

        public static int ContaCaracteres(string _str, char[] _chars) {
            string str = _str.ToLower();
            char[] chars = _chars.Select(c => $"{c}".ToLower()[0]).ToArray();
            int count = 0;

            foreach (char c in str) {

                foreach (char _c in chars) {
                    if (c == _c) {
                        count++;
                        break;
                    }
                }

            }

            return count;
        }

        public static bool VerificaSenha(string senha) {

            //tamanho
            int tamanhoSenha = senha.Length;
            if (tamanhoSenha < 8) return false;

            //caracter especial
            bool thereIsCharc = false;
            char[] charcEspecials = new char[] { '!', '@', '#' };
            foreach (char c in senha) {
                foreach (char cE in charcEspecials) {
                    if (c == cE) {
                        thereIsCharc = true;
                    }
                }
            }
            if (!thereIsCharc) return false;

            //caracter numérico
            bool thereIsNumber = false;
            char[] charcNumber = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            foreach (char c in senha) {
                foreach (char cN in charcNumber) {
                    if (c == cN) {
                        thereIsNumber = true;
                    }
                }
            }
            if (!thereIsNumber) return false;

            //caracter maiúsculo
            bool thereIsUpper = false;
            char[] charcUpper = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'W', 'Y', 'Z'};
            foreach (char c in senha) {
                foreach (char cU in charcUpper) {
                    if (c == cU) {
                        thereIsUpper = true;
                    }
                }
            }
            if (!thereIsUpper) return false;

            return true;

        }

    }
}
