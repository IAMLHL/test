using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProgram.Models;

namespace TestProgram.Controllers
{
    public class HomeController : Controller
    {
        meandEntities ET = new meandEntities();
        public ActionResult Index()
        {
            Product p = new Product();

            p.Name = "名称";
            p.Price = "价格";
            p.Number = "数量";

            ViewData["Name"] = "111";
            ViewData["Price"] = "222";
            ViewData["Number"] = "333";
            ViewBag.Name = "xxxx";

            IList<SelectListItem> list = new List<SelectListItem>();
            SelectListItem item1 = new SelectListItem() { Selected = false, Text = "北京", Value = "1" };
            SelectListItem item2 = new SelectListItem() { Selected = false, Text = "上海", Value = "2" };
            SelectListItem item3 = new SelectListItem() { Selected = false, Text = "广州", Value = "3" };
            list.Add(item1);
            list.Add(item2);
            list.Add(item3);



            ViewData["ddl_sss"] = list;

            return View(p);
        }

        delegate int NumberChanger(int n);
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            // 创建委托实例
            NumberChanger nc1 = p => p * 10;
            // 使用委托对象调用方法
            ViewBag.abc = nc1(5);

            int AddTen(int a)
            {
                return a + 10;
            }

            NumberChanger nc2 = new NumberChanger(AddTen);

            ViewBag.def = nc2(5);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult AddMain()
        {
            if (Response.Cookies["uid"] != null)
            {
                string msg = Request.Form["message"];

                M_Message ms = new M_Message();
                ms.Content = msg;
                ms.Addtime = DateTime.Now;

                ET.M_Message.Add(ms);
                int a = ET.SaveChanges();
                if (a>0)
                {
                    return Content("<script>alert('添加成功！');</script>");
                }
                else{
                    return Content("<script>alert('添加失败！');</script>");
                }
            }
            else
            {
                return Content("<script>alert('请先登录！');window.location.href='/Home/Login';</script>");
            }
        }

        public ActionResult Main()
        {
            if (Response.Cookies["uid"] != null)
            {
                var s = Response.Cookies["uid"].Value;
                return View();
            }
            else
            {
                return Content("<script>alert('请先登录！');window.location.href='/Home/Login';</script>");
            }
        }

        public ActionResult AdminLogin()
        {
            string name = Request.Form["log"];
            string pwd = Request.Form["pwd"];

            var m = ET.M_User.Where(u => u.Name == name && u.Pwd == pwd).SingleOrDefault();

            if (m != null)
            {
                Response.Cookies["uid"].Value = m.Id.ToString();
                Response.Cookies["uid"].Expires = DateTime.Now.AddMinutes(1);

                return Content("<script>alert('登录成功，正在为您跳转个人中心！');window.location.href='/Home/Main';</script>");
            }
            else
            {
                return Content("<script>alert('登录失败，用户名或密码不正确！');history.go(-1);</script>");
            }
        }

        public ActionResult Image()
        {
            return View();
        }

        public ActionResult Addtest(Product model)
        {
            Product p = new Product();
            p.Name = model.Name;
            p.Price = model.Price;
            p.Number = model.Number;
            if (ModelState.IsValid)
            {
                return Redirect("/home/About?ss=" + p.ddl_sss);
            }
            else
            {
                return Content("<script>alert('错误');history.go(-1);</script>");
            }
        }
    }
}