using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Playground.Project_Steps
{
    public class BlogPost
    {
        string _header;
        string _body;
        DateTime _postTimeStamp;

        public BlogPost(string header, string body)
        {
            _header = header;
            _body = body;
            _postTimeStamp = DateTime.Now;
        }

        public string Header
        {
            get
            {
                return _header;
            }
            set
            {
                _header = value;
            }
        } // Header

        public string Body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
            }
        } // Header

        public DateTime PostTimeStamp
        {
            get
            {
                return _postTimeStamp;
            }
        } // PostTimeStamp

        public string Post()
        {

            // Date - Header
            // Body

            string date = _postTimeStamp.ToShortDateString();
            string header = $"{date} - {_header}"; 
            string space = $"\n\n";
            string body = _body;

            string full = header + space + body;

            return full;

        }

        public override string ToString()
        {
            return $"{_postTimeStamp.ToShortDateString()} - {_header}";
        }


    }
}
