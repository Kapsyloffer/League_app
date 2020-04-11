using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_2
{
    [Serializable]
    class Settings
    {
        private int winPoints;
        private int lossPoints;
        private int weeks;
        public Settings()
        {
            //set default values
            this.winPoints = 3;
            this.lossPoints = 2;
            this.weeks = 3;
        }
        public void setWeeks(int w)
        {
            this.weeks = w;
        }
        public void setLossPoint(int l)
        {
            this.lossPoints = l;
        }
        public void setWinPoint(int w)
        {
            this.winPoints = w;
        }
        public int getWeeks()
        {
            return weeks;
        }
        public int getLossPoint()
        {
            return lossPoints;
        }
        public int getWinPoint()
        {
            return winPoints;
        }
    }
}

