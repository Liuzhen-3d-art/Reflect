using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
    class ObjectList
    {
        public List<Object> objList { get; set; }
       //public  List<object> zongobjList { get; set; }
        public void MianObjLisst()
        {
            objList = new List<object>();
            objList.Add(typeof(DengJi));
            objList.Add(typeof(FangJu));
            objList.Add(typeof(Ren));
            objList.Add(typeof(ShangHai));
            objList.Add(typeof(XueTiao));
            objList.Add(typeof(ZhuangBei));

        }
    }
}
