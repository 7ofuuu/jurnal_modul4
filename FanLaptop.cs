using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300043

{
    enum state { Quite, Balanced, Performanced, Turbo };

    internal class FanLaptop
    {
        state state = state.Quite;

        public void kecepatanFan()
        {
            if (state == state.Quite)
            {
                Console.WriteLine("Kecepatan fan saat ini: " + state);
            }
            else if (state == state.Balanced)
            {
                Console.WriteLine("Kecepatan fan saat ini: " + state);
            }
            else if (state == state.Performanced)
            {
                Console.WriteLine("Kecepatan fan saat ini: " + state);
            }
            else if (state == state.Turbo)
            {
                Console.WriteLine("Kecepatan fan saat ini: " + state);
            }
        }

        public void kecepatanUp()
        {
            if (state == state.Quite)
            {
                Console.WriteLine(state = state.Balanced);
            }
            else if (state == state.Balanced)
            {
                Console.WriteLine(state = state.Performanced);
            }
            else if (state == state.Performanced)
            {
                Console.WriteLine(state = state.Turbo);
            }
        }

        public void kecepatanDown()
        {
            if(state == state.Turbo)
            {
                Console.WriteLine(state = state.Performanced);
            }
            else if (state == state.Performanced)
            {
                Console.WriteLine(state = state.Balanced);
            }
            else if (state == state.Balanced)
            {
                Console.WriteLine(state = state.Quite);
            }
        }

        public void turboShortcut()
        {
            if (state == state.Quite)
            {
                Console.WriteLine(state = state.Turbo);
            }
            else if(state == state.Turbo)
            {
                Console.WriteLine(state = state.Quite);
            }
        }
    }
}
