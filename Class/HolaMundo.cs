using System;

namespace CSharp_Advanced_Topics.Clases
{
    public class HolaMundo
    {
        private String _msg = String.Empty;
        public HolaMundo(String msg)
        {
            this._msg = msg;
        }

        public String GetMessage()
        {
            return this._msg;
        }
    }
}
