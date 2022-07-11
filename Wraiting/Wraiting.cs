using Analiza.File;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Analiza.Translation;

namespace Analiza.Wraiting
{
    class Wraiting
    {
        public void WraitingSumary(ListBox Sumary,List<List<Code>> selectWords,int HowMenyResultInt)
        {
            string word = "";
            TranslateCode translateCode = new TranslateCode();
            for (int i=0;i<selectWords.Count;i++)
            {
                if (Sumary.Items.Count < HowMenyResultInt)
                {
                    for (int j = 0; j < selectWords[i].Count; j++)
                    {
                        word += translateCode.Char(selectWords[i][j]) + " ";
                    }
                    word += "   " + selectWords[i][0].HowMeny.ToString();
                    Sumary.Items.Add(word);
                    word = "";
                }
            }
        }
    }
}
