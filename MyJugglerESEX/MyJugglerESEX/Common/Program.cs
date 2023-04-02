using DxLibDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyJugglerESEX
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                Program.App();
            }
            catch (Exception ex)
            {


            }
        }

        internal static void App()
        {
            DX.ChangeWindowMode(1);
            DX.SetGraphMode(754, 1263, 32); // 初期ウィンドウのサイズ
            DX.SetUseTransColor(0);
            DX.SetAlwaysRunFlag(1);//常にウィンドウを実行するか
            DX.SetDoubleStartValidFlag(0);
            DX.SetWaitVSyncFlag(1);//垂直同期
            DX.SetWindowSizeChangeEnableFlag(1);//ウィンドウサイズの変更をするか
            DX.SetMainWindowText("じゃぐらー");
            DX.DxLib_Init();

            Program.Tx.tLoadTexture();
            Program.Sx.tLoadSound();

            Program.game.tRe();

            while (DX.ProcessMessage() == 0 && DX.ScreenFlip() == 0 && DX.ClearDrawScreen() == 0)
            {
                DX.SetDrawScreen(-2);
                DX.ClearDrawScreen();

                Program.keyInput.Update();

                game.tMainDraw();

                if(Program.keyInput.IsPush(DX.KEY_INPUT_ESCAPE))
                    DX.DxLib_End();
            }
         




            DX.DxLib_End();

        }

     //   public static Counter Counter = new Counter();
        public static Game game = new Game();
        public static TextureLoad Tx = new TextureLoad();
        public static SoundLoad Sx = new SoundLoad();
        public static KeyInput keyInput = new KeyInput();
        public static bool bIsFullHD = true;

    }
}
