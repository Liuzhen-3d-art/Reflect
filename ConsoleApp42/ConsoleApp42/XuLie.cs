using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp42
{
   public class XuLie
    {
        public int JiaGe { get; set; }
        public int ShuLiang { get; set; }
        public string GouMaiChanPin { get; set; }
        public string GouMaiRen { get; set; }
        public string tongJi { get; set; }
        public void TongJi()
        {
            tongJi = $"{GouMaiRen}购买了{GouMaiChanPin}，每一个单价是{JiaGe}，一共买了{ShuLiang}了";
            Console.WriteLine(tongJi);
        }
    }
}
