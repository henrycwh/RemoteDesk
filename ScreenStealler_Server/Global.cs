//## Author Information
//-**Author**: Feng-Hao Yeh
//-**Email**:
//  - Recommended: zzz3x2c1@gmail.com
//  - Alternate: yeh.feng.hao.110@gmail.com
//  - Work: yeh.feng.hao@try-n-go.com

namespace ScreenStealler_Network
{
    internal class Global
    {
        public static string Generate_Random_String(int Length)
        {
            Random r = new Random();
            string result = "";
            for (int i = 0; i < Length; i++)
            {
                switch(r.Next() % 3)
                {
                    case 0: // Uppercase Letter
                        result += (char)((r.Next() % 26) + 'A');
                        break;
                    case 1: // Lowercase Letter
                        result += (char)((r.Next() % 26) + 'a');
                        break;
                    default: // Number
                        result += (char)((r.Next() % 10) + '0');
                        break;
                }
            }
            return result;
        }
    }
}
