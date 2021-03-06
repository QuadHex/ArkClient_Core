using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace AFCoreEx
{
    public abstract class AFILogicClassManager
    {
        public abstract bool Clear();

        public abstract bool ExistElement(string strClassName);

        public abstract bool AddElement(string strClassName);

        public abstract AFILogicClass GetElement(string strClassName);

        public abstract Dictionary<string, AFILogicClass> GetElementList();

    }
}