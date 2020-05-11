using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AjaxLabServerSide.Models
{
    public class FilesDictoryDetails
    {
        public int Id { get; set; }
        public List<FilesDictoryDetails> SubChildren { get; set; }
        public bool IsFile { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Text { get; set; }
        public List<FilesDictoryDetails> AllChildren { get; set; }
    }
}