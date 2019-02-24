using System;

namespace Gushwell.DesignPatterns {

    public class FileTreatmentException : System.SystemException {
        public FileTreatmentException()
            : base() {
        }

        public FileTreatmentException(string msg)
            : base(msg) {
        }
    }
}

