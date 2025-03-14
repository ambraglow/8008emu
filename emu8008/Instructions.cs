using System.Net;
using emu8008.Cpu;

namespace emu8008.Instructions
{
    public class Instructions
    {
        private enum Register
        {
            A,
            B = (1 << 3),
            C = (2 << 3),
            D = (3 << 3),
            E = (4 << 3),
            H = (5 << 3),
            L = (6 << 3),
            M = (7 << 3)
        }
        private enum Opcode
        {
            HLT = 0x0,
            INC = 0x0,
            DEC = 0x1,
            RLC = 0x2
        }
        public bool Decode(byte data)
        {
            switch (data)
            {
                case (byte)Opcode.HLT:
                    break;
                case (byte)Opcode.HLT | 0xff:
                    break;
                case (byte)Opcode.HLT | 0x1:
                    break;
                case (byte)Opcode.INC | (byte)Register.B:
                    break;
                case (byte)Opcode.INC | (byte)Register.C:
                    break;
                case (byte)Opcode.INC| (byte)Register.D:
                    break;
                case (byte)Opcode.INC | (byte)Register.E:
                    break;
                case (byte)Opcode.INC | (byte)Register.H:
                    break;
                case (byte)Opcode.INC | (byte)Register.L:
                    break;
                case (byte)Opcode.DEC | (byte)Register.B:
                    break;

                default:
                    Console.WriteLine("Unknown instruction");
                    return false;
            }
            return true;
        }
    }
}