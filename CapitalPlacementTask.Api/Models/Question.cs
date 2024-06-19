using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalPlacementTask.Api.Models
{
    public abstract class Question
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string QuestionText { get; set; }
    }
    public class ParagraphQuestion : Question
    {
        public string Placeholder { get; set; }
    }

    public class YesNoQuestion : Question
    {
        public bool DefaultValue { get; set; }
    }

    public class DropdownQuestion : Question
    {
        public List<string> Options { get; set; }
        public bool EnableOtherOption { get; set; }
    }

    public class MultipleChoiceQuestion : Question
    {
        public List<string> Options { get; set; }
        public bool EnableOtherOption { get; set; }
        public int MaxChoicesAllowed { get; set; }
    }

    public class DateQuestion : Question
    {
        public DateTime? DefaultValue { get; set; }
    }

    public class NumberQuestion : Question
    {
        public double? DefaultValue { get; set; }
    }
}