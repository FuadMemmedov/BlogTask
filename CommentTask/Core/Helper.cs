using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class  Helper
    {
        public static bool CheckBlogTitle(this string blogTitle)
        {
            if(blogTitle.Length >= 5)
            {
                return true;
            }
            return false;
        }
        public static bool CheckBlogDescription(this string blogDescription)
        {
            if (blogDescription.Length >= 8) 
            {
                return true;
            }
            return false;
        }
    }
}
