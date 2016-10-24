using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Welcome()
        {

            return View();
        }
/// <summary>
/// 
/// </summary>
/// <returns></returns>
        public ActionResult List(int Page=10)
        {
            String[] data = new string[] { "习近平会见蒙古人民党主席",
                "今日推荐HOT歼20战机将以制空迷彩涂装亮相珠海航展",
                "四川八旬夫妻因贫困隐居山洞54年：如今儿是工程师孙是博士",
                "美科幻战舰将部署亚太 上将:要对付黑暗势力" };
            ViewBag.Data = data;
            ViewBag.Page = Page;
            return View();
        }
        /// <summary>
        /// 添加新闻
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {

            return View();
        }
        /// <summary>
        /// 保存新闻内容
        /// </summary>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public ActionResult Seve(string title, string content)
        {
            ViewBag.Title = title;
            ViewBag.Content = content;
            return View();
        }

    }
}