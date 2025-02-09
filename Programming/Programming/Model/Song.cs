using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private int duration;
        private String name;
        private String singer;
        public Song()
        {
        }

        public Song(int duration, string name, string singer)
        {
            setDuration(duration);
            this.name = name;
            this.singer = singer;
        }

        public int getDuration()
        {
            return duration;
        }
        public String getName()
        {
            return name;
        }
        public String getSinger()
        {
            return singer;
        }
        public void setDuration(int duration)
        {
            if (duration < 0)
            {
                MessageBox.Show("Некорректное значение");
            }
            else
            {
                this.duration = duration;
            }
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setSinger(String singer)
        {
            this.singer = singer;
        }
    }
}
