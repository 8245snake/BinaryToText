using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BinaryToText
{
    class CommonIO
    {


        /// <summary>
        /// ファイルを読んで1行ずつ返す
        /// </summary>
        /// <param name="stFilePath">ファイルのパス</param>
        /// <returns></returns>
        public static IEnumerable<string> ReadFileByLine(string stFilePath)
        {
            string stLine;

            using (StreamReader sr = new StreamReader(stFilePath, Encoding.GetEncoding("Shift_JIS")))
            {
                try
                {
                    while ((stLine = sr.ReadLine()) != null)
                    {
                        yield return stLine;
                    }
                }
                finally
                {
                }
            }
        }

        public static IEnumerable<string> ReadFileByChar(string stFilePath)
        {
            int ch;

            using (StreamReader sr = new StreamReader(stFilePath, Encoding.GetEncoding("Shift_JIS")))
            {
                while ((ch = sr.Read()) != -1) //１文字読込み
                {
                    yield return ((char)ch).ToString();
                }
            }
        }


        /// <summary>
        /// ファイルを1byteずつ読む
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static IEnumerable<byte> ReadFileToBinary(string filePath)
        {
            //ファイルを一時的に読み込むバイト型配列を作成する
            byte[] bs = new byte[1];

            int readSize;

            //ファイルを開く
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                do
                {
                    //ファイルの一部を読み込む
                    readSize = fs.Read(bs, 0, bs.Length);

                    //ファイルをすべて読み込んだときは終了する
                    if (readSize == 0) { break; }

                    yield return bs[0];

                } while (true);
            }
        }

        /// <summary>
        /// テキストを書き込む
        /// </summary>
        /// <param name="stPath">ファイルのパス</param>
        /// <param name="stText">書き込む文字列</param>
        /// <param name="blAppend">追記か否か</param>
        public static void WriteText(string stPath, string stText, bool blAppend = false, bool writeByLine = true)
        {
            using (System.IO.StreamWriter sw =
                new System.IO.StreamWriter(stPath, blAppend, System.Text.Encoding.GetEncoding("shift_jis")))
            {
                try
                {
                    if (writeByLine)
                    {
                        sw.WriteLine(stText);
                    }
                    else
                    {
                        sw.Write(stText);
                    }
                    
                }
                catch
                {
                }
            }
        }

        public static void WriteBinary(string stPath, byte data)
        {
            using (FileStream fs = new FileStream(stPath, FileMode.Append, FileAccess.Write))
            {
                fs.WriteByte(data);
            }
        }



    }

    
}
