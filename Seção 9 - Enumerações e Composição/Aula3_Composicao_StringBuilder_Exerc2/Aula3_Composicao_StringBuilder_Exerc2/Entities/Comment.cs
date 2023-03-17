using System;

namespace Aula3_Composicao_StringBuilder_Exerc2.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
