using System.Collections.Generic;

namespace Producta.Secret
{

    public class Notification
    {
        private IList<string> _errors = new List<string>();

        public IList<string> Errors
        {
            get { return _errors; }
            set { _errors = value; }
        }

        public bool HasErrors
        {
            get { return 0 != Errors.Count; }
        }
    }
}