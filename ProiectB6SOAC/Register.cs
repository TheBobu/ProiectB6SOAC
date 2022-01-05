namespace ProiectB6SOAC
{
    public class Register
    {
        private int size;
        private int[] register;

        public Register(int n)
        {
            size = n;
            register = new int[size];
        }

        public void AddNewEntry(int value)
        {
            for (int i = size - 1; i > 0; i--)
                register[i] = register[i - 1];
            register[0] = value;
        }

        public int GetIndex(int index)
        {
            return register[index];
        }

        public void Reset()
        {
            for (int i = 0; i < size; i++)
                register[i] = 0;
        }
    }
}