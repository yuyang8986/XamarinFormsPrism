using System;
using System.Collections.Generic;
using System.Text;
using ShellSamplePrism.Services;
using Xamarin.Forms;


[assembly: Dependency(typeof(FancyService))]
namespace ShellSamplePrism.Services
{
     public class FancyService : IFancyService
     {
         public string Text { get; set; } = "Welcome";
     }
}
