

using System.Text;

namespace CleverenseSoftTests.Task1
{
    internal class Compressor : ICompression
    {
        /// <summary>
        /// aaabbc to a3b2c
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public String Compression(String line)
        {
            StringBuilder strBuilder = new StringBuilder();

            Int32 count = 0;

            for (Int32 i = 0; i < line.Length; i++)
            {
                strBuilder.Append(line[i]);
                count = 1;

                if(i == line.Length - 1) 
                {
                    break;
                }

                for (Int32 j = i + 1; j < line.Length; j++)
                {
                    if (line[i] != line[j]) 
                    {
                        i = j - 1;
                        break;
                    }
                    if (j == line.Length - 1)
                    {
                        count++;
                        i = j; 
                        break;
                    }
                    count++;
                }
                
                if(count > 1)
                {
                    strBuilder.Append(count.ToString());
                }
            }

            return strBuilder.ToString();
        }

        /// <summary>
        /// a3b2c to aaabbc
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public String Decompression(String line)
        {
            StringBuilder strBuilder = new StringBuilder();

            StringBuilder strBuilderNumber = new StringBuilder(); 

            for (Int32 i = 0; i < line.Length; i++)
            {
                strBuilderNumber.Clear();

                if (Char.IsNumber(line[i]))
                {
                    Int32 j;
                    for (j = i; j < line.Length; j++)
                    {
                        if (Char.IsNumber(line[j]))
                        {
                            strBuilderNumber.Append(line[j]);
                            continue;
                        }
                        break;
                    }
                    i = j - 1;
                }
                
                if (strBuilderNumber.Length > 0)
                {
                    Int32 countOfSymbol =  Convert.ToInt32(strBuilderNumber.ToString());
                    strBuilder.Append(line[i - strBuilderNumber.Length], countOfSymbol - 1);
                    continue;
                }
                strBuilder.Append(line[i]);   
            }

            return strBuilder.ToString();
        }
    }
}
