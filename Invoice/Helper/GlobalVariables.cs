using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Helper
{
    public static class GlobalVariables
    {
        static int _glbuserId=0;
        static int _glbroleId=0;
        static string _glbName;
        public static int glbUserId
        {
            get
            {
                return _glbuserId;
            }
            set
            {
                _glbuserId = value;
            }
        }
        public static string glbName
        {
            get
            {
                return _glbName;
            }
            set
            {
                _glbName = value;
            }
        }

        public static int glbroleId
        {
            get
            {
                return _glbroleId;
            }
            set
            {
                _glbroleId = value;
            }
        }
    }
}
