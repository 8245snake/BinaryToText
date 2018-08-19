using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryToText
{
    class CharTable
    {
        private string hex;
        private string str;

        public CharTable(string hex, string str)
        {
            this.hex = hex;
            this.str = str;
        }

        /// <summary>
        /// 文字列を変換する
        /// hexとstrのどちらでもない文字列が来たときはなにもせず入力値を返す
        /// </summary>
        /// <param name="item">変換する文字</param>
        /// <returns>変換後の文字</returns>
        public string Convert(string item)
        {
            if (item == hex)
            {
                return str;
            }
            else if (item == str)
            {
                return hex;
            }
            return item;
        }

        public static CharTable[] CreateCharTable()
        {
            CharTable[] table = new CharTable[256];

            table[0] = new CharTable("00", "ん");
            table[1] = new CharTable("10", "」");
            table[2] = new CharTable("20", "『");
            table[3] = new CharTable("30", "』");
            table[4] = new CharTable("40", "ア");
            table[5] = new CharTable("50", "あ");
            table[6] = new CharTable("60", "ィ");
            table[7] = new CharTable("70", "い");
            table[8] = new CharTable("80", "イ");
            table[9] = new CharTable("90", "犬");
            table[10] = new CharTable("A0", "う");
            table[11] = new CharTable("B0", "ウ");
            table[12] = new CharTable("C0", "ェ");
            table[13] = new CharTable("D0", "エ");
            table[14] = new CharTable("E0", "オ");
            table[15] = new CharTable("F0", "お");
            table[16] = new CharTable("01", "か");
            table[17] = new CharTable("11", "カ");
            table[18] = new CharTable("21", "が");
            table[19] = new CharTable("31", "ガ");
            table[20] = new CharTable("41", "キ");
            table[21] = new CharTable("51", "き");
            table[22] = new CharTable("61", "ギ");
            table[23] = new CharTable("71", "ク");
            table[24] = new CharTable("81", "く");
            table[25] = new CharTable("91", "グ");
            table[26] = new CharTable("A1", "け");
            table[27] = new CharTable("B1", "ケ");
            table[28] = new CharTable("C1", "コ");
            table[29] = new CharTable("D1", "ゴ");
            table[30] = new CharTable("E1", "サ");
            table[31] = new CharTable("F1", "さ");
            table[32] = new CharTable("02", "し");
            table[33] = new CharTable("12", "ジ");
            table[34] = new CharTable("22", "す");
            table[35] = new CharTable("32", "ス");
            table[36] = new CharTable("42", "そ");
            table[37] = new CharTable("52", "タ");
            table[38] = new CharTable("62", "た");
            table[39] = new CharTable("72", "ダ");
            table[40] = new CharTable("82", "ち");
            table[41] = new CharTable("92", "っ");
            table[42] = new CharTable("A2", "ッ");
            table[43] = new CharTable("B2", "ツ");
            table[44] = new CharTable("C2", "つ");
            table[45] = new CharTable("D2", "て");
            table[46] = new CharTable("E2", "テ");
            table[47] = new CharTable("F2", "デ");
            table[48] = new CharTable("03", "で");
            table[49] = new CharTable("13", "ト");
            table[50] = new CharTable("23", "と");
            table[51] = new CharTable("33", "ド");
            table[52] = new CharTable("43", "ど");
            table[53] = new CharTable("53", "な");
            table[54] = new CharTable("63", "ナ");
            table[55] = new CharTable("73", "ニ");
            table[56] = new CharTable("83", "に");
            table[57] = new CharTable("93", "猫");
            table[58] = new CharTable("A3", "の");
            table[59] = new CharTable("B3", "は");
            table[60] = new CharTable("C3", "バ");
            table[61] = new CharTable("D3", "ビ");
            table[62] = new CharTable("E3", "ピ");
            table[63] = new CharTable("F3", "フ");
            table[64] = new CharTable("04", "ブ");
            table[65] = new CharTable("14", "プ");
            table[66] = new CharTable("24", "へ");
            table[67] = new CharTable("34", "ベ");
            table[68] = new CharTable("44", "ほ");
            table[69] = new CharTable("54", "ポ");
            table[70] = new CharTable("64", "ま");
            table[71] = new CharTable("74", "み");
            table[72] = new CharTable("84", "ム");
            table[73] = new CharTable("94", "メ");
            table[74] = new CharTable("A4", "め");
            table[75] = new CharTable("B4", "も");
            table[76] = new CharTable("C4", "ャ");
            table[77] = new CharTable("D4", "や");
            table[78] = new CharTable("E4", "よ");
            table[79] = new CharTable("F4", "ラ");
            table[80] = new CharTable("05", "ら");
            table[81] = new CharTable("15", "り");
            table[82] = new CharTable("25", "リ");
            table[83] = new CharTable("35", "鳥");
            table[84] = new CharTable("45", "ル");
            table[85] = new CharTable("55", "る");
            table[86] = new CharTable("65", "れ");
            table[87] = new CharTable("75", "ロ");
            table[88] = new CharTable("85", "ワ");
            table[89] = new CharTable("95", "わ");
            table[90] = new CharTable("A5", "を");
            table[91] = new CharTable("B5", "ン");
            table[92] = new CharTable("C5", "圧");
            table[93] = new CharTable("D5", "以");
            table[94] = new CharTable("E5", "位");
            table[95] = new CharTable("F5", "一");
            table[96] = new CharTable("06", "員");
            table[97] = new CharTable("16", "栄");
            table[98] = new CharTable("26", "泳");
            table[99] = new CharTable("36", "欧");
            table[100] = new CharTable("46", "加");
            table[101] = new CharTable("56", "華");
            table[102] = new CharTable("66", "過");
            table[103] = new CharTable("76", "会");
            table[104] = new CharTable("86", "回");
            table[105] = new CharTable("96", "改");
            table[106] = new CharTable("A6", "界");
            table[107] = new CharTable("B6", "開");
            table[108] = new CharTable("C6", "外");
            table[109] = new CharTable("D6", "獲");
            table[110] = new CharTable("E6", "角");
            table[111] = new CharTable("F6", "活");
            table[112] = new CharTable("07", "勧");
            table[113] = new CharTable("17", "官");
            table[114] = new CharTable("27", "関");
            table[115] = new CharTable("37", "機");
            table[116] = new CharTable("47", "記");
            table[117] = new CharTable("57", "儀");
            table[118] = new CharTable("67", "宜");
            table[119] = new CharTable("77", "技");
            table[120] = new CharTable("87", "疑");
            table[121] = new CharTable("97", "義");
            table[122] = new CharTable("A7", "議");
            table[123] = new CharTable("B7", "去");
            table[124] = new CharTable("C7", "供");
            table[125] = new CharTable("D7", "青");
            table[126] = new CharTable("E7", "競");
            table[127] = new CharTable("F7", "共");
            table[128] = new CharTable("08", "協");
            table[129] = new CharTable("18", "強");
            table[130] = new CharTable("28", "極");
            table[131] = new CharTable("38", "兄");
            table[132] = new CharTable("48", "経");
            table[133] = new CharTable("58", "権");
            table[134] = new CharTable("68", "見");
            table[135] = new CharTable("78", "験");
            table[136] = new CharTable("88", "後");
            table[137] = new CharTable("98", "光");
            table[138] = new CharTable("A8", "公");
            table[139] = new CharTable("B8", "抗");
            table[140] = new CharTable("C8", "構");
            table[141] = new CharTable("D8", "降");
            table[142] = new CharTable("E8", "告");
            table[143] = new CharTable("F8", "国");
            table[144] = new CharTable("09", "混");
            table[145] = new CharTable("19", "差");
            table[146] = new CharTable("29", "催");
            table[147] = new CharTable("39", "最");
            table[148] = new CharTable("49", "済");
            table[149] = new CharTable("59", "裁");
            table[150] = new CharTable("69", "際");
            table[151] = new CharTable("79", "材");
            table[152] = new CharTable("89", "参");
            table[153] = new CharTable("99", "残");
            table[154] = new CharTable("A9", "使");
            table[155] = new CharTable("B9", "姿");
            table[156] = new CharTable("C9", "子");
            table[157] = new CharTable("D9", "持");
            table[158] = new CharTable("E9", "治");
            table[159] = new CharTable("F9", "室");
            table[160] = new CharTable("0A", "実");
            table[161] = new CharTable("1A", "社");
            table[162] = new CharTable("2A", "者");
            table[163] = new CharTable("3A", "取");
            table[164] = new CharTable("4A", "手");
            table[165] = new CharTable("5A", "受");
            table[166] = new CharTable("6A", "州");
            table[167] = new CharTable("7A", "出");
            table[168] = new CharTable("8A", "所");
            table[169] = new CharTable("9A", "消");
            table[170] = new CharTable("AA", "上");
            table[171] = new CharTable("BA", "場");
            table[172] = new CharTable("CA", "織");
            table[173] = new CharTable("DA", "新");
            table[174] = new CharTable("EA", "人");
            table[175] = new CharTable("FA", "水");
            table[176] = new CharTable("0B", "世");
            table[177] = new CharTable("1B", "勢");
            table[178] = new CharTable("2B", "成");
            table[179] = new CharTable("3B", "政");
            table[180] = new CharTable("4B", "績");
            table[181] = new CharTable("5B", "接");
            table[182] = new CharTable("6B", "占");
            table[183] = new CharTable("7B", "戦");
            table[184] = new CharTable("8B", "選");
            table[185] = new CharTable("9B", "前");
            table[186] = new CharTable("AB", "善");
            table[187] = new CharTable("BB", "全");
            table[188] = new CharTable("CB", "組");
            table[189] = new CharTable("DB", "層");
            table[190] = new CharTable("EB", "速");
            table[191] = new CharTable("FB", "属");
            table[192] = new CharTable("0C", "他");
            table[193] = new CharTable("1C", "多");
            table[194] = new CharTable("2C", "打");
            table[195] = new CharTable("3C", "体");
            table[196] = new CharTable("4C", "対");
            table[197] = new CharTable("5C", "代");
            table[198] = new CharTable("6C", "大");
            table[199] = new CharTable("7C", "担");
            table[200] = new CharTable("8C", "団");
            table[201] = new CharTable("9C", "弾");
            table[202] = new CharTable("AC", "男");
            table[203] = new CharTable("BC", "知");
            table[204] = new CharTable("CC", "長");
            table[205] = new CharTable("DC", "定");
            table[206] = new CharTable("EC", "提");
            table[207] = new CharTable("FC", "的");
            table[208] = new CharTable("0D", "度");
            table[209] = new CharTable("1D", "当");
            table[210] = new CharTable("2D", "等");
            table[211] = new CharTable("3D", "動");
            table[212] = new CharTable("4D", "同");
            table[213] = new CharTable("5D", "得");
            table[214] = new CharTable("6D", "独");
            table[215] = new CharTable("7D", "内");
            table[216] = new CharTable("8D", "南");
            table[217] = new CharTable("9D", "日");
            table[218] = new CharTable("AD", "認");
            table[219] = new CharTable("BD", "熱");
            table[220] = new CharTable("CD", "年");
            table[221] = new CharTable("DD", "白");
            table[222] = new CharTable("ED", "薄");
            table[223] = new CharTable("FD", "発");
            table[224] = new CharTable("0E", "伴");
            table[225] = new CharTable("1E", "判");
            table[226] = new CharTable("2E", "半");
            table[227] = new CharTable("3E", "批");
            table[228] = new CharTable("4E", "費");
            table[229] = new CharTable("5E", "表");
            table[230] = new CharTable("6E", "負");
            table[231] = new CharTable("7E", "分");
            table[232] = new CharTable("8E", "聞");
            table[233] = new CharTable("9E", "別");
            table[234] = new CharTable("AE", "便");
            table[235] = new CharTable("BE", "保");
            table[236] = new CharTable("CE", "亡");
            table[237] = new CharTable("DE", "房");
            table[238] = new CharTable("EE", "本");
            table[239] = new CharTable("FE", "妹");
            table[240] = new CharTable("0F", "密");
            table[241] = new CharTable("1F", "民");
            table[242] = new CharTable("2F", "命");
            table[243] = new CharTable("3F", "盟");
            table[244] = new CharTable("4F", "目");
            table[245] = new CharTable("5F", "野");
            table[246] = new CharTable("6F", "躍");
            table[247] = new CharTable("7F", "余");
            table[248] = new CharTable("8F", "与");
            table[249] = new CharTable("9F", "様");
            table[250] = new CharTable("AF", "乱");
            table[251] = new CharTable("BF", "利");
            table[252] = new CharTable("CF", "立");
            table[253] = new CharTable("DF", "力");
            table[254] = new CharTable("EF", "録");
            table[255] = new CharTable("FF", "空");

            return table;
        }

    }
}
