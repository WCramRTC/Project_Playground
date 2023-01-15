using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Project_Playground
{
    public class BlogPost
    {
        // Fields
        string _header;
        string _body;
        Brush _headerColor;
        Brush _bodyColor;
        DateTime _blogPostTime;

        // Constructor
        public BlogPost(string header, string body)
        {
            _header = header;
            _body = body;
            _blogPostTime = DateTime.Now;
        } // BlogPost

        public BlogPost(string header, string body, Brush headerColor, Brush bodyColor)
        {
            _header = header;
            _body = body;
            _headerColor = headerColor;
            _bodyColor = bodyColor;
            _blogPostTime = DateTime.Now;
        } // BlogPost

        // Properties
        public string Header
        {
            get => _header;
            set
            {
                if(value != "" && value.Length > 3)
                {
                    _header = value;
                }
                else
                {
                    MessageBox.Show("Enter a valid header");
                }
            }
        } // Header

        public string Body
        {
            get => _body;
            set
            {
                if (value != "" && value.Length > 10)
                {
                    _body = value;
                }
                else
                {
                    MessageBox.Show("Enter a valid body");
                }
            }
        } // Header

        // Methods

        public Paragraph Post()
        {
            Paragraph p = new Paragraph();
            p.Inlines.Add(HeaderFormat());
            p.Inlines.Add(BodyFormat());
            return p;
        }
        // Oppertunity to show method overloads
        private Run HeaderFormat()
        {
            string spacing = "\n\n";
            Run header = new Run($"{_blogPostTime.ToLocalTime()} - {_header}{spacing}");
            header.Foreground = _headerColor;
            header.FontSize = 22;
            header.FontWeight = FontWeights.Bold;
            return header;
        }

        private Run BodyFormat()
        {
            Run body = new Run(_body);
            body.Foreground = _bodyColor;
            return body;
        }

        public override string ToString()
        {
            return $"{_blogPostTime.ToShortDateString()} - {_header}";
        }

    }
}
