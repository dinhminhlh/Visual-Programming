using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BaiTapDienTu
{
    class QLFile
    {
    static public string doccauhoi(string duongdan)
        {
            string s = "";
            StreamReader sr = new StreamReader(duongdan);
            s = sr.ReadToEnd();
            sr.Close();
            return s;
        }
    static public List<string> docdapan(string duongdan) 
        {
            List<string> ls = new List<string>();
            StreamReader sr = new StreamReader(duongdan);
            string da = "";
            while((da = sr.ReadLine()) != null) 
            { 
                ls.Add(da);
            }
            sr.Close();
            return ls;
        }
    }
}
