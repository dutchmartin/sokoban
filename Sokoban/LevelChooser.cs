using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class LevelChooser
    {
        private int AskWhatLevelToPlay()
        {
            var view = new ChooseLevelView();
            view.Render();
            var handler = new InputHandler();
            return handler.GetNummericInput(1, 6);
        }
        public String GetTheLevelTheUserWants()
        {
            int level = AskWhatLevelToPlay();
            switch (level) {
                case 1:
                    return Levels.Level_1;
                case 2:
                    return Levels.Level_2;
                case 3:
                    return Levels.Level_3;
                case 4:
                    return Levels.Level_4;
                case 5:
                    return Levels.Level_5;
                case 6:
                    return Levels.Level_6;
                default:
                    return Levels.Level_1;
            }
        }
    }
}
