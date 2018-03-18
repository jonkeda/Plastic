using System.Text;

namespace Plastic.Molding
{
    public class HtmlCodeWriter : CodeWriter
    {
    }

    public class CodeWriter
    {
        private readonly StringBuilder _sb = new StringBuilder();
        private int _spaces;

        public void Write(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                _sb.Append(text);
            }
        }

        public void WriteLine(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                LineStart();
                _sb.AppendLine(text);
            }
        }
        public void WriteLine()
        {
            _sb.AppendLine("");
        }

        public void Empty()
        {
            _sb.AppendLine("");
        }

        public void CodeCoverage()
        {
            LineStart();
            _sb.AppendLine(@"[GeneratedCode("""","""")]");
        }

        public void Open()
        {
            LineStart();
            _sb.AppendLine("{");
            _spaces++;
        }

        public void LineStart()
        {
            for (int i = 0; i < _spaces; i++)
            {
                _sb.Append("    ");
            }
        }

        public void Close()
        {
            _spaces--;
            LineStart();
            _sb.AppendLine("}");
  
        }

        public override string ToString()
        {
            return _sb.ToString();
        }
    }
}