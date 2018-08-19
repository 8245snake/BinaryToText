using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BinaryToText
{
    /// <summary>
    /// バイナリ <-> テキストの変換を行うクラス
    /// </summary>
    public static class Converter
    {
        public const string ERROR_STRING = "**ERROR**";

        private static CharTable[] charTable = CharTable.CreateCharTable();

        public static byte[] FilePathToBinArr(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, data.Length);
            fs.Close();
            return data;
        }

        public static string ConvertBinaryToString(byte data)
        {
            return string.Format("{0:X2}", data);
        }

        public static string[] ConvertBinaryToString(byte[] data)
        {
            string rtnStr = "";

            for (int i = 0; i < data.Length; i++)
            {
                rtnStr += string.Format("{0:X2} ", data[i]);
            }

            return rtnStr.Split(' ');
        }


        public static string ConvertHxToString(string hex)
        {
            string rtnStr = hex;
            
            foreach (CharTable item in charTable)
            {
                rtnStr = item.Convert(hex);
                if (rtnStr != hex)
                {
                    return rtnStr;
                }
            }

            return ERROR_STRING;
        }
    }
}
