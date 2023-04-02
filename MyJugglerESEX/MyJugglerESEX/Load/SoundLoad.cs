
using DxLibDLL;
using System.Collections.Generic;
using System.IO;

namespace MyJugglerESEX
{
   public class SoundLoad
    {
        const string BASE = @"Sound\";


        public Sound StertBGM,
            Pi,
            Chance,
            Seven;

        public void tLoadSound()
        {
            DX.SetCreateSoundDataType(1);
            StertBGM = new Sound(BASE + "start.wav");
            Pi = new Sound(BASE + "pi.wav");
            Seven = new Sound(BASE + "Seven.wav");
            Chance = new Sound(BASE + "Chance.wav");
            DX.SetCreateSoundDataType(3);
        }

    }
}
