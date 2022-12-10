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
        /// 將大寫字母轉成底線與小寫
        /// 開頭大寫只轉換小寫
        /// null, 空字串回傳自己
        /// </summary>
        /// <param name="words">轉換字串</param>
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