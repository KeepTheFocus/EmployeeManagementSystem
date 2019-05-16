using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
   public static class UtilitySalary
    {
        //工作日加班费率
       static float normalRate  ;
        //周末加班费率
        static float weekRate  ;
        //法定节假日加班费率
       static float festivalRate ;
        //加班费
       static float OvertimeMoney ;
        //应发基本工资和其他福利
        static float OtherBonus;
            
        //基本工资
        static int Basic ;
        //全勤奖
        static int FullAttendance ;
         //职务津贴
        static int  DuttyAllowance ;
        //餐费补贴
        static int MealAllowance;

        //住宿补贴
        static int StayAllowance ;

        //定义一个计算加班费的  辅助函数
        public static float GetOvertimeMoney(int normalHour,int weekHour,int festvalHour)
        {

            OvertimeMoney = normalRate * normalHour + weekRate * weekHour + festivalRate * festvalHour;
            //将计算好的加班费返回给 辅助函数的调用者
            return OvertimeMoney;
        }




        //定义一个计算基本工资和津贴  辅助函数
        public static float GetOtherBonus()
        {
            OtherBonus = Basic + FullAttendance + DuttyAllowance + MealAllowance + StayAllowance ;


            //将计算好的应发工资返回给  辅助函数的调用者
            return OtherBonus;

        }
    }
}
