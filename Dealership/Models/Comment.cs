using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    class Comment : IComment
    {
        private string content;
        public string Author { get; set; }
        

        public string Content
        {
            get
            {
                return this.content;
            }
            set
            {
                if(value==null)
                {
                    throw new NullReferenceException("Comment cannot be null!");
                }
                this.content = value;
            }
        }
    }
}
