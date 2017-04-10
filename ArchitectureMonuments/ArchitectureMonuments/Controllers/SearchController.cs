using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchitectureMonuments.Controllers
{
    public class SearchController : Controller
    {
        
        public ActionResult Result()
        {
            return PartialView("Result");
        }

        [HttpPost]
        public ActionResult Result(String search_text)
        {
            String[] results = search_text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Models.MonumentDBEntities db = new Models.MonumentDBEntities();
            var item = db.Monuments.ToList<Models.Monument>();
            
            List<Models.Monument> toDist = new List<Models.Monument>();
            foreach(var p in item)
            {
                String[] names = p.name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for(int i=0;i<results.Length;i++)
                {
                    for(int j=0;j<names.Length;j++)
                    {
                        if(results[i] == names[j])
                        {
                            toDist.Add(p);
                        }
                    }
                }
            }
            List<Models.Monument> toRedirect = new List<Models.Monument>(toDist.Distinct());
            return PartialView("Result",toRedirect);
        }

    }
}