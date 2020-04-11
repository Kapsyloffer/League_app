using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_2
{
    [Serializable]
    class Note
    {
        private String content = "";
        private int w;
        public Note(String c, int w)
        {
            this.content = c;
            this.w = w;
        }
        public void setContent(String s)
        {
            this.content = s;
        }
        public String getContent()
        {
            return content;
        }
        public int week()
        {
            return w;
        }
    }
}
