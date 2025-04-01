﻿namespace PacketListener
{
    public class Util
    {
        public static byte[] Encryption(byte[] ba)
        {
            for (int i = 0; i < ba.Length; i++)
            {
                ba[i] = (byte)(ba[i] ^ 0x00);
            }
            return ba;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", " ");
        }
    }
}
