using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DxLibDLL;

namespace MyJugglerESEX
{
    public class TextureLoad
    {
        const string BASE = @"Images\";

        public void tLoadTexture()
        {

            txMainBack = new Texture(BASE + "Main.png");
            txMoji = new Texture(BASE + "Moji.png");
            txLeftBord = new Texture(BASE + "Left.png");
            txCenterBord = new Texture(BASE + "Center.png");
            txRightBord = new Texture(BASE + "Right.png");
        }




        public Texture txMainBack;

        public Texture txLeftBord,
            txMoji,
            txCenterBord,
            txRightBord;
    }
}
