using System;
using System.Linq;
using System.Text.RegularExpressions;
using CsharpCourse.Interfaces.Models;

namespace CsharpCourse.Models.Abstract
{
    abstract public class BaseTask : IResolvable
    {
        private string _description;

        public string Description { get => _description; set => _description = value; }

        public virtual void ShowInfo()
        {
            #region ConsoleWrite
            // Move this logic into another part!
            int Width = 80;
            string Title = GetType().Namespace.Split(".").Last() + " : " + GetType().Name;
            double PlaceholderCount = (Width - Title.Length) * 0.5 - 1;
            string Placeholder = new String('-', (int) PlaceholderCount);
            string Header = $"{Placeholder}[ {Title} ]{Placeholder}\n";
            string Pattern = @"(.{1," + Width + @"})(?:\s|$)";
            string LinedDescription = Regex.Replace(Description, Pattern, "$1\n");
            string Separator = new String('=', Header.Length - 1);
            #endregion

            Console.WriteLine($"{Header}{LinedDescription}{Separator}");
        }

        abstract public void Resolve();
    }
}
