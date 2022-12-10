using NUnit.Framework;

namespace TransWordTestProject
{
    public class TransWordUnitTest
    { 
        [TestCase("AppleCat", "apple_cat")]
        [TestCase("MCHammer", "m_c_hammer")]
        [TestCase("", "")]
        
        public void TransWordTest(string words, string answer)
        {
            string result = TransWordtoLower(words); 
            Assert.IsTrue(answer.Equals(result));
        }
        /// <summary>
        /// �N�j�g�r���ন���u�P�p�g
        /// �}�Y�j�g�u�ഫ�p�g
        /// null, �Ŧr��^�Ǧۤv
        /// </summary>
        /// <param name="words">�ഫ�r��</param>
        /// <returns></returns>
        public static string TransWordtoLower(string words)
        {
            string result = "";
            if (string.IsNullOrEmpty(words)) return words;

            result = char.ToLower(words[0]).ToString();

            for (int i = 1; i < words.Length; i++)
            {
                if (char.IsUpper(words[i]))
                {
                    result += '_' + char.ToLower(words[i]).ToString();
                    continue;
                }                 
                result += words[i].ToString();
                
            }


            return result;

        }

    }
   
}