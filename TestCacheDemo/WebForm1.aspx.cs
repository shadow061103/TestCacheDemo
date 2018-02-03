using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestCacheDemo.ServiceReference1;
using System.Runtime.Caching;
namespace TestCacheDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ObjectCache cache = MemoryCache.Default; //cache
        CacheItemPolicy policy = new CacheItemPolicy();

        protected void Page_Load(object sender, EventArgs e)
        {
            policy.AbsoluteExpiration = DateTime.Now.AddMinutes(1);//指定時間
            //policy.SlidingExpiration = TimeSpan.FromMinutes(1);//一段時間沒用就回收

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Person> list = GetData();
            cache.Set("PersonData", list, policy);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //清cache
            cache.Remove("PersonData");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<Person> list = cache["PersonData"] as List<Person>;
            if (list != null)
            {
                GridView1.DataSource = list;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
            else
            {
                Label1.Text = "無資料，請重新操作!";
                GridView1.Visible = false;
            }

               




        }
        public List<Person> GetData()
        {
            List<Person> list = new List<Person>();
            using (Service1Client service = new Service1Client())
            {
                list = service.GetData().ToList();
            }
            return list;

        }
    }
}