

namespace CleverenseSoftTests.Task3
{
    internal static class Server
    {
        private static Int32 _count;
        private static ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();

        public static Int32 GetCount()
        {
            try
            {
                _lock.EnterReadLock();
                return _count;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        
        }

        public static void AddToCount(Int32 value)
        {

            _lock.EnterWriteLock();
            _count += value;
            _lock.ExitWriteLock();
        }

    }
}
