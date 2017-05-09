using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Golbal
{
    public abstract class ValidateCodeType
    {
        protected ValidateCodeType()
        {
        }

        public abstract byte[] CreateImage(out string resultCode);

        public abstract string Name { get; }

        public virtual string Tip
        {
            get
            {
                return "请输入图片中的字符";
            }
        }

        public string Type
        {
            get
            {
                return base.GetType().Name;
            }
        }
    }

}