using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;

namespace ShellSamplePrism.Models
{
    public class CupertinoItem
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }

        public DelegateCommand<string> ItemNavigateCommand { get; set; }
    }
}
