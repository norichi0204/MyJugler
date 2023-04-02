using DxLibDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MyJugglerESEX
{
    public class Game
    {
        public void tRe()
        {
            LeftMove = new Counter(0,21,50000,true);
          
            CenterMove = new Counter(0, 21, 50000, true);
         
            RightMove = new Counter(0, 21, 50000, true);
            bStart = true;
        }

        public void tMainDraw()
        {
            LeftMove.tTick();
            CenterMove.tTick();
            RightMove.tTick();



            if (bStart)
            {
                if (Program.keyInput.IsPush(DX.KEY_INPUT_UP) && !Program.Sx.StertBGM.CheackSoundPlay() && CreditCount >=3)
                {
                    CreditCount -= 3;
                    Program.Sx.StertBGM.Play();
                    LeftMove.Start();
                    CenterMove.Start();
                    RightMove.Start();
                    bStart = false;
                    count = 0;
                    if (ChanceCount == 32)
                    {
                        Program.Sx.Chance.Play();

                    }
                }
            }
            if (count < 4)
            {
                if (Program.keyInput.IsPush(DX.KEY_INPUT_LEFT))
                {
                    LeftMove.Stop();
                    Program.Sx.Pi.Play();
                    count++;
                }
                else if (Program.keyInput.IsPush(DX.KEY_INPUT_DOWN))
                {
                    CenterMove.Stop();
                    Program.Sx.Pi.Play();
                    count++;
                }
                else if (Program.keyInput.IsPush(DX.KEY_INPUT_RIGHT))
                {
                    RightMove.Stop();
                    Program.Sx.Pi.Play();
                    count++;



                }
            }
            if (Program.keyInput.IsPush(DX.KEY_INPUT_C))
            {
                CreditCount++;
            }



            if (count >= 3)
            {
                bStart = true;

                this.ChanceCount = DX.GetRand(319);
              

            }
            for (int index = 0; index < 1212 / Program.Tx.txLeftBord.Size.Y + 1; ++index)
                Program.Tx.txLeftBord.Draw(135,(LeftMove.nValue * 57.7f) - index * 1212);

            for (int index = 0; index < 1212 / Program.Tx.txCenterBord.Size.Y + 1; ++index)
                Program.Tx.txCenterBord.Draw(295, (CenterMove.nValue *57.7f) - index *1212);

            for (int index = 0; index < 1212 / Program.Tx.txRightBord.Size.Y + 1; ++index)
                Program.Tx.txRightBord.Draw(460, (RightMove.nValue*57.7f) - index *1212);



            Program.Tx.txMainBack.Draw(0, 0);
            Program.Tx.txMoji.Draw(277, 555, new Rectangle(CreditCount * 17,0,17,32));


            DX.DrawString(0,0 ,LeftMove.nValue.ToString(), DX.GetColor(0,0,0));
            DX.DrawString(0, 10, CenterMove.nValue.ToString(), DX.GetColor(0, 0, 0));
            DX.DrawString(0, 20, RightMove.nValue.ToString(), DX.GetColor(0, 0, 0));

        }

        private Counter LeftMove;
        private Counter CenterMove;
        private Counter RightMove;

        private int ChanceCount;
        private int CreditCount;

        private int count;
        private bool bStart;

    }
}
