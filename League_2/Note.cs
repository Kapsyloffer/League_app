using System;

namespace League_2
{
    [Serializable]
    class Note
    {
        //Tom sträng för att förhindra null-problemet.
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
