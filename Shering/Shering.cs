using Analiza.File;
using Analiza.SupportFunction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analiza.Shering
{
    class Shering
    {
        public List<List<Code>> CreatWordWithSymbols(List<Code> PriperSymbols, int HowMenyCharInt)
        {
            FunkcjonSupport funkcjonSupport = new FunkcjonSupport();
            List<List<Code>> AllCombination = new List<List<Code>>();
            for (int aktualStartPozytion = 0; aktualStartPozytion <= PriperSymbols.Count - HowMenyCharInt; aktualStartPozytion++)
            {
                List<Code> OneString = new List<Code>();
                OneString = funkcjonSupport.OneWords(PriperSymbols, aktualStartPozytion, HowMenyCharInt);
                AllCombination.Add(OneString);

            }
            return AllCombination;
        }
        public List<Code> selecktInformacionInLine(List<OneLine>lines)
        {
            FunkcjonSupport funkcjonSupport = new FunkcjonSupport();
            List<Code> PriperCodes = new List<Code>();
            for (int i=0;i< lines.Count;i++)
            {
                Code tmp = new Code();
                tmp.code = lines[i].code;
                tmp.bigLiter = funkcjonSupport.IsBig(lines[i]);
                tmp.numLock = lines[i].numLockk;
                tmp.PAlt = lines[i].PAlt;
                tmp.milisekend = lines[i].milisekend;
                tmp.focus = lines[i].focus;

                PriperCodes.Add(tmp);
            }
            return PriperCodes;
        }
        public void SheringLine(OneLine priper, string line)
        {
            string code = null;
            int tmp = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] != ';')
                {
                    code += line[i];
                    if (tmp == 10 && i + 1 == line.Length)
                    {
                        priper.focus = code;
                        break;
                    }
                }
                else if (tmp == 0 && line[i] == ';')
                {
                    priper.code = Int32.Parse(code);
                    tmp = 1;
                    code = null;
                }
                else if (tmp == 1 && line[i] == ';')
                {
                    priper.hour = code;
                    tmp = 2;
                    code = null;
                }
                else if (tmp == 2 && line[i] == ';')
                {
                    string tmp1 = null;
                    for (int j = 0; j < code.Length; j++)
                    {
                        if (code == "-1")
                        {
                            priper.milisekend = Int32.Parse(code);
                            tmp = 3;
                            code = null;
                            break;
                        }
                        else if (code[j] >= 48 && code[j] <= 57 || code[j] == '-')
                        {
                            tmp1 += code[j];
                        }
                        else
                        {
                            priper.milisekend = Int32.Parse(tmp1);
                            tmp = 3;
                            code = null;
                            break;
                        }

                    }
                }
                else if (tmp == 3 && line[i] == ';')
                {
                    priper.pozytionX = Int32.Parse(code);
                    tmp = 4;
                    code = null;
                }
                else if (tmp == 4 && line[i] == ';')
                {
                    priper.pozytionY = Int32.Parse(code);
                    tmp = 5;
                    code = null;
                }
                else if (tmp == 5 && line[i] == ';')
                {
                    priper.capslock = bool.Parse(code);
                    tmp = 6;
                    code = null;
                }
                else if (tmp == 6 && line[i] == ';')
                {
                    priper.numLockk = bool.Parse(code);
                    tmp = 7;
                    code = null;
                }
                else if (tmp == 7 && line[i] == ';')
                {
                    priper.shift = bool.Parse(code);
                    tmp = 8;
                    code = null;
                }
                else if (tmp == 8 && line[i] == ';')
                {
                    priper.Ctrl = bool.Parse(code);
                    tmp = 9;
                    code = null;
                }
                else if (tmp == 9 && (line[i] == ';' || i + 1 > line.Length))
                {
                    priper.PAlt = bool.Parse(code);
                    tmp = 10;
                    code = null;
                    if (i + 1 > line.Length)
                    {
                        priper.focus = null;
                        break;
                    }
                }
            }
        }
    }
}
