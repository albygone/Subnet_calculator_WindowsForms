using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubNetMask_calculator
{
    public class Ip
    {
        public byte byte1;
        public byte byte2;
        public byte byte3;
        public byte byte4;

        public Ip(byte _byte1, byte _byte2, byte _byte3, byte _byte4)
        {
            byte1 = _byte1;
            byte2 = _byte2;
            byte3 = _byte3;
            byte4 = _byte4;
        }

        #region static

        public static int getAvailableHosts(Ip subNet)
        {
            Ip aus = subNet.getWildCard();
            return ((aus.byte1 | 1) * (aus.byte2 | 1) * (aus.byte3 | 1) * (aus.byte4 | 1)) - 1;
        }

        public static uint getAvailableSubNets(Ip broadcastIp, Ip networkIp)
        {
            //uint nBr = BitConverter.ToUInt32(new byte[]{ broadcastIp.byte4, broadcastIp.byte3, broadcastIp.byte2, broadcastIp.byte1 }, 0);
            //uint nNw = BitConverter.ToUInt32(new byte[] { networkIp.byte4, networkIp.byte3, networkIp.byte2, networkIp.byte1 }, 0);

            uint nBr = Convert.ToUInt32(broadcastIp.ToBinaryString().Replace(".", ""), 2);
            uint nNw = Convert.ToUInt32(networkIp.ToBinaryString().Replace(".", ""), 2);

            return ((nBr - nNw) / 256) | 1;
        }

        public static string getClass(Ip ip)
        {
            int firstByte = ip.byte1;
            string ipClass = "";

            if (firstByte >= 0 && firstByte <= 127)
                ipClass = "A";
            else if (firstByte >= 128 && firstByte <= 191)
                ipClass = "B";
            else if (firstByte >= 192 && firstByte <= 223)
                ipClass = "C";
            else if (firstByte >= 224 && firstByte <= 239)
                ipClass = "D";
            else if (firstByte >= 240 && firstByte <= 255)
                ipClass = "E";

            return ipClass;
        }

        #endregion

        public override string ToString() 
        {
            return $"{byte1}.{byte2}.{byte3}.{byte4}";
        }

        public string ToBinaryString() => 
                $"{Convert.ToString(byte1, 2).PadLeft(8,'0')}." +
                $"{Convert.ToString(byte2, 2).PadLeft(8, '0')}." +
                $"{Convert.ToString(byte3, 2).PadLeft(8, '0')}." +
                $"{Convert.ToString(byte4, 2).PadLeft(8, '0')}";

        public string ToXFormat()
        {
            string bitString = ToBinaryString().Replace(".", "");
            int i = 0;
            while (bitString[i] == '1' && i < bitString.Length)
                i++;

            return $"{ToString()}/{i}";
        }

        public static Ip operator &(Ip c, Ip c2)
        {
            return new Ip(
                    (byte)(c.byte1 & c2.byte1),
                    (byte)(c.byte2 & c2.byte2),
                    (byte)(c.byte3 & c2.byte3),
                    (byte)(c.byte4 & c2.byte4)
                );
        }

        public static Ip operator |(Ip c, Ip c2)
        {
            return new Ip(
                    (byte)(c.byte1 | c2.byte1),
                    (byte)(c.byte2 | c2.byte2),
                    (byte)(c.byte3 | c2.byte3),
                    (byte)(c.byte4 | c2.byte4)
                );
        }

        public Ip getWildCard()
        {
            return new Ip(
                    (byte)~(byte1),
                    (byte)~(byte2),
                    (byte)~(byte3),
                    (byte)~(byte4)
                );
        }
    }
}
