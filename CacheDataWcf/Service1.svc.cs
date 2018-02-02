using CacheDataWcf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace CacheDataWcf
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "Service1"。
    // 注意: 若要啟動 WCF 測試用戶端以便測試此服務，請在 [方案總管] 中選取 Service1.svc 或 Service1.svc.cs，然後開始偵錯。
    public class Service1 : IService1
    {
        public List<Person> GetData()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Name = "John", Job = "Engineer" });
            list.Add(new Person() { Name = "John cena", Job = "Teacher" });
            list.Add(new Person() { Name = "Kelly", Job = "Athelete" });
            list.Add(new Person() { Name = "Sandy", Job = "Student" });
            list.Add(new Person() { Name = "Jacjy", Job = "Lawer" });
            list.Add(new Person() { Name = "Wish", Job = "Scientist" });
            list.Add(new Person() { Name = "Jenny", Job = "Engineer" });
            list.Add(new Person() { Name = "Fenny", Job = "Lawer" });
            list.Add(new Person() { Name = "Rock", Job = "Engineer" });
            list.Add(new Person() { Name = "Batista", Job = "Student" });
            list.Add(new Person() { Name = "Big Show", Job = "Engineer" });

            Thread.Sleep(10000);
            return list;
        }
    }
}
