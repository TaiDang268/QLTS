using Microsoft.AspNetCore.DataProtection.XmlEncryption;

namespace MISA.WebFresher042023.Demo
{
    /// <summary>
    /// Lớp côngj trừ nhân chia
    /// Created by DVTAI(09/06/2023)
    /// </summary>
    public class Caculator
    {
        /// <summary>
        /// Hàm cộng 2 số nguyên 
        /// </summary>
        /// <param name="a">Toán hạng 1</param>
        /// <param name="b">Toán hạng 2</param>
        /// <returns>Tổng 2 số nguyên</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Hàm trừ 2 số nguyên 
        /// </summary>
        /// <param name="a">Toán hạng 1</param>
        /// <param name="b">Toán hạng 2</param>
        /// <returns>Hiệu 2 số nguyên</returns>
        /// Created by DVTAI (09/06/2023)
        public int Sub(int a, int b)
        {
            return a - b;
        }
        /// <summary>
        /// Hàm nhân 2 số nguyên 
        /// </summary>
        /// <param name="a">Toán hạng 1</param>
        /// <param name="b">Toán hạng 2</param>
        /// <returns>Nhân 2 số nguyên</returns>
        /// Created by DVTAI (09/06/2023)
        public long Mul(int a, int b)
        {
            return (long)a * b;
        }

        /// <summary>
        /// Hàm chia         /// </summary>
        /// <param name="a">Toán hạng 1</param>
        /// <param name="b">Toán hạng 2</param>
        /// <returns>Chia 2 số </returns>
        /// Created by DVTAI (09/06/2023)
        public Double Div(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Không chia được cho 0");
            }
            return (Double)a / b;

        }
    }
}
