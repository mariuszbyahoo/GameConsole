using System;
using System.Collections.Generic;
using System.Text;

namespace CS8NullBasics
{
    class Message
    {
        public string? From { get; set; } = "";
        public string Text { get; set; } = "";
        public string? ToUpperFrom() => From.ToUpperInvariant(); /* Question mark turns this method into
        a nullable one, still, it generates a warning (or an Error) */
    }
}
