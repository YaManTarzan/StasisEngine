using Microsoft.Xna.Framework.Input;

namespace StasisEngine
{
    // Input wrapper for StasisEngine
    public static class Input
    {
        private static KeyboardState keys;

        // Updates the state of keys to prevent a 
        // while loop to update it constantly
        private static void UpdateKeystate()
        {
            keys = Keyboard.GetState();
        }

        // Returns true if the key is being pressed
        // else returns false
        public static bool GetKeyDown(Keys key)
        {
            UpdateKeystate();
            return (keys.IsKeyDown(key) == true) ? true : false;
        }

        // Returns true if in the last frame the key was pressed
        // But in the new frame the key is up
        public static bool GetKeyUp(Keys key)
        {
            UpdateKeystate();
            return (keys.IsKeyUp(key) == true) ? true : false;
        }

    }
}