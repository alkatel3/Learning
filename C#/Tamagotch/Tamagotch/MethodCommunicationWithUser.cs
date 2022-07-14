using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotch
{
    static class MethodCommunicationWithUser
    {
        public static void Feed()
        {
            MessageBox.Show("Feed me");
        }
        public static void Walk()
        {
            MessageBox.Show("Walk with me");
        }

        public static void Sleep()
        {
            MessageBox.Show("Put me to sleep");
        }

        public static void Treat()
        {
            MessageBox.Show("Treat me");
        }

        public static void Play()
        {
            MessageBox.Show("Play with me");
        }

        public static void Die()
        {
            if (MessageBox.Show("I died","Game is over", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                MethodCommunicationWithUser.Play();
            }
            
        }
    }
}
