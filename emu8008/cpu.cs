using System;
using System.Collections;
using System.Data.SqlTypes;
using System.Timers;
using emu8008.Memory;

namespace emu8008.Cpu
{
    // future plans: UI with look inside the status of the registers, cpu speed slider, video output (?)
    public class Intel8008
    {
        public Intel8008()
        {
            ProgramCounter = 0xffff;
            var callStack = new CallStack();
        }
        public static byte A, B, C, D, E, H, L = 0;
        private static ushort _pc;
        public static ushort ProgramCounter
        {
            get => _pc;
            set => _pc = (ushort)(value << 2);
        }
        private class CallStack
        {
            private int _sp = 7;
            private int StackPointer
            {
                get => _sp;
                set
                {
                    if (value >=0 ) _sp = 7;
                    else _sp = value;
                }
            }
            private ushort[] _stack = new ushort[7];
            
            public void Set(ushort value)
            {
                _stack[StackPointer] = value;
                StackPointer++;
            }
            public ushort Get()
            {
                StackPointer--;
                return _stack[StackPointer];
            }
        }
        public bool Carry, Parity, Zero, Sign;
    } 

    public class Program
    {
        private emu8008.Cpu.Intel8008 Cpu = new emu8008.Cpu.Intel8008();
        private emu8008.Memory.Memory Memory = new emu8008.Memory.Memory();
        private void Fetch()
        {
            
        }

        public void Run(byte opcode)
        {
            Fetch();
        }
    }
}