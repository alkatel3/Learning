using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace Tamagotchi
{
    public static class MessageToUser
    {
        static byte count=0;
        public static void Feed(object sender, ElapsedEventArgs e)
        {
            bool result = MessageBox.Show("Feed me", "Feed", MessageBoxButtons.YesNo) == DialogResult.Yes;
            if (result == false)
            {
                count++;
                return;
            }
            count = 0;
        }
        public static void Walk(object sender, ElapsedEventArgs e)
        {
            bool result = MessageBox.Show("Walk with me", "Walk", MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (result == false)
            {
                count++;
                return;
            }
            count = 0;
        }

        public static void Sleep(object sender, ElapsedEventArgs e)
        {
            bool result = MessageBox.Show("Put me to sleep", "Sleep", MessageBoxButtons.YesNo) == DialogResult.Yes;
            if (result == false)
            {
                count++;
                return;
            }
            count = 0;
        }

        private static void Treatment()
        {
            if( MessageBox.Show("Heal me", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                count = 0;
            }
        }

        public static void Play(object sender, ElapsedEventArgs e)
        {
            bool result = MessageBox.Show("Play with me", "Treatment", MessageBoxButtons.YesNo) == DialogResult.Yes;
            if (result == false)
            {
                count++;
                return;
            }
            count = 0;
        }

        private static void Die()
        {
            MessageBox.Show("Game is over", "Die");
        }
    }
}
