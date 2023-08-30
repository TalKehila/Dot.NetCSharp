using System;

namespace Logic
{
    public class MyLogic : IDisposable
    {
        public event Action<string> ConnectEv;
        public event Action<string> WorkEv;
        public event Action<string> DisconnectEv;

        public void Connection() => ConnectEv?.Invoke("Connection");
        public void Work() => WorkEv?.Invoke("Working...");

        //LEGACY CODE: Don't remove d-tor !!!
        ~MyLogic() => Disconnect();
        private void Disconnect() => DisconnectEv?.Invoke("Disconnect");
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Disconnect();
        }
    }
}