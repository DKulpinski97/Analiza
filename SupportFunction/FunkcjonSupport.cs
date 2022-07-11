using Analiza.File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analiza.SupportFunction
{
    class FunkcjonSupport
    {
        public bool IsBig(OneLine oneLine)
        {
            if(oneLine.capslock==true && oneLine.shift==true)
            {
                return false;
            }
            else if(oneLine.capslock == false && oneLine.shift == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Code> OneWords(List<Code> PriperSymbol, int startPozition,int HowMenyChar)
        {
            List<Code> OneWord = new List<Code>();
            
            int finishPozytion = startPozition + HowMenyChar;
            for(int i=startPozition;i<finishPozytion;i++)
            {
                OneWord.Add(PriperSymbol[i]);
            }

            return OneWord;
        }
        public List<List<Code>>DeliteReplikation(List<List<Code>> AllCombination)
        {

            int tmp = 0;
            for (int i=0;i< AllCombination.Count;i++)
            {
                for(int j=i+1;j< AllCombination.Count;j++)
                {
                    for (int x = 0; x < AllCombination[i].Count; x++)
                    {
                        if (AllCombination[i][x].code == AllCombination[j][x].code &&
                           AllCombination[i][x].bigLiter == AllCombination[j][x].bigLiter &&
                           AllCombination[i][x].numLock == AllCombination[j][x].numLock &&
                           AllCombination[i][x].PAlt == AllCombination[j][x].PAlt
                           )
                        {
                            tmp++;
                        }
                        else
                        {
                            tmp = 0;
                            break;

                        }
                    }
                    if(tmp== AllCombination[i].Count)
                    {
                        tmp = 0;
                        AllCombination.RemoveAt(j);
                        AllCombination[i][0].HowMeny++;
                            j--;
                    }
                }
            }

            return AllCombination;
        }

        public List<int>HowMenyToList(List<List<Code>> CombinationWithoutRepetitions)
        {
            List<int> HowMeny = new List<int>();

            for (int i=0;i< CombinationWithoutRepetitions.Count;i++)
            {
                HowMeny.Add(CombinationWithoutRepetitions[i][0].HowMeny);
            }

            return HowMeny;
        }

         public List<List<Code>> SelectWords (List<List<Code>> CombinationWithoutRepetitions,int HowMenyResultInt, List<int> HowMenySpeeches,int MinRedudationInt)
        {
            List<List<Code>> selectWords = new List<List<Code>>();
            List<List<Code>> CombinationWithoutRepetitionsCopi = CombinationWithoutRepetitions;
            int a = CombinationWithoutRepetitions.Count - 1;
            int b = CombinationWithoutRepetitions.Count - HowMenyResultInt-1;
            for (int i= a;i> b;i--)
             {
                for(int j=0;j< CombinationWithoutRepetitionsCopi.Count;j++)
                {
                    if( i >= 0 && j >= 0 &&(CombinationWithoutRepetitionsCopi[j][0].HowMeny== HowMenySpeeches[i])&&
                        (CombinationWithoutRepetitionsCopi[j][0].HowMeny>= MinRedudationInt))
                    {
                        selectWords.Add(CombinationWithoutRepetitionsCopi[j]);
                        CombinationWithoutRepetitionsCopi.RemoveAt(j);
                        break;

                    }
                }
            }
            return selectWords;
        }
        public void TakeWords(List<List<Code>> AllWord, List<List<Code>> SelectWord, List<List<Code>> AllWordSelekted)
        {
            int tmp = 0;
            for(int i=0;i< SelectWord.Count;i++)
            {
                for(int j=0;j<AllWord.Count;j++)
                {
                    for(int x=0;x<AllWord[0].Count;x++)
                    {
                        if (SelectWord[i][x].code == AllWord[j][x].code &&
                           SelectWord[i][x].bigLiter == AllWord[j][x].bigLiter &&
                           SelectWord[i][x].numLock == AllWord[j][x].numLock &&
                           SelectWord[i][x].PAlt == AllWord[j][x].PAlt
                           )
                        {
                            tmp++;
                        }
                        else
                        {
                            tmp = 0;
                            break;

                        }
                    }
                    if(tmp== SelectWord[0].Count)
                    {
                        List<Code> word = new List<Code>(AllWord[j]);
                        AllWordSelekted.Add(word);
                    }
                }
            }
        }

    }
}
