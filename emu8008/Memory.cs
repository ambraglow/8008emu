using System.Runtime.InteropServices;
using emu8008.Cpu;

namespace emu8008.Memory    
{
    public unsafe class Memory
    {
        private byte* _memory;
        private readonly nuint _memorySize; 
            
        public Memory()
        {
            _memorySize = 16000;    // maximum amount of memory size supported originally 16k x 8-bit
            _memory = (byte*)NativeMemory.AllocZeroed(_memorySize);
        }
        
        public byte Read(ushort address) => *(_memory + address);
        public void Write(ushort address, byte value) => *(_memory + address) = value;
        
        public void Clear() => NativeMemory.Clear(_memory, _memorySize);

        public void Free()
        {
            if (_memory != null)
            {
                NativeMemory.Free(_memory);
                _memory = null;
            }
        }
    }
}