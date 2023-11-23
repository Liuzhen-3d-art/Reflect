using System;


namespace ConsoleApp42
{


    class ProgramL
    {

        static void Main(string[] args)
        {
            Type type = typeof(ProgramL);
            var objList = Activator.CreateInstance(type) as ProgramL;
            objList.ObjectListRen("老王", 28);
            objList.ObjectListRen("王老吉", 38);
            objList.ObjectListDengji(1, 1000);
            objList.ObjectListDengji(2, 2000);
            objList.ObjectListXueTiao(999);
            objList.ObjectListZhuangBei("罚款之刃", "每次罚款1元就会增加1点攻击力");
            objList.ObjectListShangHai(88);
            objList.ObjectListShangHai(99);
            objList.ObjectListFangJu("反噬板甲", 15, "能被动反噬一次敌人的任何伤害");
            objList.ObjectListRen("红牛", 99);
            objList.ObjectListZhuangBei("反制之盾", "每次罚款1元就会增加1点攻击力");
            long jieguo = objList.GetMaxValuaForInt(int.MaxValue, int.MaxValue);
            Console.WriteLine("结果是"+jieguo);
            Ren ren = new Ren();
            ren.shuji = ren.renji;
            foreach (var item in ren.renji)
            {
                Console.WriteLine(item);
            }
            ProgramL programL = new ProgramL();
            programL.XuLiaHuString();















            //int _dengji = type1.objList.BinarySearch(typeof(DengJi));
            //var dengji = type1.objList[_dengji] as DengJi;
            //dengji = new DengJi();
            //dengji.dengji = 0;
            //dengji.EX = 0;
            //Console.WriteLine($"{leiXingRen.Name}的等级是{dengji.dengji}级。经验值是{dengji.EX}");




        }

