using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace chapter2lesson2
{
    public class CustomCommands
    {
        private static RoutedUICommand launch_command;

        public static RoutedUICommand Launch
        {
            get
            {
                return launch_command;
            }
        }

        static CustomCommands()
        {
            InputGestureCollection myInputGestures = new InputGestureCollection();
            myInputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            myInputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Control));
            launch_command = new RoutedUICommand("Launch", "Launch", typeof(CustomCommands), myInputGestures);
        }
    }
}
