using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static BinaryToText.Converter;
using static BinaryToText.CommonIO;
using System.IO;

namespace BinaryToText
{
    class Program
    {
        private const int MODE_ASCII = 0;
        private const int MODE_BINARY = 1;

        private const string ARG_ASCII = "/A";
        private const string ARG_BINARY = "/B";


        static void Main(string[] args)
        {
            string[] cmdArgs = Environment.GetCommandLineArgs();
            string errorMsg = "";

            //引数チェック
            if (!CheckArg(cmdArgs, out errorMsg))
            {
                Console.WriteLine(errorMsg);
                Console.ReadKey();
                return;
            }

            //モードを判定
            int mode = GetProcessMode(cmdArgs);

            //入力ファイルのパス
            string inFilePath = cmdArgs[1];

            //出力ファイルのパス（モードで異なる）
            string outFilePth;

            if (mode == MODE_ASCII)
            {
                //出力ファイルのパス
                //アスキーモードのときは拡張子なしのバイナリファイルを返す
                outFilePth = Path.Combine(Path.GetDirectoryName(inFilePath), Path.GetFileNameWithoutExtension(inFilePath));

                //出力ファイルをクリア
                WriteText(outFilePth, "", false, false);

                //実行
                ExecASCIIMode(inFilePath, outFilePth);
            }
            else
            {
                //出力ファイルのパス
                //バイナリモードのときはテキストで返す
                outFilePth = Path.Combine(Path.GetDirectoryName(inFilePath), Path.GetFileName(inFilePath) + ".txt");

                //出力ファイルをクリア
                WriteText(outFilePth, "", false, false);

                //実行
                ExecBinaryMode(inFilePath, outFilePth);
            }

            Console.WriteLine("処理が終了しました。");
            Console.ReadKey();

        }

        /// <summary>
        /// 起動引数チェック
        /// </summary>
        /// <param name="cmdArgs">起動引数の配列</param>
        /// <param name="errorMsg">エラーのときエラーメッセージが返される</param>
        /// <returns>チェックOKか否か</returns>
        private static bool CheckArg(string[] cmdArgs, out string errorMsg)
        {
            errorMsg = "";

            if (cmdArgs.Length < 2)
            {
                errorMsg = "起動引数が足りません";
                return false;
            }

            if (!File.Exists(cmdArgs[1]))
            {
                errorMsg = "Arg1のファイルが存在しません";
                return false;
            }

            return true;
        }

        /// <summary>
        /// 第二起動引数を読んでモードを返す
        /// デフォルトはバイナリ
        /// </summary>
        /// <param name="cmdArgs">起動引数の配列</param>
        /// <returns>モード</returns>
        private static int GetProcessMode(string[] cmdArgs)
        {
            if (cmdArgs.Length < 3)
            {
                return MODE_BINARY;
            }

            if (cmdArgs[2].ToUpper() == ARG_ASCII)
            {
                return MODE_ASCII;
            }

            if (cmdArgs[2].ToUpper() == ARG_BINARY)
            {
                return MODE_BINARY;
            }
            return MODE_BINARY;
        }

        private static void ExecBinaryMode(string inFilePath, string outFilePth)
        {

            string binText;
            string strText = "";

            foreach (byte item in ReadFileToBinary(inFilePath))
            {
                binText = ConvertBinaryToString(item);
                strText = ConvertHxToString(binText);

                if (strText == ERROR_STRING)
                {
                    Console.WriteLine("エラーが発生したため中断しました");
                    return;
                }

                WriteText(outFilePth, strText, true, false);
            }

        }

        private static void ExecASCIIMode(string inFilePath, string outFilePth)
        {
            string binText;
            string strText = "";

            foreach (string item in ReadFileByChar(inFilePath))
            {
                binText = ConvertHxToString(item);

                if (binText == ERROR_STRING)
                {
                    Console.WriteLine("エラーが発生したため中断しました");
                    return;
                }

                WriteBinary(outFilePth, Convert.ToByte(binText, 16));
            }
        }
    }
}