        public void ObjectListRen(string yourName, int yourAge)
        {
            Type type = typeof(ObjectList);
            var type1 = Activator.CreateInstance(type) as ObjectList;
            type1.MianObjLisst();


            foreach (var item in type1.objList)
            {
                try
                {
                    if (item == typeof(Ren))
                    {

                        Console.WriteLine("查询成功");
                        //var ren = item as Ren;
                        var ren = Activator.CreateInstance(typeof(Ren)) as Ren;

                        ren.Name = yourName;
                        ren.Age = yourAge;
                        Console.WriteLine($"姓名：{ren.Name},年龄:{ren.Age}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("查询失败,ObjectListRen");
                }
             

            }

        }
        public void ObjectListDengji(int _dengji, int _ex)
        {
            Type type = typeof(ObjectList);
            var type1 = Activator.CreateInstance(type) as ObjectList;
            type1.MianObjLisst();


            foreach (var item in type1.objList)
            {
                try
                {
                    if (item == typeof(DengJi))
                    {

                        Console.WriteLine("查询成功");
                        //var ren = item as Ren;
                        var dengJi = Activator.CreateInstance(typeof(DengJi)) as DengJi;

                        dengJi.dengji = _dengji;
                        dengJi.EX = _ex;
                        Console.WriteLine($"等级：{dengJi.dengji},经验值:{dengJi.EX}");

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("查询失败");
                }
               

            }

        }
        public void ObjectListXueTiao(int hp)
        {
            Type type = typeof(ObjectList);
            var type1 = Activator.CreateInstance(type) as ObjectList;
            type1.MianObjLisst();


            foreach (var item in type1.objList)
            {
                try
                {


                    if (item == typeof(XueTiao))
                    {

                        Console.WriteLine("查询成功");
                        //var ren = item as Ren;
                        var xuetiao = Activator.CreateInstance(typeof(XueTiao)) as XueTiao;

                        xuetiao.Hp = hp;

                        Console.WriteLine($"现在的血条值是:{xuetiao.Hp}");

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("查询失败");
                }
                
               

            }

        }
        public void ObjectListZhuangBei(string zhungBeiName, string zhuangBeiZuoYong)
        {
            Type type = typeof(ObjectList);
            var type1 = Activator.CreateInstance(type) as ObjectList;
            type1.MianObjLisst();


            foreach (var item in type1.objList)
            {
                try
                {
                    if (item == typeof(ZhuangBei))
                    {

                        Console.WriteLine("查询成功");
                        //var ren = item as Ren;
                        var zhuangbei = Activator.CreateInstance(typeof(ZhuangBei)) as ZhuangBei;

                        zhuangbei.ZhuangBeiName = zhungBeiName;
                        zhuangbei.ZhuangBeiZuoYong = zhuangBeiZuoYong;

                        Console.WriteLine($"{zhuangbei.ZhuangBeiName};{zhuangbei.ZhuangBeiZuoYong}");

                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("查询失败");
                }
             
            }

        }
        public void ObjectListShangHai(int shanghaizhi)
        {
            Type type = typeof(ObjectList);
            var type1 = Activator.CreateInstance(type) as ObjectList;
            type1.MianObjLisst();


            foreach (var item in type1.objList)
            {
                try
                {
                    if (item == typeof(ShangHai))
                    {

                        Console.WriteLine("查询成功");
                        //var ren = item as Ren;
                        var shanghai = Activator.CreateInstance(typeof(ShangHai)) as ShangHai;

                        shanghai.ShangHaiZhi = shanghaizhi;

                        Console.WriteLine($"伤害值是{shanghai.ShangHaiZhi}");

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("查询失败");
                }
               
            }
        }
        public void ObjectListFangJu(string _name,int _fangjuzhi,string _texing)
        {
            Type type = typeof(ObjectList);
            var type1 = Activator.CreateInstance(type) as ObjectList;
            type1.MianObjLisst();


            foreach (var item in type1.objList)
            {
                try
                {
                    if (item == typeof(FangJu))
                    {

                        Console.WriteLine("查询成功");
                        //var ren = item as Ren;
                        var fangju = Activator.CreateInstance(typeof(FangJu)) as FangJu;

                        fangju.Name = _name;
                        fangju.TeXing = _texing;
                        fangju.FangYuZhi = _fangjuzhi;
                        

                        Console.WriteLine($"{fangju.Name},防御值是{fangju.FangYuZhi},作用是{fangju.TeXing}。");

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("查询失败");
                }

            }
        }
        public long GetMaxValuaForInt(int a,int b)
        {
            return a + b;
        }
        public void ObjectListFangJu(int a, int b)
        {
            Console.WriteLine(a + b); 
        }
        public void XuLiaHuString()
        {
            Type type2 = typeof(AddList);//反射获取AddList类
            var add = Activator.CreateInstance(type2) as AddList;//进行类型实例化（无参构造函数)
            string b = "";
            XuLie xuLie = new XuLie();//实例化XuLie类
            foreach (var item in add.array)//循环
            {
                if (item.ToString().Contains("JiaGe"))
                {


                    string iteM = item.ToString().Replace("JiaGe=", "");
                    xuLie.JiaGe = int.Parse(iteM);
                    Console.WriteLine(xuLie.JiaGe);
                }
                if (item.ToString().Contains("ShuLiang"))
                {


                    string iteM = item.ToString().Replace("ShuLiang=", "");
                    xuLie.ShuLiang = int.Parse(iteM);
                    Console.WriteLine(xuLie.ShuLiang);
                }
                if (item.ToString().Contains("GouMaiChanPin"))
                {


                    string iteM = item.ToString().Replace("GouMaiChanPin=", "");
                    xuLie.GouMaiChanPin = iteM;
                    Console.WriteLine(xuLie.GouMaiChanPin);
                }
                if (item.ToString().Contains("GouMaiRen"))
                {


                    string iteM = item.ToString().Replace("GouMaiRen=", "");
                    xuLie.GouMaiRen = iteM;
                    Console.WriteLine(xuLie.GouMaiRen);
                    xuLie.TongJi();
                }
            }
           

        }//利用AddList集合反馈的内容，反序列化成对象，再进行展示。
        public void XuLiaHua()
        {
            Type type2 = typeof(AddList);//反射获取AddList类
            var add = Activator.CreateInstance(type2) as AddList;//进行类型实例化（无参构造函数)
            string b = "";
            XuLie xuLie = new XuLie();//实例化XuLie类
            foreach (var item in add.array)//循环
            {
                if (item.ToString().Contains("JiaGe"))
                {


                    string iteM = item.ToString().Replace("JiaGe=", "");
                    xuLie.JiaGe = int.Parse(iteM);
                    Console.WriteLine(xuLie.JiaGe);
                }
                if (item.ToString().Contains("ShuLiang"))
                {


                    string iteM = item.ToString().Replace("ShuLiang=", "");
                    xuLie.ShuLiang = int.Parse(iteM);
                    Console.WriteLine(xuLie.ShuLiang);
                }
                if (item.ToString().Contains("GouMaiChanPin"))
                {


                    string iteM = item.ToString().Replace("GouMaiChanPin=", "");
                    xuLie.GouMaiChanPin = iteM;
                    Console.WriteLine(xuLie.GouMaiChanPin);
                }
                if (item.ToString().Contains("GouMaiRen"))
                {


                    string iteM = item.ToString().Replace("GouMaiRen=", "");
                    xuLie.GouMaiRen = iteM;
                    Console.WriteLine(xuLie.GouMaiRen);
                    xuLie.TongJi();
                }
            }


        }





    }
}
