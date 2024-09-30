using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snap7App
{
    public static class BitManipulationHelper
    {


        /// <summary>
        /// Sets the specified bit in a byte.
        /// </summary>
        /// <param name="InByte">The byte to modify.</param>
        /// <param name="Bit">The bit position to set (0-7).</param>
        /// <returns>The modified byte with the specified bit set.</returns>
        public static byte SetBit(ref byte InByte, byte Bit)
        {
            //InByte |= (byte)(2 ^ Bit); // Set the bit at position Bit in InByte (incorrect)
            InByte |= (byte)(1 << Bit); // Set the bit at position Bit in InByte
            return InByte;

            //byte myByte = 0b00000000; // Initial byte
            //SetBit(ref myByte, 2);    // Set the 3rd bit (index 2)
            //Console.WriteLine(Convert.ToString(myByte, 2).PadLeft(8, '0')); // Output: 00000100
        }

        /// <summary>
        /// Clears the specified bit in a byte.
        /// </summary>
        /// <param name="InByte">The byte to modify.</param>
        /// <param name="Bit">The bit position to set (0-7).</param>
        /// <returns>The modified byte with the specified bit set.</returns>
        public static byte ClearBit(ref byte InByte, byte Bit)
        {
            //InByte &= (byte)~(2 ^ Bit); // Clear the bit at position Bit in InByte (incorrect)
            InByte &= (byte)~(1 << Bit); // Clear the bit at position Bit in InByte
            return InByte;

            //byte myByte = 0b00001111; // Initial byte
            //ClearBit(ref myByte, 2);  // Clear the 3rd bit (index 2)
            //Console.WriteLine(Convert.ToString(myByte, 2).PadLeft(8, '0')); // Output: 00001011
        }

        /// <summary>
        /// Checks if the specified bit in a byte is set.
        /// </summary>
        /// <param name="InByte">The byte to check.</param>
        /// <param name="Bit">The bit position to check (0-7).</param>
        /// <returns>True if the specified bit is set; otherwise, false.</returns>
        public static bool IsBitSet(byte InByte, byte Bit)
        {
            return (InByte & (1 << Bit)) != 0;
        }

        /// <summary>
        /// Toggles the specified bit in a byte.
        /// </summary>
        /// <param name="InByte">The byte to modify.</param>
        /// <param name="Bit">The bit position to toggle (0-7).</param>
        /// <returns>The modified byte with the specified bit toggled.</returns>
        public static byte ToggleBit(ref byte InByte, byte Bit)
        {
            InByte ^= (byte)(1 << Bit);
            return InByte;
        }
    }
}
