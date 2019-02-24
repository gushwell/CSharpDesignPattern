using System;

namespace Gushwell.DesignPatterns {

    [Serializable]
    public class FileTreatmentException : System.SystemException {
        public FileTreatmentException() {
        }
        public FileTreatmentException(string msg)
            : base(msg) {
        }
    }
}