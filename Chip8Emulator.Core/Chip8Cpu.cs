namespace Chip8Emulator.Core
{
    internal class Chip8Cpu
    {
        private byte[] _memory;
        private byte[] _v;
        private ushort _programCounter;
        private ushort _indexRegister;
        private Stack<ushort> emulatorStack;
        private byte _delayTimer;
        private byte _soundTimer;


        public Chip8Cpu()
        {
            _memory = new byte[4096];
            _v = new byte[16];
            _programCounter = 0x200;
            _indexRegister = 0;
            emulatorStack = new Stack<ushort>();
            _delayTimer = 0;
            _soundTimer = 0;
        }

        public void LoadRom(byte[] data)
        {
            Reset();
            Array.Copy(data, 0, _memory, 0x200, data.Length);
        }

        private void Reset()
        {
            Array.Clear(_memory, 0, _memory.Length);
            Array.Clear(_v, 0, _v.Length);
            _programCounter = 0x200;
            _indexRegister = 0;
            _delayTimer = 0;
            _soundTimer = 0;
            emulatorStack = new Stack<ushort>();
        }
    }

}
